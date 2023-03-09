using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    
    public class AboutController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();
        // GET: About

        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialBanner()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.Tbl_About.ToList();
            return PartialView(values);
           
        }
        public PartialViewResult Partialstats()
        {
            return PartialView();
        }
        public PartialViewResult PartialJoinMain()
        {
            return PartialView();
        }
        public PartialViewResult PartialJoinTeam()
        {
            var values = db.TblEmployee.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialQuestions()
        {
            var values = db.TblQuestions.ToList();
            return PartialView(values);
        }

    }
}