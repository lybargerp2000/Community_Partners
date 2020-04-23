﻿using System;
using System.Collections.Generic;
using System.Text;
using CommunityPartners.Models;
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
            builder.Entity<PartnerRadius>()
                .HasData(
                    new PartnerRadius { PartnerRadiusId = 1, RadiusMiles = 1, RadiusMeters = 1600 },
                    new PartnerRadius { PartnerRadiusId = 2, RadiusMiles = 5, RadiusMeters = 8000 },
                    new PartnerRadius { PartnerRadiusId = 3, RadiusMiles = 10, RadiusMeters = 16000 },
                    new PartnerRadius { PartnerRadiusId = 4, RadiusMiles = 30, RadiusMeters = 50000 }
                );
        }
        public DbSet<Models.PartnerRadius> partnerRadii { get; set; }
        public DbSet<Models.Partner> Partners { get; set; }
        public DbSet<Models.Admin> Admins { get; set; }
        public DbSet<Models.DonateService> DonateServices { get; set; }
        public DbSet<Models.PayPal> PayPals { get; set; }
        public DbSet<Models.RatingHelpfulness> RatingHelpfulnesses { get; set; }
        public DbSet<Models.RequestService> RequestServices { get; set; }
        public DbSet<Models.DonateServicePartners> DonateServicePartnersers { get; set; }
        public DbSet<Models.RequestServicePartners> RequestServicePartnersers { get; set; }
        //public DbSet<Models.GeoLocation> GeoLocationss { get; set; }
        //public DbSet<Models.GeoGeometry> GeoGeometries { get; set; }
        //public DbSet<Models.GeoLocation_Location> GeoLocations { get; set; }
        //public DbSet<Models.GeoNortheast> GeoNortheasts { get; set; }
        //public DbSet<Models.GeoSouthwest> GeoSouthwests { get; set; }
        //public DbSet<Models.GeoPlus_Code> GeoPlus_Codes { get; set; }
        //public DbSet<Models.GeoViewport> GeoViewports { get; set; }

        //public DbSet<Models.GeoResult> GeoResults { get; set; }
    }
}
