using System;
using System.Linq;
using System.Windows.Forms;

namespace SchoolNumber2
{
    public partial class TeacherCoursForm : Form
        
    {
        private int TeacherId { get; set; }

        bool succes = false; // флаг для определения, пришел ли ID на эту форму с пришедшей формы.

        public TeacherCoursForm(Form3 form3)
        {
            InitializeComponent();
            if (form3.tbT_ID.Text != string.Empty) // Здесь приходит ID в виде строки из текстбокса.
            {
                TeacherId = Convert.ToInt32(form3.tbT_ID.Text);               
                tb_IDTeachCours.Text = TeacherId.ToString();
                succes = true;
            }
            
        }

        public TeacherCoursForm(ShowListDeadCoursForm form)
        {
            InitializeComponent(); // Здесь уже приходит ID в виде целого числа(int), поэтому если что-то не так будет отображаться нулевой ID. Дефолтный для int.
            TeacherId = form.searchID;
            tb_IDTeachCours.Text = TeacherId.ToString();
            if (tb_IDTeachCours.Text!=null)
            {
                succes = true; // Это здесь излишне, но для работы нужно.
            }            
        }

        private void EmptyTextboxs()
        {
            tb_IDTeachCours.Text = string.Empty;
            tb_NameTeachCours.Text = string.Empty;
        }

        private void TeacherCoursForm_Load(object sender, EventArgs e) // Отображем в датагриде списко курсов конкретного сотрудника по его ID, который пришел в конструктор этой формы из формы (БД сотрудников). 
        {
            if (succes) // Если флаг (правда) выполняем дальнейшие действи, отображаем курсы сотрудников...
            {
                ShowTeacherCours();
                ChangeColomnNames();
            }                       
        }

        private void button4_Click(object sender, EventArgs e) // Создаем новую запись о курсах для конкрутного сотрудника.
        {
            using (var db = new SchoolDB_Context())
            {
                var dateTimeCourseWhen = DateTime.Now;
                var dateTimeCourseDead = Convert.ToDateTime(dateTimeDeadLineCours.Value);
                TimeSpan resultTime = dateTimeCourseDead - dateTimeCourseWhen;

                var teacherCours = new TeacherRefresherCours()
                {
                    SearchTeacherID = TeacherId,
                    NameCours = tb_NameTeachCours.Text,
                    CoursDate = dateTimeTeachCours.Text,
                    DeadLineCours = dateTimeDeadLineCours.Text,
                    CoursHowMachYear = resultTime.Days,
                    marked = false
                    
                };
                db.TeacherRefresherCourses.Add(teacherCours);
                db.SaveChanges();
                ShowTeacherCours();
                EmptyTextboxs();
            }
        }

        private void button2_Click(object sender, EventArgs e)  // Редактируем запись курсов.
        {
            using (var db = new SchoolDB_Context())
            {
                var key = Convert.ToInt32(dgTeacherCours.SelectedCells[0].Value);
                var item = db.TeacherRefresherCourses.Find(key);
                if (item != null)
                {
                    var dateTimeCourseWhen = DateTime.Now;
                    var dateTimeCourseDead = Convert.ToDateTime(dateTimeDeadLineCours.Value);
                    TimeSpan resultTime = dateTimeCourseDead - dateTimeCourseWhen;
                    item.NameCours = tb_NameTeachCours.Text;
                    item.CoursDate = dateTimeTeachCours.Text;
                    item.DeadLineCours = dateTimeDeadLineCours.Text;
                    item.CoursHowMachYear = resultTime.Days;
                    item.marked = cbMark.Text == "Да" ? item.marked = true : item.marked = false;
                    db.SaveChanges();
                }
                ShowTeacherCours();
            }
            EmptyTextboxs();
        }

        private void button3_Click(object sender, EventArgs e) // Удаляем запись курсов.
        {
            if (MessageBox.Show("Вы точно хотите удалить запись? Данные будут утеряны! ",
               "Предупреждение!",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button2,
               MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                using (var db = new SchoolDB_Context())
                {
                    int key = Convert.ToInt32(dgTeacherCours.SelectedCells[0].Value);
                    var item = db.TeacherRefresherCourses.Find(key);
                    if (item != null)
                    {
                        db.TeacherRefresherCourses.Remove(item);
                        db.SaveChanges();                        
                    }
                    ShowTeacherCours();
                }
                EmptyTextboxs();
            }
        }

        private void ShowTeacherCours()
        {
            using (var db = new SchoolDB_Context())
            {
                var findCoursByID = from s in db.TeacherRefresherCourses
                                    where s.SearchTeacherID == TeacherId
                                    select s;
                dgTeacherCours.DataSource = findCoursByID.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dgTeacherCours_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (dgTeacherCours != null)
            {
                tb_IDTeachCours.Text = dgTeacherCours.SelectedCells[1].Value.ToString();
                tb_NameTeachCours.Text = dgTeacherCours.SelectedCells[2].Value.ToString();
                dateTimeTeachCours.Text = dgTeacherCours.SelectedCells[3].Value.ToString();
                dateTimeDeadLineCours.Text = dgTeacherCours.SelectedCells[4].Value.ToString();
                bool check = (bool)dgTeacherCours.SelectedCells[6].Value;
                if (check) cbMark.SelectedIndex = 0;
                else cbMark.SelectedIndex = 1;
            }
            
        }
        private void ChangeColomnNames()
        {
            dgTeacherCours.Columns["CoursesID"].Visible = false;
            dgTeacherCours.Columns["SearchTeacherID"].Visible = false;
            dgTeacherCours.Columns["NameCours"].HeaderText = "Название курса";
            dgTeacherCours.Columns["CoursDate"].HeaderText = "Дата прохождения курса";
            dgTeacherCours.Columns["DeadLineCours"].HeaderText = "Дата окончания курса";
            dgTeacherCours.Columns["CoursHowMachYear"].HeaderText = "Окончание через (дней)";
        }

        private void TeacherCoursForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var db = new SchoolDB_Context())
            {
                ShowTeacherCours();
            }
        }
    }
}
