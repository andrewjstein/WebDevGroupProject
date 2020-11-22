using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.ViewModels
{
    public class ReferenceReportViewModel
    {
        public int ApplicantID { get; set; }

        public string ApplicantFirstName { get; set; }

        public string ApplicantLastName { get; set; }

        public string ReferenceFirstName { get; set; }
        public string ReferenceLastName { get; set; }
        public string ReferenceRelationship { get; set; }
        public string ReferenceEmailAddress { get; set; }
        public string ReferencePhoneNumber { get; set; }
    }
}
