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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Batiment>().ToTable("Batiment");
            modelBuilder.Entity<DetailArchitectural>().ToTable("DetailArchitectural");
            modelBuilder.Entity<Ville>().ToTable("Ville");
        }
    }
}
