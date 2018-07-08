using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FireWeb.Controllers
{
    public class NewsController : Controller
    {
        //最新消息
        public IActionResult Index()
        {
            return View();
        }

        //相關連結
        public IActionResult RelatedLinks()
        {
            return View();
        }

        //消防法規
        public IActionResult FireRegulations()
        {
            return View();
        }

        //消防署法令解釋
        public IActionResult FireLegalInterpretation()
        {
            return View();
        }

    }
}