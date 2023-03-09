using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    public class DefaultController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.Tbl_About.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialDetails()
        {
            ViewBag.leftTitle1 = "Güvenli Taşımacılık";
            ViewBag.leftTitle2 = "Her Boyut Kargo ve Her Tür Ürün";
            ViewBag.leftTitle3 = "Dünya'nın Her Yerine Zamanında Teslimat";
            ViewBag.rightTitle1 = "Kolay Takip";
            ViewBag.rightTitle2 = "Kendi Paketleme Sistemimiz İle Tüm Ürünlerinizi Paketliyoruz ";
            ViewBag.rightTitle3 = "Dünya'nın Her Yerinde Bir Dağıtım Merkezi";
            ViewBag.rightTitle4 = "Kendi Seçtiğiniz Saatte Teslimat";
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialMap()
        {
            return PartialView();
        }
        public PartialViewResult PartialServices()
        {
            return PartialView();
        }
        public PartialViewResult PartialServicesType()
        {
            var values = db.Tbl_Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonials()
        {
            return PartialView();
        }
        public PartialViewResult PartialNewsLetter()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

     
    }
}