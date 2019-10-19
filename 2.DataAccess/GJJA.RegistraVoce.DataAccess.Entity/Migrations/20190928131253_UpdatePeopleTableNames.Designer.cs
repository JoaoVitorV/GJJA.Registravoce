﻿// <auto-generated />
using System;
using GJJA.RegistraVoce.DataAccess.Entity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GJJA.RegistraVoce.DataAccess.Entity.Migrations
{
    [DbContext(typeof(RegistraVoceDbContext))]
    [Migration("20190928131253_UpdatePeopleTableNames")]
    partial class UpdatePeopleTableNames
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("GJJA.RegistraVoce.Domain.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PEO_ID");

                    b.Property<string>("Address")
                        .HasColumnName("PEO_ADDRESS")
                        .HasMaxLength(100);

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnName("PEO_IDENTIFICATION")
                        .HasMaxLength(15);

                    b.Property<int>("Gender")
                        .HasColumnName("PEO_GENDER");

                    b.Property<string>("Identification");

                    b.Property<int>("MeritalStatus")
                        .HasColumnName("PEO_MERITAL_STATUS");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("PEO_NAME")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasColumnName("PEO_PHONE")
                        .HasMaxLength(12);

                    b.HasKey("Id");

                    b.ToTable("PEO_PEOPLE");
                });
#pragma warning restore 612, 618
        }
    }
}
