using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CLASS_05.Controllers
{
    public class HOMEController : Controller
    {
        // GET: HOME
        public ActionResult HOME()
        {
            ViewData["Var1"] = "Data comes from ViewData";
            ViewBag.Var2 = "Data comes from ViewBag";
            TempData["Var3"] = "Data comes from TempData";
            Session["Var4"] = "Data comes from Session";

            return View();
        }

        public ActionResult ABOUT()
        {
            TempData["var2"] = "data come from view beg";
            return View();
        }


        public ActionResult CONTACT()
        {
            return View();
        }
    }
}