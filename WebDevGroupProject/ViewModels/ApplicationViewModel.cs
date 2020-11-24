using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.ViewModels
{
    public class ApplicationViewModel
    {
        public int ApplicationID { get; set; }
        public DateTime ApplicationDate { get; set; }

        public AcademicRecordViewModel AcademicRecord { get; set; }

        public ApplicantViewModel Applicant { get; set; }

        public BillingViewModel Billing { get; set; }

        public EnrollmentPreferencesViewModel EnrollmentPreferences { get; set; }

        public HealthRecordViewModel HealthRecord { get; set; }

        public ReferenceViewModel Reference { get; set; }

        public RelationshipsViewModel Relationship { get; set; }

        public SpiritualBackgroundViewModel SpiritualBackground { get; set; }


        public ApplicationViewModel()
        {
            AcademicRecord = new AcademicRecordViewModel();
            Applicant = new ApplicantViewModel();
            Billing = new BillingViewModel();
            EnrollmentPreferences = new EnrollmentPreferencesViewModel();
            HealthRecord = new HealthRecordViewModel();
            Reference = new ReferenceViewModel();
            Relationship = new RelationshipsViewModel();
            SpiritualBackground = new SpiritualBackgroundViewModel(); 
            
        }
    }
}
