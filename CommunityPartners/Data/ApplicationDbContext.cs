using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommunityPartners.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
             new IdentityRole
             {
                 Name = "Partner",
                 NormalizedName = "PARTNER",
             }
            );
        }
        public DbSet<Models.Partner> Partners { get; set; }
        public DbSet<Models.Admin> Admins { get; set; }
        public DbSet<Models.DonateService> DonateServices { get; set; }
        public DbSet<Models.PayPal> PayPals { get; set; }
        public DbSet<Models.RatingHelpfulness> RatingHelpfulnesses { get; set; }
        public DbSet<Models.RequestService> RequestServices { get; set; }
        public DbSet<Models.DonateServicePartners> DonateServicePartnersers { get; set; }
        public DbSet<Models.RequestServicePartners> RequestServicePartnersers { get; set; }
    }
}
