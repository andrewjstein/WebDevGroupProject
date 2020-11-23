using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.ViewModels
{
    public class ScholarshipEligibilityReportViewModel
    {
        public int ApplicantID { get; set; }
        public string ApplicantFirstName { get; set; }
        public string ApplicantLastName { get; set; }
        public string ApplicantMiddleInitial { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantPhone { get; set; }
        public int GPA { get; set; }


    }
}
