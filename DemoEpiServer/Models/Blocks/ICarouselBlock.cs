using EPiServer.Core;

namespace DemoEpiServer.Models.Blocks
{
    public interface ICarouselBlock
    {
        string ShortTitle { get; set; }
        string ShortDescription { get; set; }
        ContentReference FeaturedImage { get; set; }
    }
}