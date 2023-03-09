using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AkademiPlus_Transportation.Models;

namespace AkademiPlus_Transportation.Controllers
{
    
    public class ContactController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblContact tblContact)
        {
            db.TblContact.Add(tblContact);
            db.SaveChanges();
            return RedirectToAction("Index","Contact");
        }
        [HttpGet]
        public ActionResult DeleteContact(int id)
        {
            var value = db.TblContact.Find(id);
            db.TblContact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index","ReceiverMessage");
        }

    }
}