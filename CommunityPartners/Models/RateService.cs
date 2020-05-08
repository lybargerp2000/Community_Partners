using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPartners.Models
{
    public class RateService
    {
        public int RateServiceId { get; set; }
        [ForeignKey("DonateServiceId)")]
        public int DonateServiceId { get; set; }
        public DateTime Date { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        [ForeignKey("PartnerId")]
        public int PartnerId { get; set; }
        [NotMapped]
        public int RatingSelect { get; set; }

    }
}
