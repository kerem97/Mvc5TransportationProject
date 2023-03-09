using AkademiPlus_Transportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AkademiPlus_Transportation.Controllers
{
   [Authorize]
    public class CustomerController : Controller
    {
        // GET: Customer
        DbTransportEntities db = new DbTransportEntities();
        public ActionResult Index()
        {
            var values = db.TblCustomer.Where(x => x.CustomerCity == "istanbul").ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(TblCustomer tblCustomer)
        {
            db.TblCustomer.Add(tblCustomer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteCustomer(int id)
        {
            var value = db.TblCustomer.Find(id);
            db.TblCustomer.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCustomer(int id)
        {
            var value = db.TblCustomer.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCustomer(TblCustomer c)
        {
            var value = db.TblCustomer.Find(c.CustomerID);
            value.CustomerName = c.CustomerName;
            value.CustomerSurname = c.CustomerSurname;
            value.CustomerPhone = c.CustomerPhone;
            value.CustomerCity = c.CustomerCity;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}