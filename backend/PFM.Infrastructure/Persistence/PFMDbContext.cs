using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.EntityFrameworkCore;
using PFM.Domain.Entities;

namespace PFM.Infrastructure.Persistence
{
    public class PFMDbContext:DbContext
    {
        public PFMDbContext(DbContextOptions<PFMDbContext> options):base(options) {}

        public DbSet<Transactions> Transactions { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<TransactionSplit> TransactionSplit { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transactions>().HasKey(t => t.Id);

            modelBuilder.Entity<Category>().HasKey(c => c.Code);

            modelBuilder.Entity<TransactionSplit>().HasKey(ts => ts.Id);

            modelBuilder.Entity<Transactions>()
               .Property(t => t.Direction)
               .HasConversion<string>();

            modelBuilder.Entity<Transactions>()
                .Property(t => t.Kind)
                .HasConversion<string>();

            modelBuilder.Entity<Transactions>()
                .Property(t => t.Date)
                .HasColumnType("date");

            modelBuilder.Entity<Transactions>()
                .HasOne(t => t.Category)
                .WithMany(c => c.Transactions)                     
                .HasForeignKey(t => t.CatCode)
                .HasPrincipalKey(c => c.Code)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Category>()
                .HasOne(c => c.ParentCategory)
                .WithMany()
                .HasForeignKey(c => c.ParentCode)
                .HasPrincipalKey(c => c.Code)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TransactionSplit>()
                .HasOne(ts => ts.Transaction)
                .WithMany(t => t.Splits)
                .HasForeignKey(ts => ts.TransactionId)
                .HasPrincipalKey(t => t.Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TransactionSplit>()
                .HasOne(ts => ts.Category)
                .WithMany()
                .HasForeignKey(ts => ts.CatCode)
                .HasPrincipalKey(c => c.Code)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
