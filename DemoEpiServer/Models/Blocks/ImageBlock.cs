using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace DemoEpiServer.Models.Blocks
{
    [ContentType(DisplayName = "ImageBlock", GUID = "1d9bdafa-8501-4a9b-9e18-0bc80b32325a", Description = "")]
    public class ImageBlock : BlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1
            )]
        [CultureSpecific]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
    }
}