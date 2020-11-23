using System;
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
            return View();
        }

        // POST: ApplicationsEntity/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApplicationID,ApplicationDate,HighSchoolName,CEEBCode,GPA,SAT,ACT,HighSchoolTranscriptPath,PreferredMajor,PreferredMinor,InterestedInHonors,ChurchName,ChurchAddress,ChurchCity,ChurchState,ChurchZip,PastorName,PastorEmail,ProfessionOfFaith,SpiritualJourney,PolicyHolder,ProviderName,MemberID,PolicyGroupNumber,InsuranceCardFrontPath,InsuranceCardBackPath,ImmunizationFilePath,PhysicianName,PracticeName,PracticePhoneNumber,ContactFirstName,ContactLastName,ContactEmailAddress,ContactPhoneNumber,ContactRelationship,ReferenceFirstName,ReferenceLastName,ReferenceRelationship,ReferenceEmailAddress,ReferencePhoneNumber,CreditCardNumber,BillingExpiration,BillingCVV,BillingName,BillingAddress,BillingCity,BillingState,BillingZip,Signature")] Application application)
        {
            if (ModelState.IsValid)
            {
                _context.Add(application);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(application);
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
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApplicationID,ApplicationDate,HighSchoolName,CEEBCode,GPA,SAT,ACT,HighSchoolTranscriptPath,PreferredMajor,PreferredMinor,InterestedInHonors,ChurchName,ChurchAddress,ChurchCity,ChurchState,ChurchZip,PastorName,PastorEmail,ProfessionOfFaith,SpiritualJourney,PolicyHolder,ProviderName,MemberID,PolicyGroupNumber,InsuranceCardFrontPath,InsuranceCardBackPath,ImmunizationFilePath,PhysicianName,PracticeName,PracticePhoneNumber,ContactFirstName,ContactLastName,ContactEmailAddress,ContactPhoneNumber,ContactRelationship,ReferenceFirstName,ReferenceLastName,ReferenceRelationship,ReferenceEmailAddress,ReferencePhoneNumber,CreditCardNumber,BillingExpiration,BillingCVV,BillingName,BillingAddress,BillingCity,BillingState,BillingZip,Signature")] Application application)
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
            var viewModel = from items in _context.Application
                            select new SortedApplicantsReportViewModel
                            {
                                ApplicantID = items.Applicant.ApplicantID,
                                FirstName = items.Applicant.ApplicantFirstName,
                                LastName = items.Applicant.ApplicantLastName,
                                GPA = items.GPA
                            };
            ViewBag.QueryOptions = queryOptions;
            return View(await viewModel.OrderBy(queryOptions.Sort).ToListAsync());
        }
    }
}