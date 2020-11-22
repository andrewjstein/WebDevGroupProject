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
        public List<Guardian> Guardians { get; set; }
        [Required]
        public List<Sibling> Siblings { get; set; }
        [Required]
        public FamilyRole FamilyRole { get; set; }
    }
}
