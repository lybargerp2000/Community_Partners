using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPartners.Models
{
    public class RequestService
    {
        public int RequestServiceId { get; set; }

        [ForeignKey("PartnerAddress")]
        public int PartnerId { get; set; }
        [ForeignKey("Donateservice")]
        public int DonateServiceId { get; set; }
        [ForeignKey("PayPal")]
        public int PayPalId { get; set; }
       
        public DateTime? RequestDate { get; set; }
        public string RequestItem { get; set; }
        public string GroceryList { get; set; }
        public bool AcceptRequest { get; set; }
        public int RequestDayOfWeek { get; set; }
        public double TransactionAmount { get; set; }
        public int RatingEntry { get; set; }

        
    }
}
