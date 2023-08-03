﻿// <auto-generated />
using DoctorOffice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorOffice.Migrations
{
    [DbContext(typeof(DoctorOfficeContext))]
    partial class DoctorOfficeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DoctorOffice.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AppointmentDate")
                        .HasColumnType("longtext");

                    b.Property<string>("AppointmentTime")
                        .HasColumnType("longtext");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("PatientComment")
                        .HasColumnType("longtext");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("LocationId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("DoctorOffice.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DoctorOffice.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsFullTime")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsHeadStaff")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("DoctorId");

                    b.HasIndex("LocationId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("DoctorOffice.Models.DoctorPatient", b =>
                {
                    b.Property<int>("DoctorPatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("DoctorRole")
                        .HasColumnType("longtext");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("DoctorPatientId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("DoctorPatients");
                });

            modelBuilder.Entity("DoctorOffice.Models.DoctorSpecialty", b =>
                {
                    b.Property<int>("DoctorSpecialtyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("SpecialtyId")
                        .HasColumnType("int");

                    b.HasKey("DoctorSpecialtyId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("SpecialtyId");

                    b.ToTable("DoctorSpecialties");
                });

            modelBuilder.Entity("DoctorOffice.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("LocationType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Room")
                        .HasColumnType("int");

                    b.HasKey("LocationId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DoctorOffice.Models.OfficeHour", b =>
                {
                    b.Property<int>("OfficeHourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClosedHour")
                        .HasColumnType("int");

                    b.Property<int>("OpenHour")
                        .HasColumnType("int");

                    b.Property<string>("Weekday")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("OfficeHourId");

                    b.ToTable("OfficeHours");
                });

            modelBuilder.Entity("DoctorOffice.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsInPatient")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsLongTermCare")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PatientId");

                    b.HasIndex("LocationId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DoctorOffice.Models.Specialty", b =>
                {
                    b.Property<int>("SpecialtyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("SpecialtyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SpecialtyId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Specialties");
                });

            modelBuilder.Entity("DoctorOffice.Models.Appointment", b =>
                {
                    b.HasOne("DoctorOffice.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorOffice.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorOffice.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Location");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DoctorOffice.Models.Doctor", b =>
                {
                    b.HasOne("DoctorOffice.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("DoctorOffice.Models.DoctorPatient", b =>
                {
                    b.HasOne("DoctorOffice.Models.Doctor", "Doctor")
                        .WithMany("DoctorPatients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorOffice.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DoctorOffice.Models.DoctorSpecialty", b =>
                {
                    b.HasOne("DoctorOffice.Models.Doctor", "Doctor")
                        .WithMany("DoctorSpecialties")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorOffice.Models.Specialty", "Specialty")
                        .WithMany("DoctorSpecialties")
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Specialty");
                });

            modelBuilder.Entity("DoctorOffice.Models.Location", b =>
                {
                    b.HasOne("DoctorOffice.Models.Department", "Department")
                        .WithMany("Locations")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DoctorOffice.Models.Patient", b =>
                {
                    b.HasOne("DoctorOffice.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("DoctorOffice.Models.Specialty", b =>
                {
                    b.HasOne("DoctorOffice.Models.Department", "Department")
                        .WithMany("Specialties")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DoctorOffice.Models.Department", b =>
                {
                    b.Navigation("Locations");

                    b.Navigation("Specialties");
                });

            modelBuilder.Entity("DoctorOffice.Models.Doctor", b =>
                {
                    b.Navigation("DoctorPatients");

                    b.Navigation("DoctorSpecialties");
                });

            modelBuilder.Entity("DoctorOffice.Models.Specialty", b =>
                {
                    b.Navigation("DoctorSpecialties");
                });
#pragma warning restore 612, 618
        }
    }
}
