using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.Models
{
    public class Sibling
    {
        public int SiblingID { get; set; }

        public string SiblingFirstName { get; set; }

        public string SiblingLastName { get; set; }

        public string SiblingAge { get; set; }
    }
}
