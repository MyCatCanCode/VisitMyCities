﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisitMyCities.DataModel.DataAccessLayer;

namespace VisitMyCities.DataModel.Migrations
{
    [DbContext(typeof(VisitMyCitiesContext))]
    [Migration("20210208153758_Tags")]
    partial class Tags
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.Batiment", b =>
                {
                    b.Property<int>("BatimentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateConstruction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionBatiment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<bool?>("MonumentHistorique")
                        .HasColumnType("bit");

                    b.Property<string>("NomBatiment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeBatiment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URLPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VilleId")
                        .HasColumnType("int");

                    b.HasKey("BatimentId");

                    b.HasIndex("VilleId");

                    b.ToTable("Batiment");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.BatimentCategorie", b =>
                {
                    b.Property<int>("BatimentId")
                        .HasColumnType("int");

                    b.Property<int>("CategorieId")
                        .HasColumnType("int");

                    b.HasKey("BatimentId", "CategorieId");

                    b.HasIndex("CategorieId");

                    b.ToTable("BatimentCategorie");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.BatimentListeDeVoyage", b =>
                {
                    b.Property<int>("BatimentId")
                        .HasColumnType("int");

                    b.Property<int>("IdListe")
                        .HasColumnType("int");

                    b.HasKey("BatimentId", "IdListe");

                    b.HasIndex("IdListe");

                    b.ToTable("BatimentListeDeVoyage");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.Categorie", b =>
                {
                    b.Property<int>("CategorieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NomCategorie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategorieId");

                    b.ToTable("Categorie");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.DetailArchitectural", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BatimentId")
                        .HasColumnType("int");

                    b.Property<string>("DescriptionDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomDetail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DetailId");

                    b.HasIndex("BatimentId");

                    b.ToTable("DetailArchitectural");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.ListeDeVoyage", b =>
                {
                    b.Property<int>("IdListe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DescriptionListe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitreListe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URLBlason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UtilisateurId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("VilleId")
                        .HasColumnType("int");

                    b.HasKey("IdListe");

                    b.HasIndex("UtilisateurId");

                    b.HasIndex("VilleId");

                    b.ToTable("ListeDeVoyage");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.UtilisateurBatiment", b =>
                {
                    b.Property<string>("UtilisateurId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BatimentId")
                        .HasColumnType("int");

                    b.Property<string>("Commentaire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NombreEtoiles")
                        .HasColumnType("int");

                    b.HasKey("UtilisateurId", "BatimentId");

                    b.HasIndex("BatimentId");

                    b.ToTable("UtilisateurBatiment");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.UtilisateurVille", b =>
                {
                    b.Property<string>("UtilisateurId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("VilleId")
                        .HasColumnType("int");

                    b.Property<string>("Commentaire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NombreEtoiles")
                        .HasColumnType("int");

                    b.HasKey("UtilisateurId", "VilleId");

                    b.HasIndex("VilleId");

                    b.ToTable("UtilisateurVille");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.Ville", b =>
                {
                    b.Property<int>("VilleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Blason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionVille")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LatitudeVille")
                        .HasColumnType("float");

                    b.Property<double>("LongitudeVille")
                        .HasColumnType("float");

                    b.Property<string>("NomDepartement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomMaire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomRegion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomVille")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumDepartement")
                        .HasColumnType("int");

                    b.Property<string>("URLPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VilleId");

                    b.ToTable("Ville");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.Utilisateur", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("NomUtilisateur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrenomUtilisateur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SeSouvenir")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Utilisateur");
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

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.Batiment", b =>
                {
                    b.HasOne("VisitMyCities.DataModel.BusinessObjects.Ville", "Ville")
                        .WithMany("Batiments")
                        .HasForeignKey("VilleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ville");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.BatimentCategorie", b =>
                {
                    b.HasOne("VisitMyCities.DataModel.BusinessObjects.Batiment", "Batiment")
                        .WithMany("BatimentsCategories")
                        .HasForeignKey("BatimentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisitMyCities.DataModel.BusinessObjects.Categorie", "Categorie")
                        .WithMany("BatimentsCategories")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Batiment");

                    b.Navigation("Categorie");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.BatimentListeDeVoyage", b =>
                {
                    b.HasOne("VisitMyCities.DataModel.BusinessObjects.Batiment", "Batiment")
                        .WithMany("BatimentsListeDeVoyage")
                        .HasForeignKey("BatimentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisitMyCities.DataModel.BusinessObjects.ListeDeVoyage", "ListeDeVoyage")
                        .WithMany("BatimentsListeDeVoyage")
                        .HasForeignKey("IdListe")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Batiment");

                    b.Navigation("ListeDeVoyage");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.DetailArchitectural", b =>
                {
                    b.HasOne("VisitMyCities.DataModel.BusinessObjects.Batiment", "Batiment")
                        .WithMany("Details")
                        .HasForeignKey("BatimentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Batiment");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.ListeDeVoyage", b =>
                {
                    b.HasOne("VisitMyCities.DataModel.BusinessObjects.Utilisateur", "Utilisateur")
                        .WithMany("ListesDeVoyage")
                        .HasForeignKey("UtilisateurId");

                    b.HasOne("VisitMyCities.DataModel.BusinessObjects.Ville", "Ville")
                        .WithMany()
                        .HasForeignKey("VilleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Utilisateur");

                    b.Navigation("Ville");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.UtilisateurBatiment", b =>
                {
                    b.HasOne("VisitMyCities.DataModel.BusinessObjects.Batiment", "Batiment")
                        .WithMany("BatimentsEvalues")
                        .HasForeignKey("BatimentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("VisitMyCities.DataModel.BusinessObjects.Utilisateur", "Utilisateur")
                        .WithMany("BatimentsEvalues")
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Batiment");

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.UtilisateurVille", b =>
                {
                    b.HasOne("VisitMyCities.DataModel.BusinessObjects.Utilisateur", "Utilisateur")
                        .WithMany("VillesEvaluees")
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisitMyCities.DataModel.BusinessObjects.Ville", "Ville")
                        .WithMany("VillesEvaluees")
                        .HasForeignKey("VilleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Utilisateur");

                    b.Navigation("Ville");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.Batiment", b =>
                {
                    b.Navigation("BatimentsCategories");

                    b.Navigation("BatimentsEvalues");

                    b.Navigation("BatimentsListeDeVoyage");

                    b.Navigation("Details");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.Categorie", b =>
                {
                    b.Navigation("BatimentsCategories");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.ListeDeVoyage", b =>
                {
                    b.Navigation("BatimentsListeDeVoyage");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.Ville", b =>
                {
                    b.Navigation("Batiments");

                    b.Navigation("VillesEvaluees");
                });

            modelBuilder.Entity("VisitMyCities.DataModel.BusinessObjects.Utilisateur", b =>
                {
                    b.Navigation("BatimentsEvalues");

                    b.Navigation("ListesDeVoyage");

                    b.Navigation("VillesEvaluees");
                });
#pragma warning restore 612, 618
        }
    }
}
