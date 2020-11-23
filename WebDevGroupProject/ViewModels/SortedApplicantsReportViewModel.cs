using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.ViewModels
{
    public class SortedApplicantsReportViewModel
    {
        [Key]
        public int ApplicantID { get; set; }
        public string ApplicantFirstName { get; set; }
        public string ApplicantLastName { get; set; }
        public double GPA { get; set; }
    }
}
