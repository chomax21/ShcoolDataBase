using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolNumber2
{
     public class Student
    {        
        public int StudentsID { get; set; }
        public string Class { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }       
        public string MiddleName { get; set; }
        public string DOB { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string AddresLive { get; set; }
        public string SNILS { get; set; }
        public string INN { get; set; }
        public string Pasport { get; set; }
        public string PPhone { get; set; }
        public string PMail { get; set; }
        public string OVZ { get; set; } // ОВЗ. Нужно загуглить и прописать.
        public string OVZGroup { get; set; }
        public string Invalid { get; set; }
        public string Sirota { get; set; } // Сирота.
        public string SOP { get; set; }
        public string AcademicPerfomance { get; set; }
        public string Activist { get; set; }
        public string HeadOfTheClass { get; set; }
        public string HealthCategory { get; set; }          
        public string From { get; set; }
        public string Where { get; set; }        
    }
}
