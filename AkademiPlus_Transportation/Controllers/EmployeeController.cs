using AkademiPlus_Transportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AkademiPlus_Transportation.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        DbTransportEntities db = new DbTransportEntities();
        public ActionResult Index()
        {
            var values = db.TblEmployee.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(TblEmployee tblEmployee)
        {
            db.TblEmployee.Add(tblEmployee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteEmployee(int id)
        {
            var value = db.TblEmployee.Find(id);
            db.TblEmployee.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateEmployee(int id)
        {
            var value = db.TblEmployee.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateEmployee(TblEmployee c)
        {
            var value = db.TblEmployee.Find(c.EmployeeID);
            value.EmployeeName = c.EmployeeName;
            value.Employeeimage = c.Employeeimage;
            value.EmployeeSurname = c.EmployeeSurname;        
            value.EmployeeDescription = c.EmployeeDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}