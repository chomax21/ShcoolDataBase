using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SchoolNumber2
{
    public partial class ShowListDeadCoursForm : Form
    {
        public ShowListDeadCoursForm()
        {
            InitializeComponent();
        }

        private void ShowListDeadCoursForm_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolDB_Context())
            {
                var showResult = from t in db.Teachers
                                 join tc in db.TeacherRefresherCourses on t.TeachersID equals tc.SearchTeacherID
                                 where tc.CoursHowMachYear <= 182 // дней
                                 select new
                                 {
                                     ID = t.TeachersID,
                                     SName = t.TSurName,
                                     Name = t.TName,
                                     MName = t.TMiddleName,
                                     Course = tc.NameCours,
                                     CoursHowMachYear = tc.CoursHowMachYear,
                                     CoursDate = tc.CoursDate,
                                     DeadLineCours = tc.DeadLineCours
                                 };
                dgShowDeadCours.DataSource = showResult.ToList();
                ChangeColomnNames();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
        private void ChangeColomnNames()
        {

            dgShowDeadCours.Columns["ID"].Visible = false;
            dgShowDeadCours.Columns["Course"].HeaderText = "Название курса";
            dgShowDeadCours.Columns["Name"].HeaderText = "Имя";
            dgShowDeadCours.Columns["SName"].HeaderText = "Фамилия";
            dgShowDeadCours.Columns["MName"].HeaderText = "Отчество";
            dgShowDeadCours.Columns["CoursDate"].HeaderText = "Дата прохождения курса";
            dgShowDeadCours.Columns["DeadLineCours"].HeaderText = "Дата окончания курса";
            dgShowDeadCours.Columns["CoursHowMachYear"].HeaderText = "Окончание через (дней)";


        }

        private void ShowListDeadCoursForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
