using System.ComponentModel.DataAnnotations;

namespace SchoolNumber2
{
    public class TeacherRefresherCours
    {
        
        public int CoursesID { get; set; }
        [Display(Name = "ID сотрудника")]
        public int SearchTeacherID { get; set; }
        [Display(Name = "Название курса")]
        public string NameCours { get; set; }
        [Display(Name = "Дата прохождения курса")]
        public string CoursDate { get; set; }
        [Display(Name = "Дата окончания курса")]
        public string DeadLineCours { get; set; }
        [Display(Name = "Окончание через (дней)")]
        public int CoursHowMachYear { get; set; }
        [Display(Name="Отмечен")]
        public bool marked { get; set; }
    }
}
