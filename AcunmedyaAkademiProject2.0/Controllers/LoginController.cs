using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiProject2._0.Entities;
using AcunmedyaAkademiProject2._0.Context;
using System.Web.Security;

namespace AcunmedyaAkademiProject2._0.Controllers
{
    public class LoginController : Controller
    {
        SweetContext context = new SweetContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var user=context.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, true);
                Session["userinfo"] = user.UserName;
                return RedirectToAction("CategoryList", "AdminCategory");
            }
            return View();

        }
    }
}