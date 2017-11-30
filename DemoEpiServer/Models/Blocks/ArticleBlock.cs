using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using DemoEpiServer.Models.Pages;
using EPiServer.DataAbstraction.Internal;
using EPiServer.UI.Admin;

namespace DemoEpiServer.Models.Blocks
{
    [ContentType(DisplayName = "ArticleBlock", GUID = "6ac585a4-e4c9-498f-a047-26658bd4d9f8", Description = "")]
    [AvailableContentTypes(Include = new[] { typeof(ArticlePage) })]
    public class ArticleBlock : BlockData
    {

        [CultureSpecific]
        [Display( Name = "Select Article Page", Description = "Name field's description", GroupName = SystemTabNames.Content, Order = 1)]            
        public virtual PageReference ArticlePageReference { get; set; }

    }
}