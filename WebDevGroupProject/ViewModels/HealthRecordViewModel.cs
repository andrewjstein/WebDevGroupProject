using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.ViewModels
{
    public class HealthRecordViewModel
    {
        [Required]
        [Display(Name = "Name of Policy Holder")]
        public string PolicyHolder { get; set; }


        [Required]
        [Display(Name = "Name of Provider")]
        public string ProviderName { get; set; }


        [Required]
        [Display(Name = "MemberID")]
        public string MemberID { get; set; }


        [Required]
        [Display(Name = "Policy Group Number")]
        public string PolicyGroupNumber { get; set; }


        [Required]
        [Display(Name = "Front of Insurance Card")]
        public string InsuranceCardFrontPath { get; set; }


        [Required]
        [Display(Name = "Back of Insurance Card")]
        public string InsuranceCardBackPath { get; set; }


        [Required]
        [Display(Name = "Applicant Immunization Record")]
        public string ImmunizationFilePath { get; set; }


        [Required]
        [Display(Name = "Name of Physician")]
        public string PhysicianName { get; set; }


        [Required]
        [Display(Name = "Name of Practice")]
        public string PracticeName { get; set; }


        [Required]
        [Display(Name = "Practice Phone Number")]
        public string PracticePhoneNumber { get; set; }


        [Required]
        [Display(Name = "First Name")]
        public string ContactFirstName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        public string ContactLastName { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string ContactEmailAddress { get; set; }


        [Required]
        [Display(Name = "Phone Number")]
        public string ContactPhoneNumber { get; set; }


        [Required]
        [Display(Name = "Applicant Relationship to Emergency Contact")]
        public string ContactRelationship { get; set; }

    }
}
