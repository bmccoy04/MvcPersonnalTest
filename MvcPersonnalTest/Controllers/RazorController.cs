using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPersonnalTest.Controllers
{
    public class RazorController : Controller
    {
        public const string index = "Index";
        public const string SUCCESS = "Success";

        //
        // GET: /Razor/

        public ActionResult Index()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem(){ Text = "Test 1", Value = "0"});
            items.Add(new SelectListItem(){ Text = "Test 2", Value = "1"});
            items.Add(new SelectListItem(){ Text = "Test 3", Value = "2"});
            items.Add(new SelectListItem(){ Text = "Test 4", Value = "3"});
            ViewBag.TestList = items;
            ViewBag.TextBox = "Name";

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            var checkBox = collection["stringname"];
            var textBox = collection["TextBox"];
            
            return View(SUCCESS);
        }

    }
}
