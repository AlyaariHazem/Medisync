using Microsoft.EntityFrameworkCore;
using MedisyncAPI.models;
using MedisyncAPI.Data.Seeds;
using Microsoft.AspNetCore.Identity;

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
        public DbSet<User> Users { get; set; }
        public DbSet<Interaction> Interactions { get; set; }

        // Override OnModelCreating if you need to configure relationships or constraints
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data by calling the seed methods
            MedicationSeedData.Seed(modelBuilder);
            InteractionSeedData.Seed(modelBuilder);

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

            // Instantiate PasswordHasher
            var passwordHasher = new PasswordHasher<User>();

            // Seed a default user
            var adminUser = new User
            {
                Id = 1,
                Username = "Admin",
            };
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Adm!n159");

            modelBuilder.Entity<User>().HasData(adminUser);
        }
    }
}
