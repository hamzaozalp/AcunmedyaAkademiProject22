using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiProject2._0.Entities;
using AcunmedyaAkademiProject2._0.Context;

namespace AcunmedyaAkademiProject2._0.Controllers
{
    public class AdminCategoryController : Controller
    {
        SweetContext context= new SweetContext();

        [Authorize]
        public ActionResult CategoryList()
        {
            var categories = context.Categories.Include("Products").ToList(); // Use string-based Include
            return View(categories);
        }


    }
}