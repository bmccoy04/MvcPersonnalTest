using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPersonnalTest.Controllers
{
    public class BootstrapController : Controller
    {
        //
        // GET: /Bootstrap/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            ModelState.AddModelError(string.Empty, "The user name or password provided is incorrect.");
            ModelState.AddModelError(string.Empty,"Test second meessge.");
            return View();
        }

    }
}
