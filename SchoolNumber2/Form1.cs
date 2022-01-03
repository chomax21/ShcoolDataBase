using System;
using System.Collections.Generic;
using System.Linq;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolDB_Context())
            {
                int sizeDbStudents = db.Students.Count();
                label1.Text = sizeDbStudents.ToString();

                int sizeDbTeachers = db.Teachers.Count();
                label2.Text = sizeDbTeachers.ToString();

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
    }
}
