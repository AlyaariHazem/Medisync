﻿// <auto-generated />
using MedisyncAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedisyncAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250125135543_AddUsers")]
    partial class AddUsers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MedisyncAPI.models.Interaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cons")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InteractionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Medication1Id")
                        .HasColumnType("int");

                    b.Property<int>("Medication2Id")
                        .HasColumnType("int");

                    b.Property<string>("Pros")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reasoning")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Severity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Medication1Id");

                    b.HasIndex("Medication2Id");

                    b.ToTable("Interactions");
                });

            modelBuilder.Entity("MedisyncAPI.models.Medication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SideEffects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Use")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medications");
                });

            modelBuilder.Entity("MedisyncAPI.models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MedisyncAPI.models.Interaction", b =>
                {
                    b.HasOne("MedisyncAPI.models.Medication", "Medication1")
                        .WithMany("InteractionsAsMed1")
                        .HasForeignKey("Medication1Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MedisyncAPI.models.Medication", "Medication2")
                        .WithMany("InteractionsAsMed2")
                        .HasForeignKey("Medication2Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Medication1");

                    b.Navigation("Medication2");
                });

            modelBuilder.Entity("MedisyncAPI.models.Medication", b =>
                {
                    b.Navigation("InteractionsAsMed1");

                    b.Navigation("InteractionsAsMed2");
                });
#pragma warning restore 612, 618
        }
    }
}
