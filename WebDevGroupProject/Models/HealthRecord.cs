using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.Models
{
    public class HealthRecord
    {
        // test
        // Physician
        public int PhysicianID { get; set; }

        public string PhysicianName { get; set; }

        public string PracticeName { get; set; }

        public string PhysicianPhoneNumber { get; set; }


        // Insurance

        public int InsuranceID { get; set; }

        public string PolicyHolder { get; set; }

        public string ProviderName { get; set; }

        public string MemberID { get; set; }

        public string PolicyGroupNumber { get; set; }


        // Insurance Card
        public int CardID { get; set; }

        public string CardFrontPath { get; set; }

        public string CardBackPath { get; set; }


        // Emergency Contact 
        public int ContactID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string ContactPhoneNumber { get; set; }

        public string Relationship { get; set; }


        // Immunization Record
        public int ImmunizationID { get; set; }
        public string ImmunizationRecordPath { get; set; }

    }
}
