
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPRazorDBApp.Controllers
{
    using Models;
    using Extensions;

    public class HomeController : Controller
    {
        PlantsCatalogEntities entities = new PlantsCatalogEntities();

        ~HomeController()
        {
            entities.Dispose();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadData()
        {
            XmlParser.LoadXmlFromEntity();

            return Redirect(Url.Action("Next"));
        }

        static int pageNum;
        public ActionResult Next()
        {
            pageNum++;
            var pageItem = entities.Plants.GetPages(pageNum).ToArray();

            if(pageItem.Length > 0)
            {
                this.ViewBag.Plants = pageItem;
            }
            else
            {
                pageNum = 1;
                this.ViewBag.Plants = entities.Plants.GetPages(1).ToArray();
            }
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}