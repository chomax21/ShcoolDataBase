using System.Collections.Generic;

namespace SchoolNumber2
{
    public class Teacher
    {
        public int TeachersID { get; set; }
        public string TSurName { get; set; }
        public string TName { get; set; }
        public string TMiddleName { get; set; }
        public string TDOB { get; set; }
        public string TAge { get; set; }
        public string TAdress { get; set; }
        public string TAdressLive { get; set; }
        public string TSNILS { get; set; }
        public string TINN { get; set; }
        public string TPassport { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string TEducation { get; set; } // Образование.
        public string EducationSpecialization { get; set; } // Специльность.
        public string Expirience { get; set; }
        public string ExpirienceTeaching { get; set; }
        public string Rate { get; set; } // Процентная ставка.
        public string Spicialization { get; set; } // Должность.
        public string SpecItem { get; set; } // Основной предмет.
        public string SpecItemHours { get; set; }
        public string DopSpecItem { get; set; } // Дополнительный предмет.
        public string DopSpecItemHours { get; set; }
        public string GPDHours { get; set; }
        public string DPU { get; set; }
        public string DPUHours { get; set; }
        public string PFDOT { get; set; }
        public string PFDOTHours { get; set; }
        public string TCategory { get; set; }
        public string HonorEmploy { get; set; } // Почетный работник.
        public string YangSpicialist { get; set; } // Молодой специалист.
        public string Сoefficient { get; set; } // Кооэфициент вредности.
        public string KPK { get; set; } // Курсы квалификации. Прописать дату.
        public string PrimaryOrSecondary { get; set; } // Основной работник или совместитель.
        public string BaseClass { get; set; }
    }
}
