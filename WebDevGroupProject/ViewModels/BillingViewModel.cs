using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevGroupProject.ViewModels
{
    public class BillingViewModel
    {
        [Key]
        [Required]
        [CreditCard]
        [Display(Name = "Credit Card Number")]
        public int CreditCardNumber { get; set; }
        [Required]
        [Display(Name = "Expiration Date")]
        public string BillingExpiration { get; set; }
        [Required]
        [MaxLength(4)]
        [Display(Name = "CVV Number")]
        public string BillingCVV { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string BillingName { get; set; }
        [Required]
        [Display(Name = "Billing Address")]
        public string BillingAddress { get; set; }
        [Required]
        [Display(Name = "City")]
        public string BillingCity { get; set; }
        [StringLength(2)]
        [Required]
        [Display(Name = "State")]
        public string BillingState { get; set; }
        [Required]
        [Display(Name = "Zipcode")]
        public string BillingZip { get; set; }
        [Required]
        [Display(Name = "Signature")]
        public string Signature { get; set; }
    }
}
