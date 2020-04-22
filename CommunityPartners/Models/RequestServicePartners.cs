using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPartners.Models
{
    public class RequestServicePartners
    {
        public int RequestServicePartnersId { get; set; }
        [ForeignKey("PartnerInfo")]
        public int PartnerId { get; set; }
        [ForeignKey("RequestServiceId")]
        public int RequestServiceId { get; set; }
        public DateTime ProposalDate { get; set; }
        public bool Accepted { get; set; }
        [ForeignKey("RatingInfo")]
        public int RatingHelpfulnessId { get; set; }
        [ForeignKey("PayPalInfo")]
        public int PayPalId { get; set; }
    }
}
