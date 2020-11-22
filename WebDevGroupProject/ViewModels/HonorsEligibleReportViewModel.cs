using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.ViewModels
{
    public class HonorsEligibleReportViewModel
    {
        public int ApplicantID { get; set; }
        public int GPA { get; set; }
        public int SAT { get; set; }
        public int ACT { get; set; }
        public string ApplicantFirstName { get; set; }

        public string ApplicantLastName { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantPhone { get; set; }
        public bool InterestedInHonors { get; set; }
    }
}
