using ChequeWritingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChequeWritingSystem.Controllers
{
    public class ChequeWritingController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            ChequeWriting chequeWriting = new ChequeWriting();
            try
            { 
                string value = ChequeWriting.ConvertAmount(double.Parse(fc["Number"]));
                chequeWriting.Currency = value;
                ViewBag.Currency = chequeWriting.Currency;
                
            }
            catch (Exception ex)
            {
                ViewBag.Currency = ex.Message;
            }
                
             return View("Index");
        }
    }
}