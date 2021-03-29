using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChequeWriting_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChequeWriting_System.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
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
        public ViewResult Index(ChequeWriting chequeWriting)
        {
            return View("Hello");
        }

    }
}