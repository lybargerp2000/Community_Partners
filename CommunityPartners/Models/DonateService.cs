using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPartners.Models
{
    public class DonateService
    {
        public int DonateServiceId { get; set; }
        [ForeignKey("RequestserviceInfo")]
        public int RequestServiceId { get; set; }
        [ForeignKey("AcceptOffer")]
        public string RequestItem { get; set; }
        [ForeignKey("PartnerId)")]
        public int PartnerId { get; set; }
        public DateTime Date { get; set; }
        public int RatingHelpfullness { get; set; }
        public int Radius { get; set; }
        [ForeignKey("DonateRadiusId")]
        public int DonateRadiusId { get; set; }
        
        public double TransactionAmount { get; set; }
    }
}
