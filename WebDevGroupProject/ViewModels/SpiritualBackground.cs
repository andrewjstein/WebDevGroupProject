using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.ViewModels
{
    public class SpiritualBackground
    {
        // Spiritual Background 
        [Required]
        [Display(Name = "Church Name")]
        public string ChurchName { get; set; }
        [Required]
        [Display(Name = "Church Address")]
        public string ChurchAddress { get; set; }
        [Required]
        [Display(Name = "Church City")]
        public string ChurchCity { get; set; }
        [Required]
        [Display(Name = "Church State")]
        public string ChurchState { get; set; }
        [Required]
        [Display(Name = "Church Zip")]
        public string ChurchZip { get; set; }
        [Required]
        [Display(Name = "Pastor Name")]
        public string PastorName { get; set; }
        [Required]
        [Display(Name = "Pastor Email")]
        public string PastorEmail { get; set; }
        [Required]
        [Display(Name = "Profession of Faith")]
        public bool ProfessionOfFaith { get; set; }
        [Required]
        [Display(Name = "Spiritual Journey")]
        public string SpiritualJourney { get; set; }

    }
}
