using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebDevGroupProject.Models;

namespace WebDevGroupProject.ViewModels
{
    public class AcademicRecord
    {
        // Academic Record
        [Required]
        [Display(Name = "Name of High School")]
        public string HighSchoolName { get; set; }
        [Required]
        [Display(Name = "CEEB Code")]
        public int CEEBCode { get; set; }
        [Required]
        [Display(Name = "GPA")]
        public int GPA { get; set; }
        [Display(Name = "SAT")]
        public int SAT { get; set; }
        [Display(Name = "ACT")]
        public int ACT { get; set; }
        [Required]
        [Display(Name = "High School Transcript")]
        public string HighSchoolTranscriptPath { get; set; }
        [Display(Name = "Past Universities")]
        public List<PastUniversity> PastUniversities { get; set; }

    }
}
