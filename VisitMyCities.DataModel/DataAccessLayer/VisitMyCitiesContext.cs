using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VisitMyCities.DataModel.BusinessObjects;

namespace VisitMyCities.DataModel.DataAccessLayer
{
    public class VisitMyCitiesContext : IdentityDbContext
    {
        public VisitMyCitiesContext(DbContextOptions<VisitMyCitiesContext> options) : base(options)
        {

        }

        public DbSet<Batiment> Batiments { get; set; }
        public DbSet<DetailArchitectural> DetailsArchi { get; set; }
        public DbSet<Ville> Villes { get; set; }

        public DbSet<ListeDeVoyage> ListesDeVoyage { get; set; }
        public DbSet<BatimentListeDeVoyage> BatimentsListesDeVoyage { get; set; }

        public DbSet<UtilisateurBatiment> UtilisateurBatiment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Batiment>().ToTable("Batiment");
            modelBuilder.Entity<DetailArchitectural>().ToTable("DetailArchitectural");
            modelBuilder.Entity<Ville>().ToTable("Ville");
            modelBuilder.Entity<ListeDeVoyage>().ToTable("ListeDeVoyage");
            modelBuilder.Entity<BatimentListeDeVoyage>().ToTable("BatimentListeDeVoyage");
            modelBuilder.Entity<UtilisateurBatiment>().ToTable("UtilisateurBatiment");

            // Table de liaison BatimentListeDeVoyage
            modelBuilder.Entity<BatimentListeDeVoyage>()
            .HasKey(o => new { o.BatimentId, o.IdListe });

            modelBuilder.Entity<BatimentListeDeVoyage>()
            .HasOne(bl => bl.Batiment)
            .WithMany(b => b.BatimentsListeDeVoyage)
            .HasForeignKey(bl => bl.BatimentId);


            modelBuilder.Entity<BatimentListeDeVoyage>()
                .HasOne(bl => bl.ListeDeVoyage)
                .WithMany(l => l.BatimentsListeDeVoyage)
                .HasForeignKey(bl => bl.IdListe)
                .OnDelete(DeleteBehavior.NoAction);

            // Table de liaison UtilisateurBatiment
            modelBuilder.Entity<UtilisateurBatiment>()
            .HasKey(u => new { u.UtilisateurId, u.BatimentId });

            modelBuilder.Entity<UtilisateurBatiment>()
            .HasOne(u => u.Utilisateur)
            .WithMany(ub => ub.BatimentsEvalues)
            .HasForeignKey(ub => ub.UtilisateurId);


            modelBuilder.Entity<UtilisateurBatiment>()
                .HasOne(b => b.Batiment)
                .WithMany(ub => ub.BatimentsEvalues)
                .HasForeignKey(b => b.BatimentId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
