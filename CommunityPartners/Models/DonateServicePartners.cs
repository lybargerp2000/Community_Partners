using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPartners.Models
{
    public class DonateServicePartners
    {
        public int DonateServicePartnersId { get; set; }
        [ForeignKey("PartnerId")] 
        public int PartnerId { get; set; }
        public DateTime RequestDate { get; set; }
        public bool Accepted { get; set; }
        [ForeignKey("PayPal")]
        public int PayPalId { get; set; }
        [ForeignKey("RatingHelpfulness")]
        public int RatingHelpfulnessId { get; set; }
    }
}
