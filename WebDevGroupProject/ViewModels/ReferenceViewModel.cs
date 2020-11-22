using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.ViewModels
{
    public class ReferenceViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string ReferenceFirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string ReferenceLastName { get; set; }

        [Required]
        [Display(Name = "Applicant Relationship to Reference")]
        public string ReferenceRelationship { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string ReferenceEmailAddress { get; set; }


        [Required]
        [Display(Name = "Phone Number")]
        public string ReferencePhoneNumber { get; set; }
    }
}
