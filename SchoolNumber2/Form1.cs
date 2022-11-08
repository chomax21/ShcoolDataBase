using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolNumber2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassForm passForm = new ChangePassForm();
            passForm.Show();
            Hide();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolDB_Context())
            {
                int sizeDbStudents = db.Students.Count(); // Сколько учеников в базе данных
                label1.Text = sizeDbStudents.ToString();

                int sizeDbTeachers = db.Teachers.Count(); // Сколько сотрудников в базе данных
                label2.Text = sizeDbTeachers.ToString();
            }

            await Task.Run(() => SearchDeadListTeacherCours());
            await Task.Run(() => StudentAgeCalculating()); // При каждом запуске в теории происходит перерасчет возраста учеников на момент старта приложения с дальнейшим сохраненим в бд.   
            await Task.Run(() => TeacherAgeCalculating()); // То же самое, что и выше только для сотрудников.  

            // Сделать вывод ИД курсов для последующего вывода сотрудников чьи курсы просроченны или скоро закончатся.
            // С помощью Join LINQ

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowClassForm form = new ShowClassForm();
            form.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowListDeadCoursForm form = new ShowListDeadCoursForm();
            form.Show();
            Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void StudentAgeCalculating()
        {
            using (var db = new SchoolDB_Context())
            {
                var ageCalculation = from s in db.Students
                                     select s;
                if (ageCalculation != null)
                {
                    foreach (var item in ageCalculation)
                    {
                        DateTime time1 = Convert.ToDateTime(item.DOB); // Происходит вычисление возраста на текущий момент.
                        DateTime time2 = DateTime.Now;
                        int timeResult = (time2 - time1).Days;
                        int timeResult2 = timeResult / 365;

                        if (Convert.ToInt32(item.Age) != timeResult2)
                        {
                            item.Age = timeResult2.ToString();
                        }
                        db.SaveChanges();
                    }

                }

            }
        }

        private void TeacherAgeCalculating()
        {
            using (var db = new SchoolDB_Context())
            {
                var ageCalculation = from s in db.Teachers
                                     select s;
                if (ageCalculation != null)
                {
                    foreach (var item in ageCalculation)
                    {
                        DateTime time1 = Convert.ToDateTime(item.TDOB); // Происходит вычисление возраста на текущий момент.
                        DateTime time2 = DateTime.Now;
                        int timeResult = (time2 - time1).Days;
                        int timeResult2 = timeResult / 365;

                        if (Convert.ToInt32(item.TAge) != timeResult2)
                        {
                            item.TAge = timeResult2.ToString();
                        }
                        db.SaveChanges();
                    }

                }

            }

        }

        private void SearchDeadListTeacherCours() // Пересчет оставшихся дней до окончания курсов учителей
        {
            using (var db = new SchoolDB_Context())
            {
                var searchDeadLineCours = from s in db.TeacherRefresherCourses
                                          select s;
                foreach (var item in searchDeadLineCours)
                {
                    var dateTimeCourseWhen = DateTime.Now;
                    var dateTimeCourseDead = Convert.ToDateTime(item.DeadLineCours);
                    TimeSpan resultTime = dateTimeCourseDead - dateTimeCourseWhen;

                    var key = Convert.ToInt32(item.CoursesID);
                    var result = db.TeacherRefresherCourses.Find(key);
                    if (result != null)
                    {
                        result.CoursHowMachYear = resultTime.Days;
                        db.SaveChanges();
                    };
                }
            }
        }
    }
}

