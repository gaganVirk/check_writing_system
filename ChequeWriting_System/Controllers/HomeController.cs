using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChequeWriting_System.Models;

namespace ChequeWriting_System.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


   /*     [HttpPost]
        public IActionResult Index(Models.ChequeWriting chequeWriting)
        {
            ViewBag.Number = chequeWriting.Number;
            return Content($"Hello {chequeWriting.Number}");
        }*/

        [HttpPost]
        public IActionResult Index(Models.ChequeWriting chequeWriting)
        {
            return View($"Hello {chequeWriting.Number}");
        }

    }
}