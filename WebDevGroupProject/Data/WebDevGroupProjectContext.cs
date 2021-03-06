﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebDevGroupProject.Models;
using WebDevGroupProject.ViewModels;

namespace WebDevGroupProject.Data
{
    public class WebDevGroupProjectContext : DbContext
    {
        public WebDevGroupProjectContext (DbContextOptions<WebDevGroupProjectContext> options)
            : base(options)
        {
        }

        public DbSet<WebDevGroupProject.Models.Application> Application { get; set; }
        public DbSet<WebDevGroupProject.Models.Applicant> Applicant { get; set; }
        public DbSet<WebDevGroupProject.ViewModels.SortedApplicantsReportViewModel> SortedApplicantsReport { get; set; }
        public DbSet<WebDevGroupProject.ViewModels.BillingViewModel> BillingViewModel { get; set; }
        public DbSet<WebDevGroupProject.ViewModels.AcademicRecordReportViewModel> AcademicRecordReportViewModel { get; set; }
    }
}
