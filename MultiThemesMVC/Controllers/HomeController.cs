using MultiThemesMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiThemesMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {          
            return View();
        }

        /// <summary>
        /// Get All of themes
        /// </summary>
        /// <returns></returns>
        public PartialViewResult GetThemes()
        {
            return PartialView("_GetThemes");
        }

        /// <summary>
        /// update Current Theme
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ChangeThemeSite(string ThemeName)
        {
            Session["Style"] = ThemeName;
            return Json(true, JsonRequestBehavior.AllowGet);
        }

    }
}
