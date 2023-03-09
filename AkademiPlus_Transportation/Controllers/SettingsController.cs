using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class SettingsController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();
        [HttpGet]
        public ActionResult Index()
        {
            var values = Session["Username"];
            var uservalue = db.tbl_Admin.Where(x => x.Username == values.ToString()).FirstOrDefault();
            return View(uservalue);
        }
        [HttpPost]
        public ActionResult Index(tbl_Admin p)
        {

            return View();
        }
    }
}