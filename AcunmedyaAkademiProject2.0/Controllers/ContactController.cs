using AcunmedyaAkademiProject2._0.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademiProject2._0.Controllers
{
    public class ContactController : Controller
    {
        SweetContext context = new SweetContext();
        public ActionResult Index()
        {
            var contacts = context.Contacts.ToList();
            return View(contacts);
        }
    }
    
}