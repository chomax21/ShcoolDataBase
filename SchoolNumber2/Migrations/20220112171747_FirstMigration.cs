using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolNumber2.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArchiveOfStudents",
                columns: table => new
                {
                    ArchStudentsID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Class = table.Column<string>(type: "TEXT", nullable: true),
                    SurName = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: true),
                    DOB = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<string>(type: "TEXT", nullable: true),
                    Sex = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    AddresLive = table.Column<string>(type: "TEXT", nullable: true),
                    SNILS = table.Column<string>(type: "TEXT", nullable: true),
                    INN = table.Column<string>(type: "TEXT", nullable: true),
                    Pasport = table.Column<string>(type: "TEXT", nullable: true),
                    PPhone = table.Column<string>(type: "TEXT", nullable: true),
                    PMail = table.Column<string>(type: "TEXT", nullable: true),
                    OVZ = table.Column<string>(type: "TEXT", nullable: true),
                    OVZGroup = table.Column<string>(type: "TEXT", nullable: true),
                    Invalid = table.Column<string>(type: "TEXT", nullable: true),
                    Sirota = table.Column<string>(type: "TEXT", nullable: true),
                    SOP = table.Column<string>(type: "TEXT", nullable: true),
                    AcademicPerfomance = table.Column<string>(type: "TEXT", nullable: true),
                    Activist = table.Column<string>(type: "TEXT", nullable: true),
                    HeadOfTheClass = table.Column<string>(type: "TEXT", nullable: true),
                    HealthCategory = table.Column<string>(type: "TEXT", nullable: true),
                    From = table.Column<string>(type: "TEXT", nullable: true),
                    Where = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchiveOfStudents", x => x.ArchStudentsID);
                });

            migrationBuilder.CreateTable(
                name: "FinalGrades",
                columns: table => new
                {
                    GradeID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SearchID = table.Column<string>(type: "TEXT", nullable: true),
                    WhatClass = table.Column<string>(type: "TEXT", nullable: true),
                    WhatQuarter = table.Column<string>(type: "TEXT", nullable: true),
                    RusskiyYazuk = table.Column<string>(type: "TEXT", nullable: true),
                    LitareturnoeChtenie = table.Column<string>(type: "TEXT", nullable: true),
                    RodnoyChuvashYazuk = table.Column<string>(type: "TEXT", nullable: true),
                    RodnoyRusskiyYazuk = table.Column<string>(type: "TEXT", nullable: true),
                    LiteraturnoeChtenieNaRodmonYzukeChuv = table.Column<string>(type: "TEXT", nullable: true),
                    LiteraturnoeChtenieNaRodmonYzukeRuss = table.Column<string>(type: "TEXT", nullable: true),
                    InostranuyYazukEnglish = table.Column<string>(type: "TEXT", nullable: true),
                    InostranuyYazukGermany = table.Column<string>(type: "TEXT", nullable: true),
                    HistoryRussiaVseobshayHistory = table.Column<string>(type: "TEXT", nullable: true),
                    Obshetvoznanie = table.Column<string>(type: "TEXT", nullable: true),
                    Geography = table.Column<string>(type: "TEXT", nullable: true),
                    Matematika = table.Column<string>(type: "TEXT", nullable: true),
                    Algebra = table.Column<string>(type: "TEXT", nullable: true),
                    Geometry = table.Column<string>(type: "TEXT", nullable: true),
                    Informatika = table.Column<string>(type: "TEXT", nullable: true),
                    OsnovuDuxovnoNravstvennoyKultNarodovRussia = table.Column<string>(type: "TEXT", nullable: true),
                    Fizika = table.Column<string>(type: "TEXT", nullable: true),
                    Ximia = table.Column<string>(type: "TEXT", nullable: true),
                    Biology = table.Column<string>(type: "TEXT", nullable: true),
                    OkrMir = table.Column<string>(type: "TEXT", nullable: true),
                    OsnovuReligiiISvetskoyEtiki = table.Column<string>(type: "TEXT", nullable: true),
                    Muzika = table.Column<string>(type: "TEXT", nullable: true),
                    IZO = table.Column<string>(type: "TEXT", nullable: true),
                    FIZRA = table.Column<string>(type: "TEXT", nullable: true),
                    Shahmate = table.Column<string>(type: "TEXT", nullable: true),
                    OBZ = table.Column<string>(type: "TEXT", nullable: true),
                    MoyGorod = table.Column<string>(type: "TEXT", nullable: true),
                    HistoryKultureRodnogoKray = table.Column<string>(type: "TEXT", nullable: true),
                    Technology = table.Column<string>(type: "TEXT", nullable: true),
                    IstoriaIKulturaRodnogoKraya = table.Column<string>(type: "TEXT", nullable: true),
                    GosYazukChuvRespublici = table.Column<string>(type: "TEXT", nullable: true),
                    Pravo = table.Column<string>(type: "TEXT", nullable: true),
                    Ekonomika = table.Column<string>(type: "TEXT", nullable: true),
                    MatematikaAlgebraIMatematikaAnalizGeometry = table.Column<string>(type: "TEXT", nullable: true),
                    AspektuClassicFiziki = table.Column<string>(type: "TEXT", nullable: true),
                    PonytiaIZakonuXimii = table.Column<string>(type: "TEXT", nullable: true),
                    BiologyKletkiIOrganizma = table.Column<string>(type: "TEXT", nullable: true),
                    Astronomia = table.Column<string>(type: "TEXT", nullable: true),
                    RaznoAspectnuyAnalizTeksta = table.Column<string>(type: "TEXT", nullable: true),
                    Literatura = table.Column<string>(type: "TEXT", nullable: true),
                    History = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalGrades", x => x.GradeID);
                });

            migrationBuilder.CreateTable(
                name: "LoginPass",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(type: "TEXT", nullable: true),
                    Pass = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginPass", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentsID = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Class = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    SurName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    MiddleName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DOB = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Age = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Sex = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    AddresLive = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    SNILS = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    INN = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Pasport = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    PPhone = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    PMail = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    OVZ = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    OVZGroup = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Invalid = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Sirota = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    SOP = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    AcademicPerfomance = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Activist = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    HeadOfTheClass = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    HealthCategory = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    From = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    Where = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentsID);
                });

            migrationBuilder.CreateTable(
                name: "TeacherCourses",
                columns: table => new
                {
                    CoursesID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SearchTeacherID = table.Column<int>(type: "INTEGER", nullable: false),
                    NameCours = table.Column<string>(type: "TEXT", nullable: true),
                    CoursDate = table.Column<string>(type: "TEXT", nullable: true),
                    DeadLineCours = table.Column<string>(type: "TEXT", nullable: true),
                    CoursHowMachYear = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherCourses", x => x.CoursesID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeachersID = table.Column<int>(type: "INTEGER", maxLength: 20, nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TSurName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    TName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    TMiddleName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    TDOB = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    TAge = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    TAdress = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    TAdressLive = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    TSNILS = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    TINN = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    TPassport = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    TEducation = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    EducationSpecialization = table.Column<string>(type: "TEXT", maxLength: 150, nullable: true),
                    Expirience = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    ExpirienceTeaching = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Rate = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    Spicialization = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    SpecItem = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    SpecItemHours = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    DopSpecItem = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DopSpecItemHours = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    GPDHours = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DPU = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DPUHours = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    PFDOT = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    PFDOTHours = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    TCategory = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    HonorEmploy = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    YangSpicialist = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Сoefficient = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    KPK = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    PrimaryOrSecondary = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    BaseClass = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeachersID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArchiveOfStudents");

            migrationBuilder.DropTable(
                name: "FinalGrades");

            migrationBuilder.DropTable(
                name: "LoginPass");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TeacherCourses");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
