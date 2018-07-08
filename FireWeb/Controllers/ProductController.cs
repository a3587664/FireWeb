using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FireWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FireBroadcast()
        {
            return View();
        }

        public ActionResult FireBox()
        {
            return View();
        }

        public ActionResult Refuge()
        {
            return View();
        }

        public ActionResult Smoke()
        {
            return View();
        }

        public ActionResult AutoWater()
        {
            return View();
        }

        public ActionResult Kitchen()
        {
            return View();
        }
    }
}