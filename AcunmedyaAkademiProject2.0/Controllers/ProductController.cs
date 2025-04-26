using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiProject2._0.Context;
namespace AcunmedyaAkademiProject2._0.Controllers
{
    public class ProductController : Controller
    {
        SweetContext context= new SweetContext();
        public ActionResult ProductList()
        {
            var values= context.Products.ToList(); 
            return View(values);
        }
    }
}