using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using DemoEpiServer.Business.Rendering;

namespace DemoEpiServer.Models.Pages
{
    [SiteContentType(DisplayName = "Common Page", GUID = "d239e6d5-889b-4904-b650-da2b20867d49", GroupName = Global.GroupNames.Specialized, Description = "")]
    //[SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-standard.png")]
    public class CommonPage : SitePageData
    {
        [Display(
             GroupName = SystemTabNames.Content,
             Order = 310)]
        [CultureSpecific]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 320)]
        public virtual ContentArea RightPanelContentArea { get; set; }
    }
}