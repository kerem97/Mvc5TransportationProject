using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class ServicesController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialBanner()
        {
            return PartialView();
        }
        public PartialViewResult PartialServices()
        {
            var values = db.Tbl_Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialOffers()
        {
            var values = db.TblOffers.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialWhatWeDo()
        {
            var values = db.Tbl_Services.ToList();
            return PartialView(values);
        }
    }
}