﻿// <auto-generated />
using System;
using CourseManagement.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseManagement.Infrastructure.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20200719023446_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseManagement.Domain.Entities.ClassRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClassRooms");
                });

            modelBuilder.Entity("CourseManagement.Domain.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassRoomId")
                        .HasColumnType("int");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassRoomId");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Credits = 3,
                            DepartmentID = 3,
                            Title = "Chemistry"
                        },
                        new
                        {
                            Id = 2,
                            Credits = 3,
                            DepartmentID = 4,
                            Title = "Microeconomics"
                        },
                        new
                        {
                            Id = 3,
                            Credits = 3,
                            DepartmentID = 4,
                            Title = "Macroeconomics"
                        },
                        new
                        {
                            Id = 4,
                            Credits = 4,
                            DepartmentID = 2,
                            Title = "Calculus"
                        },
                        new
                        {
                            Id = 5,
                            Credits = 4,
                            DepartmentID = 2,
                            Title = "Trigonometry"
                        },
                        new
                        {
                            Id = 6,
                            Credits = 3,
                            DepartmentID = 1,
                            Title = "Composition"
                        },
                        new
                        {
                            Id = 7,
                            Credits = 4,
                            DepartmentID = 1,
                            Title = "Music"
                        },
                        new
                        {
                            Id = 8,
                            Credits = 4,
                            DepartmentID = 1,
                            Title = "Literature"
                        });
                });

            modelBuilder.Entity("CourseManagement.Domain.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Budget = 350000m,
                            Name = "English",
                            StartDate = new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Budget = 100000m,
                            Name = "Mathematics",
                            StartDate = new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Budget = 350000m,
                            Name = "Engineering",
                            StartDate = new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Budget = 100000m,
                            Name = "Economics",
                            StartDate = new DateTime(2007, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CourseManagement.Domain.Entities.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseID = 1,
                            Grade = 0,
                            StudentID = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseID = 2,
                            Grade = 2,
                            StudentID = 1
                        },
                        new
                        {
                            Id = 3,
                            CourseID = 2,
                            Grade = 1,
                            StudentID = 1
                        },
                        new
                        {
                            Id = 4,
                            CourseID = 3,
                            Grade = 1,
                            StudentID = 2
                        },
                        new
                        {
                            Id = 5,
                            CourseID = 2,
                            Grade = 1,
                            StudentID = 2
                        },
                        new
                        {
                            Id = 6,
                            CourseID = 4,
                            Grade = 1,
                            StudentID = 2
                        },
                        new
                        {
                            Id = 7,
                            CourseID = 2,
                            StudentID = 3
                        },
                        new
                        {
                            Id = 8,
                            CourseID = 4,
                            Grade = 1,
                            StudentID = 3
                        },
                        new
                        {
                            Id = 9,
                            CourseID = 2,
                            Grade = 1,
                            StudentID = 4
                        },
                        new
                        {
                            Id = 10,
                            CourseID = 3,
                            Grade = 1,
                            StudentID = 5
                        },
                        new
                        {
                            Id = 11,
                            CourseID = 1,
                            Grade = 1,
                            StudentID = 6
                        });
                });

            modelBuilder.Entity("CourseManagement.Domain.Entities.OfficeAssignment", b =>
                {
                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.ToTable("OfficeAssignments");

                    b.HasData(
                        new
                        {
                            TeacherID = 1,
                            Location = "Smith 17"
                        },
                        new
                        {
                            TeacherID = 2,
                            Location = "Gowan 27"
                        },
                        new
                        {
                            TeacherID = 3,
                            Location = "Thompson 304"
                        });
                });

            modelBuilder.Entity("CourseManagement.Domain.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CNP")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CNP = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Carson",
                            LastName = "Alexander"
                        },
                        new
                        {
                            Id = 2,
                            CNP = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2017, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Meredith",
                            LastName = "Alonso"
                        },
                        new
                        {
                            Id = 3,
                            CNP = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Arturo",
                            LastName = "Anand"
                        },
                        new
                        {
                            Id = 4,
                            CNP = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Gytis",
                            LastName = "Barzdukas"
                        },
                        new
                        {
                            Id = 5,
                            CNP = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Yan",
                            LastName = "Li"
                        },
                        new
                        {
                            Id = 6,
                            CNP = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Peggy",
                            LastName = "Justice"
                        },
                        new
                        {
                            Id = 7,
                            CNP = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2016, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Laura",
                            LastName = "Norman"
                        },
                        new
                        {
                            Id = 8,
                            CNP = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EnrollmentDate = new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Nino",
                            LastName = "Olivetto"
                        });
                });

            modelBuilder.Entity("CourseManagement.Domain.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseID")
                        .IsUnique();

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseID = 2,
                            FirstName = "Kim",
                            HireDate = new DateTime(1995, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Abercrombie"
                        },
                        new
                        {
                            Id = 2,
                            CourseID = 3,
                            FirstName = "Fadi",
                            HireDate = new DateTime(2002, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Fakhouri"
                        },
                        new
                        {
                            Id = 3,
                            CourseID = 4,
                            FirstName = "Roger",
                            HireDate = new DateTime(1998, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Harui"
                        },
                        new
                        {
                            Id = 4,
                            CourseID = 5,
                            FirstName = "Candace",
                            HireDate = new DateTime(2001, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Kapoor"
                        },
                        new
                        {
                            Id = 5,
                            CourseID = 6,
                            FirstName = "Fakhouri",
                            HireDate = new DateTime(2004, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Zheng"
                        },
                        new
                        {
                            Id = 6,
                            CourseID = 7,
                            FirstName = "Roger",
                            HireDate = new DateTime(2004, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Kim"
                        },
                        new
                        {
                            Id = 7,
                            CourseID = 8,
                            FirstName = "Abercrombie",
                            HireDate = new DateTime(2004, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Nino"
                        });
                });

            modelBuilder.Entity("CourseManagement.Domain.Entities.Course", b =>
                {
                    b.HasOne("CourseManagement.Domain.Entities.ClassRoom", null)
                        .WithMany("Courses")
                        .HasForeignKey("ClassRoomId");

                    b.HasOne("CourseManagement.Domain.Entities.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseManagement.Domain.Entities.Enrollment", b =>
                {
                    b.HasOne("CourseManagement.Domain.Entities.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseManagement.Domain.Entities.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseManagement.Domain.Entities.OfficeAssignment", b =>
                {
                    b.HasOne("CourseManagement.Domain.Entities.Teacher", "Teacher")
                        .WithOne("OfficeAssignment")
                        .HasForeignKey("CourseManagement.Domain.Entities.OfficeAssignment", "TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CourseManagement.Domain.Entities.Teacher", b =>
                {
                    b.HasOne("CourseManagement.Domain.Entities.Course", "Course")
                        .WithOne("Teacher")
                        .HasForeignKey("CourseManagement.Domain.Entities.Teacher", "CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
