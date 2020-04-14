﻿using System;
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
       
        public DateTime? RequestDate { get; set; }
        public string RequestItem { get; set; }
        
    }
}
