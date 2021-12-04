﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using University_CQRS.Persistance.Context;

#nullable disable

namespace University_CQRS.Persistance.Migrations.UniversityReadDb
{
    [DbContext(typeof(UniversityReadDbContext))]
    partial class UniversityReadDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("University_CQRS.Contracts.Entities.Students.StudentAggregate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FirstCourseCredits")
                        .HasColumnType("int");

                    b.Property<string>("FirstCourseGrade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstCourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfEnrollments")
                        .HasColumnType("int");

                    b.Property<int?>("SecondCourseCredits")
                        .HasColumnType("int");

                    b.Property<string>("SecondCourseGrade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondCourseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
