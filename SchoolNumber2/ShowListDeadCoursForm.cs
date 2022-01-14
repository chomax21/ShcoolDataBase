using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SchoolNumber2
{
    public partial class ShowListDeadCoursForm : Form
    {
        public int filterDays { get; set; } = 182;
        public int searchID { get; set; }
        public bool markCours { get; set; }
        public ShowListDeadCoursForm()
        {
            InitializeComponent();
        }

        private void ShowListDeadCoursForm_Load(object sender, EventArgs e)
        {
            tbFilter.Text = filterDays.ToString();
            ShowList();
        }

        private void ShowList()
        {
            using (var db = new SchoolDB_Context())
            {
                var showResult = from t in db.Teachers
                                 join tc in db.TeacherRefresherCourses on t.TeachersID equals tc.SearchTeacherID
                                 where tc.CoursHowMachYear <= filterDays
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

        private void ShowListOnMark()
        {
            using (var db = new SchoolDB_Context())
            {
                var showResult = from t in db.Teachers
                                 join tc in db.TeacherRefresherCourses on t.TeachersID equals tc.SearchTeacherID
                                 where tc.CoursHowMachYear <= filterDays && tc.marked == markCours
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

            dgShowDeadCours.Columns["ID"].HeaderText = "ID сотрудника";
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

        private void button2_Click(object sender, EventArgs e)
        {
            filterDays = Convert.ToInt32(tbFilter.Text);
            if (cbMark.Text == "-")
            {
                ShowList();
            }
            else
            {
                markCours = cbMark.Text == "Да" ? true : false;
                ShowListOnMark();
                if (markCours) cbMark.SelectedIndex = 0;
                else cbMark.SelectedIndex = 1;
            }
           
        }

        private void dgShowDeadCours_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            searchID = (int)dgShowDeadCours.SelectedCells[0].Value;
            TeacherCoursForm form = new TeacherCoursForm(this);
            form.Show();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(label5, "Дополнительная сортировка по флагу. Если вы отметили для себя этот курс\n" +
                                       " то можете его скрыть в отображении для большего удобства.");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(button2,"Двойной щелчек по конкретному курсу перенесёт вас в\n" +
                                       " форму редактирование курсов данного сотрудника");
                                      
        }
    }
}
