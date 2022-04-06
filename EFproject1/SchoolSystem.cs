using Microsoft.EntityFrameworkCore;

namespace EFproject1
{
    internal class SchoolSystem : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherCourse> TeacherCourses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<StudentInformation> StudentInformations { get; set; }
        public DbSet<Course> Courses { get; set; }

       const string connectionString = "Host = localhost; Port = 5432; UserId = postgres; Password = LondoNVS2023; Database = SchoolSystem";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(connectionString);
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<StudentCourse>().HasOne(StC=>StC.Student).WithMany(s=>s.StudentCourses).HasForeignKey(s=>s.StudentId);
            modelBuilder.Entity<StudentCourse>().HasOne(StC => StC.Course).WithMany(s => s.StudentCourses).HasForeignKey(s => s.CourseId);
            modelBuilder.Entity<StudentCourse>().HasKey(StC => new { StC.StudentId, StC.CourseId });
            modelBuilder.Entity<TeacherCourse>().HasOne(Tc => Tc.Teacher).WithMany(t => t.TeacherCourses).HasForeignKey(t => t.TeacherId);
            modelBuilder.Entity<TeacherCourse>().HasOne(Tc => Tc.Course).WithMany(t => t.TeacherCourses).HasForeignKey(t => t.CourseId);
            modelBuilder.Entity<TeacherCourse>().HasKey(Tc => new {Tc.TeacherId, Tc.CourseId });



        }
    }
}

