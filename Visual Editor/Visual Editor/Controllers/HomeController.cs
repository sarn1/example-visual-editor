using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Visual_Editor.Models;
using System.Web;

namespace Visual_Editor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Results()
        {
            ResultsViewModel Model = new ResultsViewModel()
            {
                Text = Request.Form["text"],
                TextEncoded = HttpUtility.HtmlEncode(Request.Form["text"])
                
            };

            return View(Model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
