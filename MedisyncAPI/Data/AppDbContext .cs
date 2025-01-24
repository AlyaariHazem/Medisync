using Microsoft.EntityFrameworkCore;
using MedisyncAPI.models;

namespace MedisyncAPI.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor accepting DbContextOptions
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSet for Medications
        public DbSet<Medication> Medications { get; set; }

        // DbSet for Interactions
        public DbSet<Interaction> Interactions { get; set; }

        // Override OnModelCreating if you need to configure relationships or constraints
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Interaction → Medication1
            modelBuilder.Entity<Interaction>()
                .HasOne(i => i.Medication1)
                .WithMany(m => m.InteractionsAsMed1)
                .HasForeignKey(i => i.Medication1Id)
                .OnDelete(DeleteBehavior.Restrict);

            // Interaction → Medication2
            modelBuilder.Entity<Interaction>()
                .HasOne(i => i.Medication2)
                .WithMany(m => m.InteractionsAsMed2)
                .HasForeignKey(i => i.Medication2Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
