using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace DemoEpiServer.Models.Blocks
{
    [ContentType(DisplayName = "AccordionContentBlock", GUID = "1B0EFA63-B816-43F7-92C0-B27F84307AB6", Description = "")]
    public class AccordionContentBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Accordion ID",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string ID { get; set; }
        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Description",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString Description { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Featured Image",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual ContentReference Image { get; set; }

    }
}