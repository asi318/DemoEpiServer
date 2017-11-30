using DemoEpiServer.Models.Blocks;
using EPiServer.Shell;

namespace BlogSample.Business.UI
{
    [UIDescriptorRegistration]
    public class ICarouselPageUIDescriptor : UIDescriptor<ICarouselBlock>
    {
        public ICarouselPageUIDescriptor()
            : base(ContentTypeCssClassNames.Page)
        {
            //
        }
    }
}