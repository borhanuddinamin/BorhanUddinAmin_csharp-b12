using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
    public class InstituteDb : DbContext
    {
        private readonly string _Connectionstring;
        private readonly string _Migrationassembly;


        public InstituteDb()
        {
            _Connectionstring = "Server=DESKTOP-MGKTSKL;Database=InstituteDb;Trusted_Connection=True;";
            _Migrationassembly = Assembly.GetExecutingAssembly().GetName().Name;
        }


       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_Connectionstring, (x) => x.MigrationsAssembly(_Migrationassembly));
            }

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* modelBuilder.Entity<ClassSchedule>()
     .HasOne(cs => cs.Course)
     .WithMany(c => c.ClassSchedule)
     .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Attendance>()
         .HasOne(cs => cs.ClassSchedule)
         .WithOne(a => a.Attendance)
         .HasForeignKey<ClassSchedule>(cs => cs.StartTime);*/

            modelBuilder.Entity<User>().HasKey(u => u.UserId);



            base.OnModelCreating(modelBuilder);

        }
        public DbSet<User> User { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<AssignTeacher> AssignTeacher { get; set; }
        public DbSet<AssignStudent> AssignStudent { get; set; }
        public DbSet<ClassSchedule> ClassSchedule { get; set; }
    }
    
}
