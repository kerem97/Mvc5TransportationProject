using AkademiPlus_Transportation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AkademiPlus_Transportation.Controllers
{
    public class LoginController : Controller
    {
        DbTransportEntities db = new DbTransportEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(tbl_Admin p)
        {
            var values = db.tbl_Admin.Where(x => x.Username == p.Username & x.Password == p.Password).FirstOrDefault();
            if (values != null )
            {
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["Username"] = p.Username;
                return RedirectToAction("Index", "Customer");
            }
            return View();
        }

    }
}