﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebDevGroupProject.Data;
using WebDevGroupProject.Models;
using System.Linq.Dynamic.Core;
using WebDevGroupProject.ViewModels;

namespace WebDevGroupProject.Controllers
{
    public class ApplicationsEntityController : Controller
    {
        private readonly WebDevGroupProjectContext _context;

        public ApplicationsEntityController(WebDevGroupProjectContext context)
        {
            _context = context;
        }

        // GET: ApplicationsEntity
        public async Task<IActionResult> Index()
        {
            return View(await _context.Application.ToListAsync());
        }

        // GET: ApplicationsEntity/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Application
                .FirstOrDefaultAsync(m => m.ApplicationID == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // GET: ApplicationsEntity/Create
        public IActionResult Create()
        {
            var viewModel = new ApplicationViewModel();
            return View(viewModel);
        }

        // POST: ApplicationsEntity/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ApplicationViewModel viewModel)
        {
            var applicant = new Applicant()
            {
                ApplicantFirstName = viewModel.Applicant.ApplicantFirstName,
                ApplicantLastName = viewModel.Applicant.ApplicantLastName,
                ApplicantMiddleInitial = viewModel.Applicant.ApplicantMiddleInitial,
                ApplicantStreetAddress = viewModel.Applicant.ApplicantStreetAddress,
                ApplicantCity = viewModel.Applicant.ApplicantCity,
                ApplicantCountry = viewModel.Applicant.ApplicantCountry,
                ApplicantZip = viewModel.Applicant.ApplicantZip,
                ApplicantPhone = viewModel.Applicant.ApplicantPhone,
                ApplicantEmail = viewModel.Applicant.ApplicantEmail,
                ApplicantBirthDate = viewModel.Applicant.ApplicantBirthDate,
                ApplicantPrimaryCitizenship = viewModel.Applicant.ApplicantPrimaryCitizenship,
                EthnicOrigin = viewModel.Applicant.EthnicOrigin,
                HispanicLatino = viewModel.Applicant.HispanicLatino,

            };
            var application = new Application()
            {
                ReferenceFirstName = viewModel.Reference.ReferenceFirstName,
                ReferenceLastName = viewModel.Reference.ReferenceLastName,
                ReferenceRelationship = viewModel.Reference.ReferenceRelationship,
                ReferenceEmailAddress = viewModel.Reference.ReferenceEmailAddress,
                ReferencePhoneNumber = viewModel.Reference.ReferencePhoneNumber,

                PolicyHolder = viewModel.HealthRecord.PolicyHolder,
                ProviderName = viewModel.HealthRecord.ProviderName,
                MemberID = viewModel.HealthRecord.MemberID,
                PolicyGroupNumber = viewModel.HealthRecord.PolicyGroupNumber,
                InsuranceCardFrontPath = viewModel.HealthRecord.InsuranceCardFrontPath,
                InsuranceCardBackPath = viewModel.HealthRecord.InsuranceCardBackPath,
                ImmunizationFilePath = viewModel.HealthRecord.ImmunizationFilePath,
                PhysicianName = viewModel.HealthRecord.PhysicianName,
                PracticeName = viewModel.HealthRecord.PracticeName,
                PracticePhoneNumber = viewModel.HealthRecord.PracticePhoneNumber,
                ContactFirstName = viewModel.HealthRecord.ContactFirstName,
                ContactLastName = viewModel.HealthRecord.ContactLastName,
                ContactEmailAddress = viewModel.HealthRecord.ContactEmailAddress,
                ContactPhoneNumber = viewModel.HealthRecord.ContactPhoneNumber,
                ContactRelationship = viewModel.HealthRecord.ContactRelationship,

                PreferredMajor = viewModel.EnrollmentPreferences.PreferredMajor,
                PreferredMinor = viewModel.EnrollmentPreferences.PreferredMinor,
                InterestedInHonors = viewModel.EnrollmentPreferences.InterestedInHonors,
                ResidentialStatus = viewModel.EnrollmentPreferences.ResidentialStatus,
                StudentType = viewModel.EnrollmentPreferences.StudentType,


                HighSchoolName = viewModel.AcademicRecord.HighSchoolName,
                CEEBCode = viewModel.AcademicRecord.CEEBCode,
                GPA = viewModel.AcademicRecord.GPA,
                SAT = viewModel.AcademicRecord.SAT,
                ACT = viewModel.AcademicRecord.ACT,
                HighSchoolTranscriptPath = viewModel.AcademicRecord.HighSchoolTranscriptPath,
                PastUniversities = viewModel.AcademicRecord.PastUniversities,

                ChurchName = viewModel.SpiritualBackground.ChurchName,
                ChurchAddress = viewModel.SpiritualBackground.ChurchAddress,
                ChurchCity = viewModel.SpiritualBackground.ChurchCity,
                ChurchState = viewModel.SpiritualBackground.ChurchState,
                ChurchZip = viewModel.SpiritualBackground.ChurchZip,
                PastorName = viewModel.SpiritualBackground.PastorName,
                PastorEmail = viewModel.SpiritualBackground.PastorEmail,
                ProfessionOfFaith = viewModel.SpiritualBackground.ProfessionOfFaith,
                SpiritualJourney = viewModel.SpiritualBackground.SpiritualJourney,


                CreditCardNumber = viewModel.Billing.CreditCardNumber,
                BillingExpiration = viewModel.Billing.BillingExpiration,
                BillingCVV = viewModel.Billing.BillingCVV,
                BillingName = viewModel.Billing.BillingName,
                BillingAddress = viewModel.Billing.BillingAddress,
                BillingCity = viewModel.Billing.BillingCity,
                BillingState = viewModel.Billing.BillingState,
                BillingZip = viewModel.Billing.BillingZip,
                Signature = viewModel.Billing.Signature,

                Applicant = applicant

            };
            _context.Add(applicant);
            _context.Add(application);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }




        // GET: ApplicationsEntity/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Application.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }
            return View(application);
        }

