using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FireWeb.Controllers
{
    public class AchievementController : Controller
    {
        //工程實績
        public IActionResult Index()
        {
            return View();
        }

        //公家機關
        public IActionResult Public()
        {
            return View();
        }

        //教育機關
        public IActionResult Education()
        {
            return View();
        }

        //醫療機關
        public IActionResult Medical()
        {
            return View();
        }

        //金融機關
        public IActionResult Financial()
        {
            return View();
        }

        //飯店、旅館
        public IActionResult Hotel()
        {
            return View();
        }

        //公司、工廠
        public IActionResult Company()
        {
            return View();
        }

        //甲類場所
        public IActionResult ClassA()
        {
            return View();
        }

    }
}