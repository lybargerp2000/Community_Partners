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

        [ForeignKey("PartnerId)")]
        public int PartnerId { get; set; }
        public DateTime Date { get; set; }
        public int DonationRadiusMiles {get; set;}
        public int Zipcode { get; set; }
        public string Description { get; set; }
    }
}
