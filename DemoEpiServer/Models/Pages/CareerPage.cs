using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace DemoEpiServer.Models.Pages
{
    [ContentType(DisplayName = "CareerPage", GUID = "f67902d6-027e-4ce8-9c18-da1704b48356", Description = "")]
    public class CareerPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Career Content",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual ContentArea CareerContent { get; set; }

    }
}