using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace DemoEpiServer.Models.Blocks
{
    [ContentType(DisplayName = "AccordionBlock", GUID = "87c9955e-3f88-491d-9b71-41a8bbf6a586", Description = "")]
    public class AccordionBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Name { get; set; }

    }
}