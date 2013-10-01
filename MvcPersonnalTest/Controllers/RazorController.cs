using System.Collections.Generic;
using System.Web.Mvc;
using MvcPersonnalTest.BusinessModel;
using MvcPersonnalTest.BusinessServices;

namespace MvcPersonnalTest.Controllers
{
    public class RazorController : Controller
    {
        private const string SUCCESS = "Success";

        //
        // GET: /Razor/
        public ActionResult Index()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            items.Add(new SelectListItem{ Text = "Test 1", Value = "0"});
            items.Add(new SelectListItem{ Text = "Test 2", Value = "1"});
            items.Add(new SelectListItem{ Text = "Test 3", Value = "2"});
            items.Add(new SelectListItem{ Text = "Test 4", Value = "3"});
            ViewBag.TestList = items;
            ViewBag.TextBox = "Name";

            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            var comboBox = collection["TestList"];
            var checkBox = collection["CheckBox"];
            var textBox = collection["TextBox"];
            var radioButton = collection["stringname"];

            ViewBag.ComboBox = comboBox;
            ViewBag.CheckBox = checkBox;
            ViewBag.TextBox = textBox;
            ViewBag.RadioButton = radioButton;

            return View(SUCCESS);
        }

    }
}
