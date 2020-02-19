using System;
using System.Collections.Generic;
using System.Text;
using DAL.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace DAL.Model
{
    public partial class PinkContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AspNetUserRoles>(entity =>
            //{
            //    entity.HasOne(d => d.aspNetRoles)
            //    .WithMany(p => p.aspNetUserRoles)
            //    .HasForeignKey(d => d.RoleId)
            //    .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");
            //});

            //modelBuilder.Entity<AspNetUserRoles>(entity =>
            //{
            //    entity.HasOne(d => d.aspNetUsers)
            //    .WithMany(p => p.aspNetUserRoles)
            //    .HasForeignKey(d => d.UserId)
            //    .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
            //});

            //modelBuilder.Entity<AspNetUserRoles>().HasKey(a => new { a.UserId, a.RoleId });
        }

        public PinkContext(DbContextOptions options)
            : base(options)
        {

        }

        public PinkContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var appconfig = new AppConfiguration("DefaultConnection");
                optionsBuilder.UseNpgsql("User ID=postgres;Password=P@ssw0rd;Host=localhost;Port=5432;Database=pinktogether;Pooling=true;");
            }
        }
    }
}