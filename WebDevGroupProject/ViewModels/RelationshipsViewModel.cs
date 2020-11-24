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
        public string Guardians { get; set; }
        [Required]
        public string Siblings { get; set; }
        public FamilyRole FamilyRoleID { get; set; }
        [Required]
        public SelectList FamilyRole { get; set; }
    }
}
