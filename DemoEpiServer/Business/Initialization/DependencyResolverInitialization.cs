using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using DemoEpiServer.Business.Rendering;
using EPiServer.Web.Mvc;
using EPiServer.Web.Mvc.Html;
using EPiServer.Forms.Core;
using EPiServer;
using EPiServer.Forms.Core.Events;
using EPiServer.Core;
using EPiServer.Forms.Core.Models;
using System.Linq;
using EPiServer.Find.Helpers.Text;
using DemoEpiServer.Models;

namespace DemoEpiServer.Business.Initialization
{
    [InitializableModule]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            //Implementations for custom interfaces can be registered here.

            context.ConfigurationComplete += (o, e) =>
            {
                //Register custom implementations that should be used in favour of the default implementations
                context.Services.AddTransient<IContentRenderer, ErrorHandlingContentRenderer>()
                    .AddTransient<ContentAreaRenderer, AlloyContentAreaRenderer>();
            };
        }

        public void Initialize(InitializationEngine context)
        {
            DependencyResolver.SetResolver(new ServiceLocatorDependencyResolver(context.Locate.Advanced));
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }


    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class FormEventsInit : IInitializableModule
    {
        private Injected<IFormRepository> _formRepository;
        private Injected<IContentLoader> _contentLoader;

        public void Initialize(InitializationEngine context)
        {
            FormsEvents.Instance.FormsSubmitting += Instance_FormsSubmitting;
        }

        private void Instance_FormsSubmitting(object sender, FormsEventArgs e)
        {
            // The event fires before the data is submitted so there is an opportunity to interact here
            //var formData = e.Data;
            //var formName = ((Castle.Proxies.FormContainerBlockProxy)e.FormsContent).Name

            var submission = e as FormsSubmittingEventArgs;
            IContent content = _contentLoader.Service.Get<IContent>(e.FormsContent.ContentLink);
            ILocalizable localizable = content as ILocalizable;
            FormIdentity formsId = new FormIdentity(e.FormsContent.ContentGuid, localizable.MasterLanguage.Name);
            var friendlyNameInfos = _formRepository.Service.GetDataFriendlyNameInfos(formsId);
            string nameValue = null;
            string emailValue = null;
            var friendlyNameId = friendlyNameInfos.FirstOrDefault(x => x.FriendlyName == "Name");
            if (friendlyNameId != null && !friendlyNameId.FriendlyName.IsNullOrWhiteSpace())
            {
                var pageId = submission.SubmissionData.Data.FirstOrDefault(x => x.Key == friendlyNameId.ElementId);
                nameValue = (string)pageId.Value;
            }
            var friendlyEmailId = friendlyNameInfos.FirstOrDefault(x => x.FriendlyName == "Email");
            if (friendlyEmailId != null && !friendlyEmailId.FriendlyName.IsNullOrWhiteSpace())
            {
                var pageId = submission.SubmissionData.Data.FirstOrDefault(x => x.Key == friendlyEmailId.ElementId);
                emailValue = (string)pageId.Value;
            }

            if (string.IsNullOrEmpty(nameValue) || string.IsNullOrEmpty(emailValue))
            {
                submission.CancelAction = true;
                submission.CancelReason = "Name and Email id are mandatory fields.";
                return;
            }

            DDSFormModel ddsModel = new DDSFormModel()
            {
                Name = nameValue,
                Email = emailValue
            };

            try
            {
                DDSFormDBManager dDSFormDBManager = new DDSFormDBManager();
                dDSFormDBManager.SaveData(ddsModel);
            }
            catch (System.Exception ex)
            {
                submission.CancelAction = true;
                submission.CancelReason = ex.Message;
            }
        }

        public void Uninitialize(InitializationEngine context) { }
    }
}
