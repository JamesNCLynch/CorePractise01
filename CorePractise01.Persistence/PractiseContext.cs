using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using CorePractise01.Persistence.Entities;
using Microsoft.AspNetCore.Identity;
using System.Data.Entity.ModelConfiguration.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CorePractise01.Persistence
{
    public class PractiseContext : IdentityDbContext<IdentityUser>
    {
        public PractiseContext(DbContextOptions<PractiseContext> options) : base(options)
        {

        }

        public DbSet<Feed> Feeds { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feed>().ToTable("Feed")
                .HasOne(u => u.AspNetUserId);
            //modelBuilder.Entity<Feed>()
            //    .HasOne(u => u.AspNetUserId);

            //modelBuilder.Entity<User>().ToTable("AspNetUsers");
            //modelBuilder.Entity<User>()
            //    .HasMany(f => f.Feeds)
            //    .WithOne()
            //    .HasForeignKey(k => k.AspNetUserId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
