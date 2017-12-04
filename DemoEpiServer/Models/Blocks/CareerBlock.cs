using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace DemoEpiServer.Models.Blocks
{
    [ContentType(DisplayName = "CareerBlock", GUID = "949d258f-b670-4d53-97c0-dc269c4655fe", Description = "")]
    public class CareerBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Job Title",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Job Skills",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Skills { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Job Description",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string JobDescription { get; set; }

    }
}