using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using DemoEpiServer.Models.Pages;
using DemoEpiServer.Models.ViewModels;

namespace DemoEpiServer.Controllers
{
    public class ArticlePageController : PageControllerBase<ArticlePage>
    {
        public ActionResult Index(ArticlePage currentPage)
        {
            var model = PageViewModel.Create(currentPage);            

            return View(model);
        }
    }
}