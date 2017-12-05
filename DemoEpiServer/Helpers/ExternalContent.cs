using EPiServer.SpecializedProperties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace DemoEpiServer.Helpers
{
    public class ExternalContent
    {

        /// <summary>
        /// Retrieveing  documents list from remote location 
        /// </summary>
        /// <param name="externalURL"></param>
        public static LinkItemCollection GetExternalLinks(string externalURL)
        {
            

            ExternalDocStub externalLinksObj = new Helpers.ExternalDocStub();
            using (StreamReader sr = new StreamReader(HostingEnvironment.MapPath(externalURL)))
            {
                externalLinksObj = JsonConvert.DeserializeObject<ExternalDocStub>(sr.ReadToEnd());
            }
          

            List<LinkItem> listItem = new List<LinkItem>();

            foreach(var asset in externalLinksObj.Assets)
            {
                LinkItem lnkItem = new LinkItem();
                lnkItem.Title = asset.Title;
                lnkItem.Text = asset.PreviewURL;
                lnkItem.Href = asset.URL;
                listItem.Add(lnkItem);
            }

            LinkItemCollection itemCollection = new LinkItemCollection(listItem);
            return itemCollection;

        }
    }
}