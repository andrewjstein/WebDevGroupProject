using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.Models
{
    public class Application
    {
        public int ApplicationID { get; set; }
        public DateTime ApplicationDate { get; set; }

        // Personal Information 
        public Applicant Applicant { get; set; }

        // Academic Record
        public string HighSchoolName { get; set; }
        public int CEEBCode { get; set; }
        public int GPA { get; set; }
        public int SAT { get; set; }
        public int ACT { get; set; }
        public string HighSchoolTranscriptPath { get; set; }
        public List<PastUniversity> PastUniversities { get; set; }

        // Enrollment Preferences 
        public string PreferredMajor { get; set; }
        public string PreferredMinor { get; set; }
        public string CommuterResident { get; set; }
        public string FullTimePartTime { get; set; }
        public bool InterestedInHonors { get; set; }
        public StudentType StudentType { get; set; }
        public ResidentialStatus ResidentialStatus { get; set; }

        // Relationships 
        public List<Guardian> Guardians { get; set; }
        public List<Sibling> Siblings { get; set; }
        public FamilyRole FamilyRole { get; set; }

        // Spiritual Background 
        public string ChurchName { get; set; }
        public string ChurchAddress { get; set; }
        public string ChurchCity { get; set; }
        public string ChurchState { get; set; }
        public string ChurchZip { get; set; }
        public string PastorName { get; set; }
        public string PastorEmail { get; set; }
        public bool ProfessionOfFaith { get; set; }
        public string SpiritualJourney { get; set; }

        // Health Record 
        public string PolicyHolder { get; set; }
        public string ProviderName { get; set; }
        public string MemberID { get; set; }
        public string PolicyGroupNumber { get; set; }
        public string InsuranceCardFrontPath { get; set; }
        public string InsuranceCardBackPath { get; set; }
        public string ImmunizationFilePath { get; set; }
        public string PhysicianName { get; set; }
        public string PracticePhoneNumber { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactRelationship { get; set; }

        // Reference
        public string ReferenceFirstName { get; set; }
        public string ReferenceLastName { get; set; }
        public string ReferenceRelationship { get; set; }
        public string ReferenceEmailAddress { get; set; }
        public string ReferencePhoneNumber { get; set; }

        // Billing
        public int CreditCardNumber { get; set; }
        public string BillingExpiration { get; set; }
        public string BillingCVV { get; set; }
        public string BillingName { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZip { get; set; }
        public string Signature { get; set; }



    }
}
