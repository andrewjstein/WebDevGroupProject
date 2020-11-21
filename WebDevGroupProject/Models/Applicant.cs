using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.Models
{
    public class Applicant
    {
        public int ApplicantID { get; set; }

        public string ApplicantFirstName { get; set; }

        public string ApplicantLastName { get; set; }

        public string ApplicantMiddleInitial { get; set; }

        public string ApplicantCountry { get; set; }

        public string ApplicantStreetAddress { get; set; }

        public string ApplicantCity { get; set; }

        public string ApplicantZip { get; set; }

        public string ApplicantPhone { get; set; }

        public string ApplicantEmail { get; set; }

        public DateTime ApplicantBirthDate { get; set; }

        public string ApplicantPrimaryCitizenship { get; set; }

        public EthnicOrigin EthnicOrigin { get; set; }
    }
}
