﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission08_Group_2_1.Models;

namespace Mission08_Group_2_1.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission08_Group_2_1.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Home"
                        },
                        new
                        {
                            Id = 2,
                            Name = "School"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Work"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Church"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("Mission08_Group_2_1.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quadrant")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Completed = false,
                            DueDate = "2023-02-25",
                            Name = "404 Exam",
                            Quadrant = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 5,
                            Completed = false,
                            DueDate = "2023-02-28",
                            Name = "Call Doctor",
                            Quadrant = 3
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 5,
                            Completed = false,
                            DueDate = "2023-03-04",
                            Name = "Date Night",
                            Quadrant = 2
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 5,
                            Completed = false,
                            DueDate = "2023-03-04",
                            Name = "COD with the Boyz",
                            Quadrant = 4
                        });
                });

            modelBuilder.Entity("Mission08_Group_2_1.Models.Task", b =>
                {
                    b.HasOne("Mission08_Group_2_1.Models.Category", "TaskCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
