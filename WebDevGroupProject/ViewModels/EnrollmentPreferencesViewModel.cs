using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebDevGroupProject.Models;

namespace WebDevGroupProject.ViewModels
{
    public class EnrollmentPreferencesViewModel
    {
        [Required]
        [Display(Name = "Preferred Major")]
        public string PreferredMajor { get; set; }
        [Display(Name = "Preferred Minor (leave blank if none)")]
        public string PreferredMinor { get; set; }
        [Required]
        [Display(Name = "Commuter or Resident?")] 
        public string CommuterResident { get; set; }
        [Required]
        [Display(Name = "Full time or part time?")]
        public string FullTimePartTime { get; set; }
        [Required]
        [Display(Name = "Interested in honors?")]
        public bool InterestedInHonors { get; set; }
        public StudentType StudentType { get; set; }
        public ResidentialStatus ResidentialStatus { get; set; }
    }
}
