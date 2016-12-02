using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using vue_mvc.Models;

namespace vue_mvc.Controllers
{
    public class ExampleSeedingRazorController : Controller
    {
        // GET: ExampleSeedingRazor
        public ActionResult Index()
        {

            var serverModel = JsonConvert.SerializeObject(new
            {
                Name = "Marco",
                Surname = "Muscat",
                Description = "Vue data loaded from razor!"
            });

            return View(new SampleModel()
            {
                Data = serverModel
            });
        }

        [HttpGet]
        public JsonResult GetData(int? id)
        {
            if (!id.HasValue) throw new ApplicationException("Informe um id, anemal!");

            return Json(new
            {
                Name = "Lucio",
                Surname = "Fernando",
                Description = "Seu amigo hothot!!"
            }, JsonRequestBehavior.AllowGet);
        }
    }
}