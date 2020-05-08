using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPartners.Models
{
    public class Partner
    {
        public int PartnerId { get; set; }
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int? HomeLocationId { get; set; }
        public string PartnerPhone { get; set; }
        public int ReOccurringDayRequest { get; set; }
        public bool RequestReceiveOrDonate { get; set; }
        public double AmountDonated { get; set; }
        public string Itemdonated { get; set; }
        public double MilesTravelled { get; set; }
        public string PartnerAddress { get; set; }
        public string PartnerCity { get; set; }
        public string PartnerState { get; set; }
        public string PartnerZip { get; set; }
        public string PartnerLong { get; set; }
        public string PartnerLat { get; set; }
        [ForeignKey("PayPal")]
        public int PayPalId { get; set; }
        public double TransactionHistory { get; set; }
        [ForeignKey("RadiusId")]
        public int PartnerRadiusId { get; set; }
        [ForeignKey("RatingId")]
        public int RatingHelpfulnessId { get; set; }
        [NotMapped]
        public GeoResult geoResult { get; set; }

        //public RequestService RequestService { get; set; }
        //public DonateService DonateService { get; set; }

    }
}
