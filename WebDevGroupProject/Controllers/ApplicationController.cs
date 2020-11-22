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
        public IActionResult Applicant()
        {
            var viewModel = new ApplicantViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Applicant(ApplicantViewModel viewModel)
        {
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EnrollmentPreferences()
        {
            var viewModel = new EnrollmentPreferencesViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult EnrollmentPreferences(EnrollmentPreferencesViewModel viewModel)
        {
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult HonorsEligibleReport()
        {
            var viewModel = new List<HonorsEligibleReportViewModel>();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult HonorsEligibleReport(HonorsEligibleReportViewModel viewModel)
        {
            return RedirectToAction("Reports");
        }
    }
}
