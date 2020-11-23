using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebDevGroupProject.Models;
using WebDevGroupProject.ViewModels;

namespace WebDevGroupProject.Controllers
{
    public class ApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Reports()
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
            var role = new List<FamilyRole>()
            {
                new FamilyRole() {RoleID = 1, RoleName = "None"},
            };
            var viewModel = new RelationshipsViewModel();
            viewModel.FamilyRole = new SelectList(role, "FamilyRoleID", "RoleName");
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
        [HttpGet]
        public IActionResult Applicant()
        {
            var ethnicorigin = new List<EthnicOrigin>()
            {
                new EthnicOrigin() {EthnicOriginID = 1, Description = "American Indian or Alaska Native"},
                new EthnicOrigin() {EthnicOriginID = 2, Description = "Asian"},
                new EthnicOrigin() {EthnicOriginID = 3, Description = "Black or African American"},
                new EthnicOrigin() {EthnicOriginID = 4, Description = "Middle Eastern"},
                new EthnicOrigin() {EthnicOriginID = 5, Description = "Native Hawaiian or Other Pacific"},
                new EthnicOrigin() {EthnicOriginID = 6, Description = "White"},
            };
            var viewModel = new ApplicantViewModel();
            viewModel.EthnicOrigin = new SelectList(ethnicorigin, "EthnicOriginID", "Description");

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
            var studenttype = new List<StudentType>()
            {
                new StudentType() {StudentTypeID = 1, Description = "Full Time"},
                new StudentType() {StudentTypeID = 2, Description = "Part Time"}
            };
            var residentialstatus = new List<ResidentialStatus>()
            {
                new ResidentialStatus() {ResidentialStatusID = 1, Description = "Resident"},
                new ResidentialStatus() {ResidentialStatusID = 2, Description = "Commuter"}
            };
            var viewModel = new EnrollmentPreferencesViewModel();
            viewModel.StudentType = new SelectList(studenttype, "StudentTypeID", "Description");
            viewModel.ResidentialStatus = new SelectList(residentialstatus, "ResidentialStatusID", "Description");

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult EnrollmentPreferences(EnrollmentPreferencesViewModel viewModel)
        {
            return RedirectToAction("Index");
        }
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

        [HttpGet]
        public IActionResult AcademicRecord()
        {
            var viewModel = new AcademicRecordViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AcademicRecord(AcademicRecordViewModel viewModel)
        {
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult SpiritualBackgournd()
        {
            var viewModel = new SpiritualBackgroundViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SpiritualBackground(SpiritualBackgroundViewModel viewModel)
        {
            return RedirectToAction("Index");
        }

    }
}