        // POST: ApplicationsEntity/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Application application)
        {
            if (id != application.ApplicationID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(application);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationExists(application.ApplicationID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(application);
        }

        // GET: ApplicationsEntity/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var application = await _context.Application
                .FirstOrDefaultAsync(m => m.ApplicationID == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // POST: ApplicationsEntity/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var application = await _context.Application.FindAsync(id);
            _context.Application.Remove(application);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicationExists(int id)
        {
            return _context.Application.Any(e => e.ApplicationID == id);
        }
        public async Task<IActionResult> SortedApplicantsReport(QueryOptions queryOptions)
        {
            if (queryOptions == null || string.IsNullOrWhiteSpace(queryOptions.SortField))
            {
                queryOptions = new QueryOptions
                {
                    SortField = "GPA",
                    SortOrder = SortOrder.ASC
                };
            }
            ViewBag.QueryOptions = queryOptions;
            var viewModel = from items in _context.Application.Include(o => o.Applicant)
                            select new SortedApplicantsReportViewModel
                            {
                                ApplicantID = items.Applicant.ApplicantID,
                                FirstName = items.Applicant.ApplicantFirstName,
                                LastName = items.Applicant.ApplicantLastName,
                                GPA = items.GPA
                            };
            return View(await viewModel.OrderBy(queryOptions.Sort).ToListAsync());
        }
        public async Task<IActionResult> HonorsReport(QueryOptions queryOptions)
        {
            if (queryOptions == null || string.IsNullOrWhiteSpace(queryOptions.SortField))
            {
                queryOptions = new QueryOptions
                {
                    SortField = "InterestedInHonors",
                    SortOrder = SortOrder.ASC
                };
            }
            ViewBag.QueryOptions = queryOptions;
            var viewModel = from items in _context.Application.Include(o => o.Applicant)
                            select new HonorsEligibleReportViewModel
                            {
                                ApplicantID = items.Applicant.ApplicantID,
                                ApplicantFirstName = items.Applicant.ApplicantFirstName,
                                ApplicantLastName = items.Applicant.ApplicantLastName,
                                GPA = items.GPA,
                                SAT = items.SAT,
                                ACT = items.ACT,
                                ApplicantEmail = items.Applicant.ApplicantEmail,
                                ApplicantPhone = items.Applicant.ApplicantPhone,
                                InterestedInHonors = items.InterestedInHonors,
                            };
            return View(await viewModel.OrderBy(queryOptions.Sort).ToListAsync());

        }

        public async Task<IActionResult> ReferenceReport(QueryOptions queryOptions)
        {
            if (queryOptions == null || string.IsNullOrWhiteSpace(queryOptions.SortField))
            {
                queryOptions = new QueryOptions
                {
                    SortField = "ApplicantLastName",
                    SortOrder = SortOrder.ASC
                };
            }
            ViewBag.QueryOptions = queryOptions;
            var viewModel = from reference in _context.Application.Include(o => o.Applicant)
                            select new ReferenceReportViewModel
                            {
                                ApplicantID = reference.ApplicationID,
                                ApplicantFirstName = reference.Applicant.ApplicantFirstName,
                                ApplicantLastName = reference.Applicant.ApplicantLastName,
                                ReferenceFirstName = reference.ReferenceFirstName,
                                ReferenceLastName = reference.ReferenceLastName,
                                ReferenceRelationship = reference.ReferenceRelationship,
                                ReferenceEmailAddress = reference.ReferenceEmailAddress,
                                ReferencePhoneNumber = reference.ReferencePhoneNumber
                            };
            return View(await viewModel.OrderBy(queryOptions.Sort).ToListAsync());
        }

        public async Task<IActionResult> ScholarshipEligibilityReport(QueryOptions queryOptions)
        {
            if (queryOptions == null || string.IsNullOrWhiteSpace(queryOptions.SortField))
            {
                queryOptions = new QueryOptions
                {
                    SortField = "ApplicantLastName",
                    SortOrder = SortOrder.ASC
                };
            }
            ViewBag.QueryOptions = queryOptions;
            var viewModel = from items in _context.Application.Include(o => o.Applicant)
                            select new AcademicRecordReportViewModel
                            {
                               
                                ApplicantFirstName = items.Applicant.ApplicantFirstName,
                                ApplicantLastName = items.Applicant.ApplicantLastName,
                                GPA = items.GPA,
                                SAT = items.SAT,
                                ACT = items.ACT,
                                
                            };
            return View(await viewModel.OrderBy(queryOptions.Sort).ToListAsync());
        }

    }
}