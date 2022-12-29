﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using assignment_4;

#nullable disable

namespace assignment_4.Migrations
{
    [DbContext(typeof(InstituteDb))]
    [Migration("20221229071841_Added5th")]
    partial class Added5th
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("assignment_4.AssignStudent", b =>
                {
                    b.Property<int>("AssignStudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssignStudentId"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("AssignStudentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("AssignStudent");
                });

            modelBuilder.Entity("assignment_4.AssignTeacher", b =>
                {
                    b.Property<int>("AssignTeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssignTeacherId"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("AssignTeacherId");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("AssignTeacher");
                });

            modelBuilder.Entity("assignment_4.Attendance", b =>
                {
                    b.Property<int>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttendanceId"), 1L, 1);

                    b.Property<int>("ClassScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<bool>("Ispresent")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("AttendanceId");

                    b.HasIndex("ClassScheduleId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Attendance");
                });

            modelBuilder.Entity("assignment_4.ClassSchedule", b =>
                {
                    b.Property<int>("ClassScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassScheduleId"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberofClass")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ClassScheduleId");

                    b.HasIndex("CourseId");

                    b.ToTable("ClassSchedule");
                });

            modelBuilder.Entity("assignment_4.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"), 1L, 1);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fees")
                        .HasColumnType("int");

                    b.Property<int>("TottalClass")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("assignment_4.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("assignment_4.Admin", b =>
                {
                    b.HasBaseType("assignment_4.User");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("assignment_4.Student", b =>
                {
                    b.HasBaseType("assignment_4.User");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("assignment_4.Teacher", b =>
                {
                    b.HasBaseType("assignment_4.User");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("assignment_4.AssignStudent", b =>
                {
                    b.HasOne("assignment_4.Course", "Course")
                        .WithMany("AssignStudent")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("assignment_4.Student", "Student")
                        .WithOne("AssignStudent")
                        .HasForeignKey("assignment_4.AssignStudent", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("assignment_4.AssignTeacher", b =>
                {
                    b.HasOne("assignment_4.Course", "Course")
                        .WithMany("AssignTeacher")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("assignment_4.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("assignment_4.Attendance", b =>
                {
                    b.HasOne("assignment_4.ClassSchedule", "ClassSchedule")
                        .WithMany()
                        .HasForeignKey("ClassScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("assignment_4.Course", "Course")
                        .WithMany("Attendances")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("assignment_4.Student", "Student")
                        .WithOne("Attendance")
                        .HasForeignKey("assignment_4.Attendance", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassSchedule");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("assignment_4.ClassSchedule", b =>
                {
                    b.HasOne("assignment_4.Course", "Course")
                        .WithMany("ClassSchedule")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("assignment_4.Course", b =>
                {
                    b.Navigation("AssignStudent");

                    b.Navigation("AssignTeacher");

                    b.Navigation("Attendances");

                    b.Navigation("ClassSchedule");
                });

            modelBuilder.Entity("assignment_4.Student", b =>
                {
                    b.Navigation("AssignStudent")
                        .IsRequired();

                    b.Navigation("Attendance")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
