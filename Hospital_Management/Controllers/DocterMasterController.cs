using DataLayer;
using Hospital_Management.CustomLogics;
using Hospital_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hospital_Management.Controllers
{
    public class DocterMasterController : Controller
    {
        Hospital_DBEntities hdb = new Hospital_DBEntities();
        public ActionResult Index()
        {
            DocterMaster dm = new DocterMaster();
            //dm.Docter_id = HMCustomLogics.getAutoIncreamentId(hdb.Tbl_Docter.Select(x => x.Id).Count(), "DOC");

            dm.Docter_id = "DOC00001";



            return View(dm);
        }
    }
}