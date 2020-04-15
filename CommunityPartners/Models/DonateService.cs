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
        public int RadiusMiles {get; set;}
        public int Zipcode { get; set; }
    }
}
