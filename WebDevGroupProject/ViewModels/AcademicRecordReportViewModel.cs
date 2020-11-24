﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.ViewModels
{
    public class AcademicRecordReportViewModel
    {

        [Key]
        public int AcademicRecordId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double GPA { get; set; }
        public double SAT { get; set; }
        public double ACT { get; set; }

    }
}
