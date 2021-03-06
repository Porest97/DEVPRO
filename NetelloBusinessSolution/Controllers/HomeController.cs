﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetelloBusinessSolution.Models;

namespace NetelloBusinessSolution.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult People()
        {
            return View();
        }
        public IActionResult BusinessCentres()
        {
            return View();
        }
        public IActionResult Documents()
        {
            return View();
        }
        public IActionResult OrdersAndReciepts()
        {
            return View();
        }
        public IActionResult Economics()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
