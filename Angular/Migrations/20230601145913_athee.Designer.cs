﻿// <auto-generated />
using System;
using Angular.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Angular.Migrations
{
    [DbContext(typeof(WorkoutContext))]
    [Migration("20230601145913_athee")]
    partial class athee
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Angular.Model.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("AdminName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Angular.Model.Exercise", b =>
                {
                    b.Property<int>("Eid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Eid"));

                    b.Property<string>("Diet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipmentRequired")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeFrame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wid")
                        .HasColumnType("int");

                    b.Property<int?>("WkRep")
                        .HasColumnType("int");

                    b.Property<int?>("WkSet")
                        .HasColumnType("int");

                    b.HasKey("Eid");

                    b.HasIndex("Wid");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("Angular.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Angular.Model.Workout", b =>
                {
                    b.Property<int>("Wid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Wid"));

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Intensity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Maingoal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trainer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Wdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Wname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Wid");

                    b.ToTable("Workout");
                });

            modelBuilder.Entity("Angular.Model.Exercise", b =>
                {
                    b.HasOne("Angular.Model.Workout", "Workout")
                        .WithMany("Exercise")
                        .HasForeignKey("Wid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("Angular.Model.Workout", b =>
                {
                    b.Navigation("Exercise");
                });
#pragma warning restore 612, 618
        }
    }
}
