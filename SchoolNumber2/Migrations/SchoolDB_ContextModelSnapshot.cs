﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolNumber2;

namespace SchoolNumber2.Migrations
{
    [DbContext(typeof(SchoolDB_Context))]
    partial class SchoolDB_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("SchoolNumber2.ArchiveOfStudent", b =>
                {
                    b.Property<int>("ArchStudentsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AcademicPerfomance")
                        .HasColumnType("TEXT");

                    b.Property<string>("Activist")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddresLive")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Age")
                        .HasColumnType("TEXT");

                    b.Property<string>("Class")
                        .HasColumnType("TEXT");

                    b.Property<string>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("From")
                        .HasColumnType("TEXT");

                    b.Property<string>("HeadOfTheClass")
                        .HasColumnType("TEXT");

                    b.Property<string>("HealthCategory")
                        .HasColumnType("TEXT");

                    b.Property<string>("INN")
                        .HasColumnType("TEXT");

                    b.Property<string>("Invalid")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("OVZ")
                        .HasColumnType("TEXT");

                    b.Property<string>("OVZGroup")
                        .HasColumnType("TEXT");

                    b.Property<string>("PMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("PPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pasport")
                        .HasColumnType("TEXT");

                    b.Property<string>("SNILS")
                        .HasColumnType("TEXT");

                    b.Property<string>("SOP")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sirota")
                        .HasColumnType("TEXT");

                    b.Property<string>("SurName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Where")
                        .HasColumnType("TEXT");

                    b.HasKey("ArchStudentsID");

                    b.ToTable("ArchiveOfStudents");
                });

            modelBuilder.Entity("SchoolNumber2.FinalGrade", b =>
                {
                    b.Property<int>("GradeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Algebra")
                        .HasColumnType("TEXT");

                    b.Property<string>("AspektuClassicFiziki")
                        .HasColumnType("TEXT");

                    b.Property<string>("Astronomia")
                        .HasColumnType("TEXT");

                    b.Property<string>("Biology")
                        .HasColumnType("TEXT");

                    b.Property<string>("BiologyKletkiIOrganizma")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ekonomika")
                        .HasColumnType("TEXT");

                    b.Property<string>("FIZRA")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fizika")
                        .HasColumnType("TEXT");

                    b.Property<string>("Geography")
                        .HasColumnType("TEXT");

                    b.Property<string>("Geometry")
                        .HasColumnType("TEXT");

                    b.Property<string>("GosYazukChuvRespublici")
                        .HasColumnType("TEXT");

                    b.Property<string>("History")
                        .HasColumnType("TEXT");

                    b.Property<string>("HistoryKultureRodnogoKray")
                        .HasColumnType("TEXT");

                    b.Property<string>("HistoryRussiaVseobshayHistory")
                        .HasColumnType("TEXT");

                    b.Property<string>("IZO")
                        .HasColumnType("TEXT");

                    b.Property<string>("Informatika")
                        .HasColumnType("TEXT");

                    b.Property<string>("InostranuyYazukEnglish")
                        .HasColumnType("TEXT");

                    b.Property<string>("InostranuyYazukGermany")
                        .HasColumnType("TEXT");

                    b.Property<string>("IstoriaIKulturaRodnogoKraya")
                        .HasColumnType("TEXT");

                    b.Property<string>("LitareturnoeChtenie")
                        .HasColumnType("TEXT");

                    b.Property<string>("Literatura")
                        .HasColumnType("TEXT");

                    b.Property<string>("LiteraturnoeChtenieNaRodmonYzukeChuv")
                        .HasColumnType("TEXT");

                    b.Property<string>("LiteraturnoeChtenieNaRodmonYzukeRuss")
                        .HasColumnType("TEXT");

                    b.Property<string>("Matematika")
                        .HasColumnType("TEXT");

                    b.Property<string>("MatematikaAlgebraIMatematikaAnalizGeometry")
                        .HasColumnType("TEXT");

                    b.Property<string>("MoyGorod")
                        .HasColumnType("TEXT");

                    b.Property<string>("Muzika")
                        .HasColumnType("TEXT");

                    b.Property<string>("OBZ")
                        .HasColumnType("TEXT");

                    b.Property<string>("Obshetvoznanie")
                        .HasColumnType("TEXT");

                    b.Property<string>("OkrMir")
                        .HasColumnType("TEXT");

                    b.Property<string>("OsnovuDuxovnoNravstvennoyKultNarodovRussia")
                        .HasColumnType("TEXT");

                    b.Property<string>("OsnovuReligiiISvetskoyEtiki")
                        .HasColumnType("TEXT");

                    b.Property<string>("PonytiaIZakonuXimii")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pravo")
                        .HasColumnType("TEXT");

                    b.Property<string>("RaznoAspectnuyAnalizTeksta")
                        .HasColumnType("TEXT");

                    b.Property<string>("RodnoyChuvashYazuk")
                        .HasColumnType("TEXT");

                    b.Property<string>("RodnoyRusskiyYazuk")
                        .HasColumnType("TEXT");

                    b.Property<string>("RusskiyYazuk")
                        .HasColumnType("TEXT");

                    b.Property<string>("SearchID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Shahmate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Technology")
                        .HasColumnType("TEXT");

                    b.Property<string>("WhatClass")
                        .HasColumnType("TEXT");

                    b.Property<string>("WhatQuarter")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ximia")
                        .HasColumnType("TEXT");

                    b.HasKey("GradeID");

                    b.ToTable("FinalGrades");
                });

            modelBuilder.Entity("SchoolNumber2.LoginPass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pass")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("LoginPass");
                });

            modelBuilder.Entity("SchoolNumber2.Student", b =>
                {
                    b.Property<int>("StudentsID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("INTEGER");

                    b.Property<string>("AcademicPerfomance")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Activist")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("AddresLive")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Age")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Class")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("DOB")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("From")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("HeadOfTheClass")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("HealthCategory")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("INN")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Invalid")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("OVZ")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("OVZGroup")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("PMail")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("PPhone")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Pasport")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("SNILS")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("SOP")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Sirota")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("SurName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Where")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("StudentsID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolNumber2.Teacher", b =>
                {
                    b.Property<int>("TeachersID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("INTEGER");

                    b.Property<string>("BaseClass")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("DPU")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("DPUHours")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("DopSpecItem")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("DopSpecItemHours")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("EducationSpecialization")
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Expirience")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("ExpirienceTeaching")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("GPDHours")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("HonorEmploy")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("KPK")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("PFDOT")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PFDOTHours")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("PrimaryOrSecondary")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("Rate")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("SpecItem")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("SpecItemHours")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Spicialization")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("TAdress")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("TAdressLive")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("TAge")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("TCategory")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("TDOB")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("TEducation")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("TINN")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("TMiddleName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("TName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("TPassport")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("TSNILS")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("TSurName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("YangSpicialist")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Сoefficient")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("TeachersID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("SchoolNumber2.TeacherRefresherCours", b =>
                {
                    b.Property<int>("CoursesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CoursDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("CoursHowMachYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DeadLineCours")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameCours")
                        .HasColumnType("TEXT");

                    b.Property<int>("SearchTeacherID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("marked")
                        .HasColumnType("INTEGER");

                    b.HasKey("CoursesID");

                    b.ToTable("TeacherCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
