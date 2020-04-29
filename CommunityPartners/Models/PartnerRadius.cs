using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPartners.Models
{
    public class PartnerRadius
    {
        public int PartnerRadiusId { get; set; }
        public int RadiusMiles { get; set; }
        public int RadiusMeters { get; set; }
        [ForeignKey ("PartnerId")]
        public int PartnerId { get; set; }
    }
}
