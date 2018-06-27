using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickWebProjectMVC.Controllers
{
    public class MealsController : Controller
    {
        // GET: Meals
        public ActionResult Meals()
        {
            return View();
        }
    }
}