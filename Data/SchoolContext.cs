// CHANGE HISTORY
///////////////////////////////////////////////////////////////////////////////////////////////////
// DATE         DEVELOPER           DESCRIPTION
// 03-06-2025   adorog12@uw.edu     Create new SchoolContext that extends DbContext
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
