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

        [HttpGet]
        public IActionResult HealthRecord()
        {
            var viewModel = new HealthRecordViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult HealthRecord(HealthRecordViewModel viewModel)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ReferenceReport()
        {
            var viewModel = new List<ReferenceReportViewModel>();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ReferenceReport(ReferenceReportViewModel viewModel)
        {
            return RedirectToAction("Reports");
        }
        [HttpGet]
        public IActionResult Relationships()
        {
            var viewModel = new RelationshipsViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Relationships(RelationshipsViewModel viewModel)
        {
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Billing()
        {
            var viewModel = new BillingViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Billing(BillingViewModel viewModel)
        {
            return RedirectToAction("Index");
        }
    }
}
