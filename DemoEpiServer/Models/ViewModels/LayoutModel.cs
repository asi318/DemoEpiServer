using System.Web;
using System.Web.Mvc;
using EPiServer.SpecializedProperties;
using DemoEpiServer.Models.Blocks;

namespace DemoEpiServer.Models.ViewModels
{
    public class LayoutModel
    {
        public SiteLogotypeBlock Logotype { get; set; }
        public IHtmlString LogotypeLinkUrl { get; set; }
        public bool HideHeader { get; set; }
        public bool HideFooter { get; set; }
        public LinkItemCollection ProductPages { get; set; }
        public LinkItemCollection CompanyInformationPages { get; set; }
        public LinkItemCollection NewsPages { get; set; }
        public LinkItemCollection CustomerZonePages { get; set; }
        public bool LoggedIn { get; set; }
        public MvcHtmlString LoginUrl { get; set; }
        public MvcHtmlString LogOutUrl { get; set; }
        public MvcHtmlString SearchActionUrl { get; set; }
        public MvcHtmlString AboutUsActionUrl { get; set; }
        public MvcHtmlString ContactUsActionUrl { get; set; }
        public MvcHtmlString CareersActionUrl { get; set; }

        public bool IsInReadonlyMode {get;set;}
    }
}
