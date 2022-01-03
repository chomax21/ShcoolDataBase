using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace SchoolNumber2
{


    class SchoolDB_Context : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ArchiveOfStudent> ArchiveOfStudents { get; set; }
        public DbSet<LoginPass> LoginPasses { get; set; }
        public DbSet<FinalGrade> FinalGrades { get; set; }
        public DbSet<TeacherRefresherCours> TeacherRefresherCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=Scholl.db", sqliteOptionsAction: op =>
            {
                op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().ToTable("Teachers");
            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.TeachersID);
            });
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentsID);
            });

            modelBuilder.Entity<ArchiveOfStudent>().ToTable("ArchiveOfStudents");
            modelBuilder.Entity<ArchiveOfStudent>(entity =>
            {
                entity.HasKey(e => e.ArchStudentsID);
            });
            modelBuilder.Entity<LoginPass>().ToTable("LoginPass");
            modelBuilder.Entity<LoginPass>(entity =>
            {
                entity.HasKey(e => e.ID);
            });
            modelBuilder.Entity<FinalGrade>().ToTable("FinalGrades");
            modelBuilder.Entity<FinalGrade>(entity =>
            {
                entity.HasKey(e => e.GradeID);
            });
            modelBuilder.Entity<TeacherRefresherCours>().ToTable("TeacherCourses");
            modelBuilder.Entity<TeacherRefresherCours>(entity =>
            {
                entity.HasKey(e => e.CoursesID);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
