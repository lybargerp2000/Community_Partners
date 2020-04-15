using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPartners.Models
{
    public class RatingHelpfulness
    {
        public int RatingHelpfulnessId { get; set;}
        public double RatingAverage { get; set; }
        public int RatingEntry { get; set; }
        [ForeignKey("RatingEntry")]
        public int RequestServiceId { get; set; }
    }
}
