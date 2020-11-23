using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.Models
{
    public class PastUniversity
    {
        public int PastUniversityID { get; set; }

        public string PastUniversityName { get; set; }

        public string PastUniversityTranscriptPath { get; set; }
    }
}
