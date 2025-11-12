using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;

namespace School.Infrastructure.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Filtro para Soft Delete
            modelBuilder.Entity<Student>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Course>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Instructor>().HasQueryFilter(e => !e.IsDeleted);
            modelBuilder.Entity<Department>().HasQueryFilter(e => !e.IsDeleted);

            // Relación M-a-M Student-Course
            modelBuilder.Entity<Course>()
                .HasMany(c => c.Students)
                .WithMany(s => s.Courses)
                .UsingEntity(j => j.ToTable("CourseStudent"));

            // Arreglo del Warning de 'Budget'
            modelBuilder.Entity<Department>()
                .Property(d => d.Budget)
                .HasPrecision(18, 2);
        }
    }
}