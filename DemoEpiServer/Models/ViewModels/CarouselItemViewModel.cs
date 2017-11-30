using DemoEpiServer.Business;
using DemoEpiServer.Models.Blocks;
using EPiServer.Core;
using EPiServer.Web.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoEpiServer.Models.ViewModels
{
    public class CarouselItemViewModel
    {
        public IContent Page { get; set; }
        public string PageUrl { get; set; }
        public string TitleText { get; set; }
        public string ImageUrl { get; set; }
        public string Tagline { get; set; }
        public DateTime PublicationDate { get; set; }

        public CarouselItemViewModel(ICarouselBlock carouselContent)
        {
            if (carouselContent is IContent)
            {
                this.Page = carouselContent as IContent;
                this.PageUrl = UrlResolver.Current.GetUrl((carouselContent as IContent).ContentLink);
            }
            else
            {
                this.Page = null;
            }
            TitleText = carouselContent.ShortTitle;
            Tagline = carouselContent.ShortDescription;
            ImageUrl = carouselContent.FeaturedImage.ImageUrl();
            //this.Tagline = GetTagline(carouselContent);
            //this.PublicationDate = GetPublicationDate(carouselContent);
        }

        //private DateTime GetPublicationDate(ICarouselBlock carouselContent)
        //{
        //    if (carouselContent is IPublication)
        //    {
        //        var publicationContent = carouselContent as IPublication;
        //        if (DateTime.Compare(publicationContent.PublicationDate, DateTime.MinValue) != 0)
        //        {
        //            return publicationContent.PublicationDate;
        //        }
        //    }

        //    if (carouselContent is PageData)
        //        return (carouselContent as PageData).StartPublish;
        //    else
        //        return DateTime.MinValue;
        //}

        //private string GetTagline(ICarouselBlock carouselContent)
        //{
        //    if (carouselContent is IPublication)
        //    {
        //        var publicationContent = carouselContent as IPublication;
        //        if (!string.IsNullOrWhiteSpace(publicationContent.Tagline))
        //        {
        //            return publicationContent.Tagline;
        //        }
        //    }
        //    return string.Empty;
        //}
    }
}