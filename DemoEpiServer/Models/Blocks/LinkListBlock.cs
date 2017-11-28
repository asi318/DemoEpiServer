using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace DemoEpiServer.Models.Blocks
{
    [ContentType(DisplayName = "LinkListBlock", GUID = "e0ebf7a8-c3b7-4e35-85c0-7d1355db590d", Description = "")]
    public class LinkListBlock : BlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1
            )]
        [CultureSpecific]
        public virtual LinkItemCollection Links { get; set; }
    }
}