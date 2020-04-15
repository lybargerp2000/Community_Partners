using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPartners.Models
{
    public class PayPal
    {
        public int PayPalId { get; set; }
        [ForeignKey("RequestService")]
        public int RequestServiceId { get; set; }
        [ForeignKey("DonateService")]
        public int DonateServiceId { get; set; }
        public double TransactionHistory { get; set; }
        public double TransactionAmount { get; set; }
    }
}
