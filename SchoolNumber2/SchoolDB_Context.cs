using Microsoft.EntityFrameworkCore;

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
            optionsBuilder.UseSqlite("Data Source=Scholl.db");
            //optionsBuilder.UseSqlite("FileName=Scholl.db", sqliteOptionsAction: op =>
            //{
            //    op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            //});

            //base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().ToTable("Teachers");
            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.TeachersID);
                entity.Property(p => p.TName).HasMaxLength(50);
                entity.Property(p => p.TSurName).HasMaxLength(50);
                entity.Property(p => p.TMiddleName).HasMaxLength(50);
                entity.Property(p => p.TAdress).HasMaxLength(100);
                entity.Property(p => p.TAdressLive).HasMaxLength(100);
                entity.Property(p => p.TAge).HasMaxLength(10);
                entity.Property(p => p.TCategory).HasMaxLength(10);
                entity.Property(p => p.TDOB).HasMaxLength(50);
                entity.Property(p => p.TEducation).HasMaxLength(200);
                entity.Property(p => p.TINN).HasMaxLength(20);
                entity.Property(p => p.TPassport).HasMaxLength(100);
                entity.Property(p => p.TSNILS).HasMaxLength(20);
                entity.Property(p => p.ExpirienceTeaching).HasMaxLength(20);
                entity.Property(p => p.BaseClass).HasMaxLength(10);
                entity.Property(p => p.DopSpecItem).HasMaxLength(100);
                entity.Property(p => p.DopSpecItemHours).HasMaxLength(20);
                entity.Property(p => p.DPU).HasMaxLength(100);
                entity.Property(p => p.DPUHours).HasMaxLength(20);
                entity.Property(p => p.EducationSpecialization).HasMaxLength(150);
                entity.Property(p => p.Email).HasMaxLength(100);
                entity.Property(p => p.Expirience).HasMaxLength(20);
                entity.Property(p => p.ExpirienceTeaching).HasMaxLength(20);
                entity.Property(p => p.GPDHours).HasMaxLength(100);
                entity.Property(p => p.HonorEmploy).HasMaxLength(10);
                entity.Property(p => p.KPK).HasMaxLength(10);
                entity.Property(p => p.PFDOT).HasMaxLength(50);
                entity.Property(p => p.PFDOTHours).HasMaxLength(50);
                entity.Property(p => p.Phone).HasMaxLength(100);
                entity.Property(p => p.PrimaryOrSecondary).HasMaxLength(20);
                entity.Property(p => p.Rate).HasMaxLength(20);
                entity.Property(p => p.SpecItem).HasMaxLength(100);
                entity.Property(p => p.SpecItemHours).HasMaxLength(10);
                entity.Property(p => p.Spicialization).HasMaxLength(100);
                entity.Property(p => p.YangSpicialist).HasMaxLength(10);
                entity.Property(p => p.Сoefficient).HasMaxLength(20);
                entity.Property(p => p.TeachersID).HasMaxLength(20);

            });

            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentsID);
                entity.Property(p => p.AcademicPerfomance).HasMaxLength(20);
                entity.Property(p => p.Activist).HasMaxLength(20);
                entity.Property(p => p.AddresLive).HasMaxLength(100);
                entity.Property(p => p.Address).HasMaxLength(100);
                entity.Property(p => p.Age).HasMaxLength(10);
                entity.Property(p => p.Class).HasMaxLength(10);
                entity.Property(p => p.DOB).HasMaxLength(50);
                entity.Property(p => p.FirstName).HasMaxLength(50);
                entity.Property(p => p.From).HasMaxLength(200);
                entity.Property(p => p.HeadOfTheClass).HasMaxLength(10);
                entity.Property(p => p.HealthCategory).HasMaxLength(10);
                entity.Property(p => p.INN).HasMaxLength(20);
                entity.Property(p => p.Invalid).HasMaxLength(20);
                entity.Property(p => p.MiddleName).HasMaxLength(100);
                entity.Property(p => p.OVZ).HasMaxLength(100);
                entity.Property(p => p.OVZGroup).HasMaxLength(10);
                entity.Property(p => p.Pasport).HasMaxLength(100);
                entity.Property(p => p.PMail).HasMaxLength(100);
                entity.Property(p => p.PPhone).HasMaxLength(200);
                entity.Property(p => p.Sex).HasMaxLength(10);
                entity.Property(p => p.Sirota).HasMaxLength(10);
                entity.Property(p => p.SNILS).HasMaxLength(20);
                entity.Property(p => p.SOP).HasMaxLength(100);
                entity.Property(p => p.SurName).HasMaxLength(100);
                entity.Property(p => p.Where).HasMaxLength(200);
                entity.Property(p => p.StudentsID).HasMaxLength(20);
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
