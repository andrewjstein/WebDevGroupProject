using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebDevGroupProject.Models;

namespace WebDevGroupProject.ViewModels
{
    public class ApplicantViewModel
    {
        public int ApplicantID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string ApplicantFirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string ApplicantLastName { get; set; }
        [Display(Name = "Middle Initial")]
        public string ApplicantMiddleInitial { get; set; }
        [Required]
        [Display(Name = "Street Address")]
        public string ApplicantStreetAddress { get; set; }
        [Required]
        [Display(Name = "City")]
        public string ApplicantCity { get; set; }
        [Required]
        [Display(Name = "Country")]
        public string ApplicantCountry { get; set; }
        [Required]
        [Display(Name = "ZIP Code")]
        public string ApplicantZip { get; set; }
        [Required]
        [Display(Name = "Phone")]
        [Phone]
        public string ApplicantPhone { get; set; }
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string ApplicantEmail { get; set; }
        [Required]
        [Display(Name = "Birth Date")]
        public DateTime ApplicantBirthDate { get; set; }
        [Required]
        [Display(Name = "Primary Citizensip")]
        public string ApplicantPrimaryCitizenship { get; set; }
        public EthnicOrigin EthnicOriginID { get; set; }
        [Required]
        [Display(Name = "Ethnic Origin")]
        public string EthnicOrigin { get; set; }
        [Required]
        [Display(Name = "Hispanic or Latino?")]
        public bool HispanicLatino { get; set; }
    }
}
