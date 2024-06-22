﻿// <auto-generated />
using System;
using Bank_Account_Opening_Form.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bank_Account_Opening_Form.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20240622115914_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bank_Account_Opening_Form.Models.AccountOpeningForm", b =>
                {
                    b.Property<int>("FormNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustAccountType")
                        .HasColumnType("int");

                    b.Property<int>("CustAge")
                        .HasColumnType("int");

                    b.Property<int>("CustBranchCode")
                        .HasColumnType("int");

                    b.Property<int>("CustCityCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("CustDateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustEmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustMiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustMobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustPreferredLanguage")
                        .HasColumnType("int");

                    b.Property<int>("CustSex")
                        .HasColumnType("int");

                    b.Property<int>("CustStateCode")
                        .HasColumnType("int");

                    b.Property<string>("CustStdCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustTelephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustTitle")
                        .HasColumnType("int");

                    b.Property<DateTime>("FormFillingDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("FormFillingTime")
                        .HasColumnType("time");

                    b.HasKey("FormNumber");

                    b.ToTable("AccountOpeningForms");
                });

            modelBuilder.Entity("Bank_Account_Opening_Form.Models.Branch", b =>
                {
                    b.Property<int>("BranchCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchCityCode")
                        .HasColumnType("int");

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchCode");

                    b.HasIndex("BranchCityCode");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Bank_Account_Opening_Form.Models.City", b =>
                {
                    b.Property<int>("CityCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityStateCode")
                        .HasColumnType("int");

                    b.HasKey("CityCode");

                    b.HasIndex("CityStateCode");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Bank_Account_Opening_Form.Models.State", b =>
                {
                    b.Property<int>("StateCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateCode");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Bank_Account_Opening_Form.Models.Branch", b =>
                {
                    b.HasOne("Bank_Account_Opening_Form.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("BranchCityCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Bank_Account_Opening_Form.Models.City", b =>
                {
                    b.HasOne("Bank_Account_Opening_Form.Models.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("CityStateCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("Bank_Account_Opening_Form.Models.State", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
