﻿using AcunmedyaAkademiProject2._0.Context;
using AcunmedyaAkademiProject2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademiProject2.Controllers
{
    [Authorize]
    public class StatisticController : Controller
    {
        // GET: Statistic
        SweetContext context = new SweetContext();
        public ActionResult StatisticList()
        {
            StatisticsViewModel model = new StatisticsViewModel();

            model.ProductCount = context.Products.Count();
            model.CategoryCount = context.Categories.Count();

            // Bu değerleri istediğin gibi değiştirebilirsin.
            Random rnd = new Random();
            model.HappyCustomerCount = rnd.Next(50, 200); // 50 ile 200 arasında rastgele bir sayı
            model.OrderCount = rnd.Next(100, 500);        // 100 ile 500 arasında
            model.SupplierCount = rnd.Next(5, 20);       // 5 ile 20 arasında
            model.TotalStockQuantity = rnd.Next(1000, 5000); // 1000 ile 5000 arasında
            model.ActiveOrderCount = rnd.Next(10, 100);    // 10 ile 100 arasında


            //Bu alandaki değerler veri tabanından gelir
            model.MinProductPrice = context.Products.Any() ? context.Products.Min(p => p.Price) : 0;
            model.MaxProductPrice = context.Products.Any() ? context.Products.Max(p => p.Price) : 0;
            model.AverageProductPrice = context.Products.Any() ? context.Products.Average(p => p.Price) : 0;

            model.MostExpensiveProductName = context.Products.Any() ? context.Products.OrderByDescending(p => p.Price).FirstOrDefault().ProductName : "No Product";
            model.CheapestProductName = context.Products.Any() ? context.Products.OrderBy(p => p.Price).FirstOrDefault().ProductName : "No Product";

            return View(model);
        }
    }
}