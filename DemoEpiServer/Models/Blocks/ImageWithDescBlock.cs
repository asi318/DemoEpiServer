using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace DemoEpiServer.Models.Blocks
{
    [ContentType(DisplayName = "ImageWithDescBlock", GUID = "8cf33c38-1d8f-4d2d-ad9a-3e086296f39a", Description = "")]
    public class ImageWithDescBlock : BlockData
    {
        [Display(
           GroupName = SystemTabNames.Content,
           Order = 1
           )]
        [CultureSpecific]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        /// <summary>
        /// Gets or sets a description for the image, for example used as the alt text for the image when rendered
        /// </summary>
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1
            )]
        [CultureSpecific]
        [UIHint(UIHint.LongString)]
        public virtual string ImageDescription
        {
            get
            {
                var propertyValue = this["ImageDescription"] as string;

                // Return image description with fall back to the heading if no description has been specified
                return string.IsNullOrWhiteSpace(propertyValue) ? string.Empty : propertyValue;
            }
            set { this["ImageDescription"] = value; }
        }
    }
}