using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.Collections.Generic;

namespace DemoEpiServer.Models.Blocks
{
    [ContentType(DisplayName = "CarouselBlock", GUID = "9c31e0cd-b982-4370-9e46-2963b3fb23f8", Description = "")]
    public class CarouselBlock : SiteBlockData, ICarouselBlock
    {
        [Display(Name = "Short Title",
            Description = "Used in places where the actual title might be too long. For example, the home page carousel.",
            GroupName = Global.GroupNames.Carousel,
            Order = 100)]
        public virtual string ShortTitle { get; set; }

        [Display(Name = "Tag Line",
            Description = "Used in places where the actual title might be too long. For example, the home page carousel.",
            GroupName = Global.GroupNames.Carousel,
            Order = 100)]
        public virtual string ShortDescription { get; set; }

        [Display(Name = "Featured Image",
            Description = "Will appear in places like the Homepage Carousel.",
            GroupName = Global.GroupNames.Carousel,
            Order = 200)]
        public virtual ContentReference FeaturedImage { get; set; }

        
    }
}