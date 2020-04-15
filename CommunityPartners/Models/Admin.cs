using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityPartners.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [ForeignKey("PartnerId")]
        public int PartnerId { get; set; }
        [NotMapped]
        public IEnumerable<Partner> AmountDonated { get; set; }
        [NotMapped]
        public IEnumerable<Partner> MilesTravelled { get; set; }
    }
}
