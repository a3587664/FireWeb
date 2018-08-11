using FireWeb.Models;
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

        [HttpPost]
        public JsonResult Update([FromBody] Interview data)
        {


            ProductRepository.UpdateInterviewInfo(data);

            return Json("success");
        }
    }
}