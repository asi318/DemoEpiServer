using EPiServer.Core;

namespace DemoEpiServer.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
