using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebDevGroupProject.Models;

namespace WebDevGroupProject.ViewModels
{
    public class RelationshipsViewModel
    {
        [Required]
        [Display(Name="Guardian Names(Separated by Comma)")]
        public string Guardians { get; set; }
        [Required]
        [Display(Name = "Sibling Names (Separated by Comma)")]
        public string Siblings { get; set; }
        [Required]
        public string FamilyRole { get; set; }
    }
}
