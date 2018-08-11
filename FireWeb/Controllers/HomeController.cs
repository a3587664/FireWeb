using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FireWeb.Models;
using FireWeb.Repository;
using System.IO;

namespace FireWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Dafo()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //人才招募
        public ActionResult Recruit()
        {
            var model = ProductRepository.GetInterviewInfo();
            
            return View(model);
        }
        
        public ActionResult DownloadFile(string fileName)
        {
            string filepath = $"Files/{fileName}";
            string filename = Path.GetFileName(filepath);
            Stream iStream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read);
            return File(iStream, "application/unknown", filename);
        }
    }
}


