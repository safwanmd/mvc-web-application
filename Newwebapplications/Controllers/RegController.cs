using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newwebapplications.Models;

namespace Newwebapplications.Controllers
{
    public class RegController : Controller
    {
        // GET: Reg
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertDetails(RegistrationDetails obj)
        {
            RegistrationDetails objreg = new RegistrationDetails();
            string result = objreg.InsertRegDetails(obj);
            ViewData["result"] = result;
            ModelState.Clear();
            return View();
        }
    }
}