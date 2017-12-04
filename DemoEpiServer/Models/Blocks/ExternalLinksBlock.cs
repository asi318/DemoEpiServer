using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using DemoEpiServer.Helpers;

namespace DemoEpiServer.Models.Blocks
{
    [ContentType(DisplayName = "ExternalLinksBlock", GUID = "2fc05828-4aa0-4292-8eae-c0f78c76950e", Description = "")]
    public class ExternalLinksBlock : BlockData
    {
        [Display(
           GroupName = SystemTabNames.Content,
           Order = 1
           )]
        [CultureSpecific]
        public virtual LinkItemCollection Links
        {
            get
            {
                return ExternalContent.GetExternalLinks("~/App_Data/DocumentsJSON.json");
             }
         }
    }
}