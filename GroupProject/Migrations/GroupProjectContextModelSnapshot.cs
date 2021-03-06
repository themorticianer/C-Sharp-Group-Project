﻿// <auto-generated />
using GroupProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroupProject.Migrations
{
    [DbContext(typeof(GroupProjectContext))]
    partial class GroupProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("GroupProject.Models.Accounts", b =>
                {
                    b.Property<int>("AccID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AccID");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("GroupProject.Models.Courses", b =>
                {
                    b.Property<string>("CourseID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<bool>("Online")
                        .HasColumnType("bit");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
