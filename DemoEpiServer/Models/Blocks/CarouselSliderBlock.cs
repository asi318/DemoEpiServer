using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace DemoEpiServer.Models.Blocks
{
    [ContentType(DisplayName = "CarouselSliderBlock", GUID = "7cecdcc7-498b-4125-9d72-7e7f05098848", Description = "")]
    public class CarouselSliderBlock : BlockData,ICarouselBlock
    {
        [Display(Order = 10)]
        public virtual ContentArea CarouselContentArea { get; set; }

        [Display(Name = "Short Title",
           Description = "Used in places where the actual title might be too long. For example, the home page carousel.",
           GroupName = Global.GroupNames.Carousel,
           Order = 20)]
        public virtual string ShortTitle { get; set; }

        [Display(Name = "Featured Image",
            Description = "Will appear in places like the Homepage Carousel.",
            GroupName = Global.GroupNames.Carousel,
            Order = 30)]
        public virtual ContentReference FeaturedImage { get; set; }

        [Display(Name = "Tag Line",
            Description = "Used in places where the actual title might be too long. For example, the home page carousel.",
            GroupName = Global.GroupNames.Carousel,
            Order = 40)]
        string ICarouselBlock.ShortDescription { get; set; }

        [Display(Order = 50)]
        public virtual int? Interval { get; set; }

        [Display(Order = 60)]
        public virtual int? ImageHeight { get; set; }

        [Display(Order = 40)]
        public virtual int? ImageWidth { get; set; }

        public IEnumerable<IContent> Slides
        {
            get
            {
                if (CarouselContentArea == null)
                {
                    return Enumerable.Empty<IContent>();
                }

                return CarouselContentArea.FilteredItems
                    .Select(item => item.GetContent());
            }
        }

        public bool HasSlides
        {
            get { return Slides.Any(); }
        }
    }
}