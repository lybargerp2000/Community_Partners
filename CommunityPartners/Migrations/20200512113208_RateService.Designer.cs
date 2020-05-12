﻿// <auto-generated />
using System;
using CommunityPartners.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CommunityPartners.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200512113208_RateService")]
    partial class RateService
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CommunityPartners.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartnerId")
                        .HasColumnType("int");

                    b.HasKey("AdminId");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("CommunityPartners.Models.DonateService", b =>
                {
                    b.Property<int>("DonateServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DonationRadiusMiles")
                        .HasColumnType("int");

                    b.Property<int>("PartnerId")
                        .HasColumnType("int");

                    b.Property<int>("Zipcode")
                        .HasColumnType("int");

                    b.HasKey("DonateServiceId");

                    b.ToTable("DonateServices");
                });

            modelBuilder.Entity("CommunityPartners.Models.DonateServicePartners", b =>
                {
                    b.Property<int>("DonateServicePartnersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Accepted")
                        .HasColumnType("bit");

                    b.Property<int>("DonateServiceId")
                        .HasColumnType("int");

                    b.Property<int>("PartnerId")
                        .HasColumnType("int");

                    b.Property<int>("PayPalId")
                        .HasColumnType("int");

                    b.Property<int>("RatingHelpfulnessId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DonateServicePartnersId");

                    b.ToTable("DonateServicePartnersers");
                });

            modelBuilder.Entity("CommunityPartners.Models.Partner", b =>
                {
                    b.Property<int>("PartnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AmountDonated")
                        .HasColumnType("float");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HomeLocationId")
                        .HasColumnType("int");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Itemdonated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MilesTravelled")
                        .HasColumnType("float");

                    b.Property<string>("PartnerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerLat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerLong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartnerRadiusId")
                        .HasColumnType("int");

                    b.Property<string>("PartnerState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerZip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PayPalId")
                        .HasColumnType("int");

                    b.Property<int>("RatingHelpfulnessId")
                        .HasColumnType("int");

                    b.Property<int>("ReOccurringDayRequest")
                        .HasColumnType("int");

                    b.Property<bool>("RequestReceiveOrDonate")
                        .HasColumnType("bit");

                    b.Property<double>("TransactionHistory")
                        .HasColumnType("float");

                    b.HasKey("PartnerId");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("CommunityPartners.Models.PartnerRadius", b =>
                {
                    b.Property<int>("PartnerRadiusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PartnerId")
                        .HasColumnType("int");

                    b.Property<int>("RadiusMeters")
                        .HasColumnType("int");

                    b.Property<int>("RadiusMiles")
                        .HasColumnType("int");

                    b.HasKey("PartnerRadiusId");

                    b.ToTable("partnerRadii");

                    b.HasData(
                        new
                        {
                            PartnerRadiusId = 1,
                            PartnerId = 0,
                            RadiusMeters = 1600,
                            RadiusMiles = 1
                        },
                        new
                        {
                            PartnerRadiusId = 2,
                            PartnerId = 0,
                            RadiusMeters = 8000,
                            RadiusMiles = 5
                        },
                        new
                        {
                            PartnerRadiusId = 3,
                            PartnerId = 0,
                            RadiusMeters = 16000,
                            RadiusMiles = 10
                        },
                        new
                        {
                            PartnerRadiusId = 4,
                            PartnerId = 0,
                            RadiusMeters = 50000,
                            RadiusMiles = 30
                        });
                });

            modelBuilder.Entity("CommunityPartners.Models.PayPal", b =>
                {
                    b.Property<int>("PayPalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DonateServiceId")
                        .HasColumnType("int");

                    b.Property<int>("RequestServiceId")
                        .HasColumnType("int");

                    b.Property<double>("TransactionAmount")
                        .HasColumnType("float");

                    b.Property<double>("TransactionHistory")
                        .HasColumnType("float");

                    b.HasKey("PayPalId");

                    b.ToTable("PayPals");
                });

            modelBuilder.Entity("CommunityPartners.Models.RateService", b =>
                {
                    b.Property<int>("RateServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DonateServiceId")
                        .HasColumnType("int");

                    b.Property<int>("PartnerId")
                        .HasColumnType("int");

                    b.Property<string>("PartnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ServiceDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RateServiceId");

                    b.ToTable("RateServices");

                    b.HasData(
                        new
                        {
                            RateServiceId = 1,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DonateServiceId = 0,
                            PartnerId = 0,
                            Rating = 1
                        },
                        new
                        {
                            RateServiceId = 2,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DonateServiceId = 0,
                            PartnerId = 0,
                            Rating = 2
                        },
                        new
                        {
                            RateServiceId = 3,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DonateServiceId = 0,
                            PartnerId = 0,
                            Rating = 3
                        },
                        new
                        {
                            RateServiceId = 4,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DonateServiceId = 0,
                            PartnerId = 0,
                            Rating = 4
                        },
                        new
                        {
                            RateServiceId = 5,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DonateServiceId = 0,
                            PartnerId = 0,
                            Rating = 5
                        },
                        new
                        {
                            RateServiceId = 6,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DonateServiceId = 0,
                            PartnerId = 0,
                            Rating = 6
                        },
                        new
                        {
                            RateServiceId = 7,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DonateServiceId = 0,
                            PartnerId = 0,
                            Rating = 7
                        },
                        new
                        {
                            RateServiceId = 8,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DonateServiceId = 0,
                            PartnerId = 0,
                            Rating = 8
                        },
                        new
                        {
                            RateServiceId = 9,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DonateServiceId = 0,
                            PartnerId = 0,
                            Rating = 9
                        },
                        new
                        {
                            RateServiceId = 10,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DonateServiceId = 0,
                            PartnerId = 0,
                            Rating = 10
                        });
                });

            modelBuilder.Entity("CommunityPartners.Models.RatingHelpfulness", b =>
                {
                    b.Property<int>("RatingHelpfulnessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("RatingAverage")
                        .HasColumnType("float");

                    b.Property<int>("RatingEntry")
                        .HasColumnType("int");

                    b.Property<int>("RequestServiceId")
                        .HasColumnType("int");

                    b.HasKey("RatingHelpfulnessId");

                    b.ToTable("RatingHelpfulnesses");
                });

            modelBuilder.Entity("CommunityPartners.Models.RequestService", b =>
                {
                    b.Property<int>("RequestServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AcceptRequest")
                        .HasColumnType("bit");

                    b.Property<string>("GroceryList")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartnerId")
                        .HasColumnType("int");

                    b.Property<int>("PayPalId")
                        .HasColumnType("int");

                    b.Property<int>("RatingEntry")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RequestDayOfWeek")
                        .HasColumnType("int");

                    b.Property<string>("RequestItem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TransactionAmount")
                        .HasColumnType("float");

                    b.HasKey("RequestServiceId");

                    b.ToTable("RequestServices");
                });

            modelBuilder.Entity("CommunityPartners.Models.RequestServicePartners", b =>
                {
                    b.Property<int>("RequestServicePartnersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Accepted")
                        .HasColumnType("bit");

                    b.Property<int>("PartnerId")
                        .HasColumnType("int");

                    b.Property<int>("PayPalId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ProposalDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RatingHelpfulnessId")
                        .HasColumnType("int");

                    b.Property<int>("RequestServiceId")
                        .HasColumnType("int");

                    b.HasKey("RequestServicePartnersId");

                    b.ToTable("RequestServicePartnersers");
                });

            modelBuilder.Entity("CommunityPartners.Models.Result", b =>
                {
                    b.Property<int>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RateServiceId")
                        .HasColumnType("int");

                    b.Property<int>("ratingSelect")
                        .HasColumnType("int");

                    b.HasKey("ResultId");

                    b.HasIndex("RateServiceId");

                    b.ToTable("Result");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "957283d6-a807-42bd-a530-ca7b67c8b8c4",
                            ConcurrencyStamp = "8e851581-2d88-4309-8d6a-306a61c2068f",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "90db573f-d3ef-43e1-84b5-e4f7aab91dcb",
                            ConcurrencyStamp = "9c9f835d-5122-40e1-9241-d6e178410652",
                            Name = "Partner",
                            NormalizedName = "PARTNER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CommunityPartners.Models.Admin", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });

            modelBuilder.Entity("CommunityPartners.Models.Partner", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });

            modelBuilder.Entity("CommunityPartners.Models.Result", b =>
                {
                    b.HasOne("CommunityPartners.Models.RateService", null)
                        .WithMany("results")
                        .HasForeignKey("RateServiceId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
