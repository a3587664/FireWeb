using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FireWeb.Models;
using FireWeb.Repository;

namespace FireWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var testData = ProductRepository.GetUser();
            return View(testData);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //人才招募
        public IActionResult Recruit()
        {
            return View();
        }
    }
}
