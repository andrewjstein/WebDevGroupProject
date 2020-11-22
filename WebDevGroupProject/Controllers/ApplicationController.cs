using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebDevGroupProject.ViewModels;

namespace WebDevGroupProject.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Reference()
        {
            var viewModel = new ReferenceViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Reference(ReferenceViewModel viewModel)
        {
            return RedirectToAction("Index"); 
        }
    }
}
