﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentEmployeeCollection.Models;

namespace StudentEmployeeCollection.Migrations
{
    [DbContext(typeof(StudentEmployeeDbContext))]
    [Migration("20221031042740_move_pay_rate")]
    partial class move_pay_rate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("StudentEmployeeCollection.Models.PayIncrease", b =>
                {
                    b.Property<int>("PayIncreaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PositionID")
                        .HasColumnType("int");

                    b.HasKey("PayIncreaseID");

                    b.HasIndex("PositionID");

                    b.ToTable("PayIncrease");
                });

            modelBuilder.Entity("StudentEmployeeCollection.Models.Position", b =>
                {
                    b.Property<int>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("AuthToWorkMailSentDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("AuthToWorkReceive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("BYUID")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ClassCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("EmplRec")
                        .HasColumnType("int");

                    b.Property<int>("ExpectedHours")
                        .HasColumnType("int");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("PayRate")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("PositionTypeID")
                        .HasColumnType("int");

                    b.Property<string>("QualtricsURL")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SupervisorID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TerminationDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("PositionID");

                    b.HasIndex("BYUID");

                    b.HasIndex("PositionTypeID");

                    b.HasIndex("SupervisorID");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("StudentEmployeeCollection.Models.PositionType", b =>
                {
                    b.Property<int>("PositionTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PositionName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PositionTypeID");

                    b.ToTable("PositionType");

                    b.HasData(
                        new
                        {
                            PositionTypeID = 1,
                            PositionName = "TA"
                        },
                        new
                        {
                            PositionTypeID = 2,
                            PositionName = "RA"
                        },
                        new
                        {
                            PositionTypeID = 3,
                            PositionName = "Office"
                        },
                        new
                        {
                            PositionTypeID = 4,
                            PositionName = "Student Instructor"
                        },
                        new
                        {
                            PositionTypeID = 5,
                            PositionName = "Other"
                        });
                });

            modelBuilder.Entity("StudentEmployeeCollection.Models.Student", b =>
                {
                    b.Property<string>("BYUID")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("BYUName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("International")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("NameChangeCompleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PayGradTuition")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ProgramYear")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Semester")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("SubmissionDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("SubmittedEForm")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("BYUID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("StudentEmployeeCollection.Models.Supervisor", b =>
                {
                    b.Property<int>("SupervisorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("SupervisorID");

                    b.ToTable("Supervisor");
                });

            modelBuilder.Entity("StudentEmployeeCollection.Models.PayIncrease", b =>
                {
                    b.HasOne("StudentEmployeeCollection.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentEmployeeCollection.Models.Position", b =>
                {
                    b.HasOne("StudentEmployeeCollection.Models.Student", "Student")
                        .WithMany("Positions")
                        .HasForeignKey("BYUID");

                    b.HasOne("StudentEmployeeCollection.Models.PositionType", "PositionType")
                        .WithMany()
                        .HasForeignKey("PositionTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentEmployeeCollection.Models.Supervisor", "Supervisor")
                        .WithMany()
                        .HasForeignKey("SupervisorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
