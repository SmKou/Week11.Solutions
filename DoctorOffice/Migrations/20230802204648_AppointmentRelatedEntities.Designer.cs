﻿// <auto-generated />
using System;
using DoctorOffice.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorOffice.Migrations
{
    [DbContext(typeof(DoctorOfficeContext))]
    [Migration("20230802204648_AppointmentRelatedEntities")]
    partial class AppointmentRelatedEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("AppointmentTime")
                        .HasColumnType("datetime(6)");

                    b.Property<float>("BillRemainderDue")
                        .HasColumnType("float");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsBillPaid")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("LocationId");

                    b.HasIndex("PatientId");

                    b.HasIndex("ProviderId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("DoctorOffice.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("longtext");

                    b.Property<int>("SpecialtyId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId");

                    b.HasIndex("SpecialtyId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DoctorOffice.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EmployeeNo")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsClinicStaff")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsFullTime")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsHeadStaff")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsOnInternship")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsOnResidence")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsResearchFellow")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("MentorId")
                        .HasColumnType("int");

                    b.Property<string>("MiddleName")
                        .HasColumnType("longtext");

                    b.Property<string>("PreferredName")
                        .HasColumnType("longtext");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("DoctorId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ProviderId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("DoctorOffice.Models.DoctorPatient", b =>
                {
                    b.Property<int>("DoctorPatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Relation")
                        .HasColumnType("longtext");

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

                    b.Property<int>("RoomNo")
                        .HasColumnType("int");

                    b.Property<string>("RoomType")
                        .HasColumnType("longtext");

                    b.HasKey("LocationId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("DoctorOffice.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsInPatient")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsLongTermCare")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsPermanentSupport")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("MiddleName")
                        .HasColumnType("longtext");

                    b.Property<int>("PatientNo")
                        .HasColumnType("int");

                    b.Property<string>("PreferredName")
                        .HasColumnType("longtext");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("PatientId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ProviderId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DoctorOffice.Models.Provider", b =>
                {
                    b.Property<int>("ProviderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ProviderAcctId")
                        .HasColumnType("int");

                    b.Property<int>("ProviderAuthId")
                        .HasColumnType("int");

                    b.Property<string>("ProviderName")
                        .HasColumnType("longtext");

                    b.HasKey("ProviderId");

                    b.HasIndex("ProviderAcctId");

                    b.HasIndex("ProviderAuthId");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("DoctorOffice.Models.ProviderAcct", b =>
                {
                    b.Property<int>("ProviderAcctId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountNo")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.HasKey("ProviderAcctId");

                    b.ToTable("ProviderAccounts");
                });

            modelBuilder.Entity("DoctorOffice.Models.ProviderAuth", b =>
                {
                    b.Property<int>("ProviderAuthId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("UrlAuth")
                        .HasColumnType("longtext");

                    b.HasKey("ProviderAuthId");

                    b.ToTable("ProviderAuths");
                });

            modelBuilder.Entity("DoctorOffice.Models.Specialty", b =>
                {
                    b.Property<int>("SpecialtyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("SpecialtyName")
                        .HasColumnType("longtext");

                    b.HasKey("SpecialtyId");

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

                    b.HasOne("DoctorOffice.Models.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Location");

                    b.Navigation("Patient");

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("DoctorOffice.Models.Department", b =>
                {
                    b.HasOne("DoctorOffice.Models.Specialty", "Specialty")
                        .WithMany()
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialty");
                });

            modelBuilder.Entity("DoctorOffice.Models.Doctor", b =>
                {
                    b.HasOne("DoctorOffice.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorOffice.Models.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("DoctorOffice.Models.DoctorPatient", b =>
                {
                    b.HasOne("DoctorOffice.Models.Doctor", "Doctor")
                        .WithMany("JoinPatients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorOffice.Models.Patient", "Patient")
                        .WithMany("JoinDoctors")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DoctorOffice.Models.DoctorSpecialty", b =>
                {
                    b.HasOne("DoctorOffice.Models.Doctor", "Doctor")
                        .WithMany("JoinSpecialties")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorOffice.Models.Specialty", "Specialty")
                        .WithMany("JoinDoctors")
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

                    b.HasOne("DoctorOffice.Models.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("DoctorOffice.Models.Provider", b =>
                {
                    b.HasOne("DoctorOffice.Models.ProviderAcct", "ProviderAcct")
                        .WithMany()
                        .HasForeignKey("ProviderAcctId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorOffice.Models.ProviderAuth", "ProviderAuth")
                        .WithMany()
                        .HasForeignKey("ProviderAuthId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProviderAcct");

                    b.Navigation("ProviderAuth");
                });

            modelBuilder.Entity("DoctorOffice.Models.Department", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("DoctorOffice.Models.Doctor", b =>
                {
                    b.Navigation("JoinPatients");

                    b.Navigation("JoinSpecialties");
                });

            modelBuilder.Entity("DoctorOffice.Models.Patient", b =>
                {
                    b.Navigation("JoinDoctors");
                });

            modelBuilder.Entity("DoctorOffice.Models.Specialty", b =>
                {
                    b.Navigation("JoinDoctors");
                });
#pragma warning restore 612, 618
        }
    }
}
