using Hospital_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital_Management.Controllers
{
    public class PathologyTestController : Controller
    {
        // GET: PathologyTest
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(PathologyTest pathologyTest)
        {
            if (ModelState.IsValid)
            {
                return Json("true");
            }
            else
            {
                return Json("false");
            }
        }
    }
}