using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.ViewModels
{
    public class BillingViewModel
    {
        [Required]
        public int CreditCardNumber { get; set; }
        [Required]
        public string BillingExpiration { get; set; }
        [Required]
        public string BillingCVV { get; set; }
        [Required]
        public string BillingName { get; set; }
        [Required]
        public string BillingAddress { get; set; }
        [Required]
        public string BillingCity { get; set; }
        [Required]
        public string BillingState { get; set; }
        [Required]
        public string BillingZip { get; set; }
        [Required]
        public string Signature { get; set; }
    }
}
