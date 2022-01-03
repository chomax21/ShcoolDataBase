using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SchoolNumber2
{
    public partial class ShowClassForm : Form
    {
        public ShowClassForm()
        {
            InitializeComponent();
        }

        private void ShowClassForm_Load(object sender, EventArgs e)
        {

        }
        public void ChangeColomnName()
        {
            dgInfo.Columns["StudentsID"].Visible = false;
            dgInfo.Columns["FirstName"].HeaderText = "Имя";
            dgInfo.Columns["SurName"].HeaderText = "Фамилия";
            dgInfo.Columns["MiddleName"].HeaderText = "Отчество";
            dgInfo.Columns["Sex"].HeaderText = "Пол";
            dgInfo.Columns["DOB"].Visible = false;
            dgInfo.Columns["Class"].Visible = false;
            dgInfo.Columns["SNILS"].Visible = false;
            dgInfo.Columns["INN"].Visible = false;
            dgInfo.Columns["Pasport"].Visible = false;
            dgInfo.Columns["Address"].Visible = false;
            dgInfo.Columns["AddresLive"].Visible = false;
            dgInfo.Columns["From"].Visible = false;
            dgInfo.Columns["Where"].Visible = false;
            dgInfo.Columns["PPhone"].Visible = false;
            dgInfo.Columns["PMail"].Visible = false;
            dgInfo.Columns["Age"].HeaderText = "Возраст";
            dgInfo.Columns["OVZ"].Visible = false;
            dgInfo.Columns["OVZGroup"].Visible = false;
            dgInfo.Columns["Invalid"].Visible = false;
            dgInfo.Columns["Sirota"].Visible = false;
            dgInfo.Columns["SOP"].Visible = false;
            dgInfo.Columns["AcademicPerfomance"].HeaderText = "Успеваемость";
            dgInfo.Columns["Activist"].HeaderText = "Активист";
            dgInfo.Columns["HealthCategory"].Visible = false;
            dgInfo.Columns["HeadOfTheClass"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new SchoolDB_Context())
            {

                string resultChoice = comboBox1.Text + comboBox2.Text;

                var searchResult = from s in db.Students
                                   where s.Class == resultChoice
                                   select s;
                dgInfo.DataSource = searchResult.ToList();

                label14.Text = searchResult.Count().ToString();

                var boys = from b in searchResult
                           where b.Sex.Contains("муж")
                           select b;
                linkBoys.Text = boys.Count().ToString();

                var girls = from g in searchResult
                            where g.Sex.Contains("жен")
                            select g;
                linkGirls.Text = girls.Count().ToString();

                var perfomance = from p in searchResult
                                 where p.AcademicPerfomance.Contains("Отличник")
                                 select p;
                linkPeromance.Text = perfomance.Count().ToString();

                var badperfomance = from p in searchResult
                                    where p.AcademicPerfomance.Contains("Неуспевающий")
                                    select p;
                linkPef.Text = perfomance.Count().ToString();

                var invalid = from p in searchResult
                              where p.Invalid.Contains("Да")
                              select p;
                linkLabel3.Text = invalid.Count().ToString();

                var sop = from p in searchResult
                          where p.SOP.Contains("Да")
                          select p;
                linkLabel2.Text = sop.Count().ToString();

                var sirota = from p in searchResult
                             where p.Sirota.Contains("Да")
                             select p;
                linkLabel1.Text = sirota.Count().ToString();

                var activist = from p in searchResult
                               where p.Activist.Contains("Да")
                               select p;
                linkLabel9.Text = activist.Count().ToString();


                var ovz = from b in searchResult
                          where b.Class.Contains(comboBox1.Text + comboBox2.Text)
                          where b.OVZ.Contains("ТНР") || b.OVZ.Contains("ЗПР") || b.OVZ.Contains("НОДА") || b.OVZ.Contains("Аутист") || b.OVZ.Contains("ТНЗ") || b.OVZ.Contains("ТНС") || b.OVZ.Contains("Умственно отсталый")
                          select b;
                linkLabel8.Text = ovz.Count().ToString();

                var headClassSurName = from h in searchResult                       // Из результата поиска класс searhResult ищем учеников с заданным значением "Да"
                                       where h.HeadOfTheClass.Contains("Да")        // в поле "Староста класса".
                                       select h;

                foreach (var item in headClassSurName)
                {
                    string firstName = item.FirstName;
                    string secondName = item.SurName;
                    tbHeadClass.Text = secondName + " " + firstName;
                    tbPhoneHeadClass.Text = item.PPhone;
                }

                var mainTeacher = from t in db.Teachers                        // Ищем в бд учителей в ячейке BaseClass совпадения по выбранному классу(resultChoice)
                                  where t.BaseClass.Contains(resultChoice)     // найденного учителя выводим в datagridview1.
                                  select t;

                foreach (var item in mainTeacher)
                {
                    tbMainTeacher.Text = item.TSurName + " " + item.TName;
                    tbPhoneMainTeacher.Text = item.Phone;
                }
                ChangeColomnName();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e) // Ищется нужный ученик по щелчку по строке в datagridview и осуществляется его вывод в форму карточки ученика.
        {
            using (var db = new SchoolDB_Context())
            {
                if (dgInfo.Rows.Count >= 1)
                {
                    StudentCardForm cardForm = new StudentCardForm();
                    cardForm.Show();

                    var key = Convert.ToInt32(dgInfo.SelectedCells[0].Value);
                    var item = db.Students.Find(key);
                    if (item != null)
                    {
                        cardForm.lbAcademicPerf.Text = item.AcademicPerfomance;
                        cardForm.lbActivist.Text = item.Activist;
                        cardForm.lbAdress.Text = item.Address;
                        cardForm.lbAdressLive.Text = item.AddresLive;
                        cardForm.lbAge.Text = item.Age;
                        cardForm.lbClass.Text = item.Class;
                        cardForm.lbDOB.Text = item.DOB;
                        cardForm.lbFrom.Text = item.From;
                        cardForm.lbHeadClass.Text = item.HeadOfTheClass;
                        cardForm.lbHealthCategory.Text = item.HealthCategory;
                        cardForm.lbINN.Text = item.INN;
                        cardForm.lbSNILS.Text = item.SNILS;
                        cardForm.lbSOP.Text = item.SOP;
                        cardForm.lbSirota.Text = item.Sirota;
                        cardForm.lbSex.Text = item.Sex;
                        cardForm.lbPhone.Text = item.PPhone;
                        cardForm.lbPassport.Text = item.Pasport;
                        cardForm.lbOVZGroup.Text = item.OVZGroup;
                        cardForm.lbOVZ.Text = item.OVZ;
                        cardForm.lbName.Text = item.FirstName;
                        cardForm.lbMName.Text = item.MiddleName;
                        cardForm.lbMail.Text = item.PMail;
                        cardForm.lbIvalid.Text = item.Invalid;
                        cardForm.lbSName.Text = item.SurName;
                        cardForm.lb_ID.Text = item.StudentsID.ToString();
                    }
                }

            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void linkBoys_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkBoys.Text != "0")
            {
                using (var db = new SchoolDB_Context())
                {
                    var boysCount = from b in db.Students
                                    where b.Class.Contains(comboBox1.Text + comboBox2.Text)
                                    where b.Sex.Contains("муж")
                                    select b;
                    dgInfo.DataSource = boysCount.ToList();
                }
            }

        }

        private void linkPef_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkPef.Text != "0")
            {
                using (var db = new SchoolDB_Context())
                {
                    var badPerfomance = from b in db.Students
                                        where b.Class.Contains(comboBox1.Text + comboBox2.Text)
                                        where b.AcademicPerfomance.Contains("Неуспевающий")
                                        select b;
                    dgInfo.DataSource = badPerfomance.ToList();
                }
            }

        }

        private void linkPeromance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkPeromance.Text != "0")
            {
                using (var db = new SchoolDB_Context())
                {
                    var Perfomance = from b in db.Students
                                     where b.Class.Contains(comboBox1.Text + comboBox2.Text)
                                     where b.AcademicPerfomance.Contains("Отличник")
                                     select b;
                    dgInfo.DataSource = Perfomance.ToList();
                }
            }

        }

        private void linkGirls_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkGirls.Text != "0")
            {
                using (var db = new SchoolDB_Context())
                {
                    var girlsCount = from b in db.Students
                                     where b.Class.Contains(comboBox1.Text + comboBox2.Text)
                                     where b.Sex.Contains("жен")
                                     select b;
                    dgInfo.DataSource = girlsCount.ToList();
                }

            }

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (linkLabel8.Text != "0")
            {
                using (var db = new SchoolDB_Context())
                {
                    var OVZCategory = from b in db.Students
                                      where b.Class.Contains(comboBox1.Text + comboBox2.Text)
                                      where b.OVZ.Contains("ТНР") || b.OVZ.Contains("ЗПР") || b.OVZ.Contains("НОДА") || b.OVZ.Contains("Аутист") || b.OVZ.Contains("ТНЗ") || b.OVZ.Contains("ТНС") || b.OVZ.Contains("Умственно отсталый")
                                      select b;
                    dgInfo.DataSource = OVZCategory.ToList();
                }

            }
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel9.Text != "0")
            {
                using (var db = new SchoolDB_Context())
                {
                    var activist = from b in db.Students
                                   where b.Class.Contains(comboBox1.Text + comboBox2.Text)
                                   where b.Activist.Contains("Да")
                                   select b;
                    dgInfo.DataSource = activist.ToList();
                }

            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel3.Text != "0")
            {
                using (var db = new SchoolDB_Context())
                {
                    var invalid = from b in db.Students
                                  where b.Class.Contains(comboBox1.Text + comboBox2.Text)
                                  where b.Invalid.Contains("Да")
                                  select b;
                    dgInfo.DataSource = invalid.ToList();
                }

            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (linkLabel2.Text != "0")
            {
                using (var db = new SchoolDB_Context())
                {
                    var SOP = from b in db.Students
                              where b.Class.Contains(comboBox1.Text + comboBox2.Text)
                              where b.SOP.Contains("Да")
                              select b;
                    dgInfo.DataSource = SOP.ToList();
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (linkLabel1.Text != "0")
            {
                using (var db = new SchoolDB_Context())
                {
                    var sirota = from b in db.Students
                                 where b.Class.Contains(comboBox1.Text + comboBox2.Text)
                                 where b.Sirota.Contains("Да")
                                 select b;
                    dgInfo.DataSource = sirota.ToList();
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExcelPrint.PrintDataGridToExel(dgInfo, saveFileDialog1);
        }

        private void ShowClassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
