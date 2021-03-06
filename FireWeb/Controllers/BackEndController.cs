﻿using FireWeb.Models;
using FireWeb.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FireWeb.Controllers
{
    public class BackEndController : Controller
    {
        public ActionResult Index()
        {
            var model = ProductRepository.GetInterviewInfo();

            return View(model);
        }

        public ActionResult ContactInfo()
        {
            var model = ProductRepository.GetContactInfo();
            return View(model);
        }

        public ActionResult DeleteContactInfo(string name)
        {
            ProductRepository.DeleteContactInfo(name);
            return RedirectToAction("ContactInfo");
        }

        public ActionResult DeleteInterviewInfo(string name)
        {
            ProductRepository.DeleteInterviewInfo(name);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult NewInterviewInfo([FromBody]Interview data)
        {
            ProductRepository.AddInterviewInfo(data);

            return Json("success");
        }

        [HttpPost]
        public JsonResult Update([FromBody] Interview data)
        {
            ProductRepository.UpdateInterviewInfo(data);

            return Json("success");
        }
    }
}