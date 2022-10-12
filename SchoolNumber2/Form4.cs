using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SchoolNumber2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (var db = new SchoolDB_Context())
            {
                dgArchStudents.DataSource = db.ArchiveOfStudents.ToList();
            }
            ChangeColomnNames();
            ShowCountRows();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ArchTb_ID.Text == "")
            {
                MessageBox.Show("Нужно выбрать запись!", "Внимание!", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Вы точно хотите удалить запись? Данные будут утеряны!",
               "Предупреждение!",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button2,
               MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                {
                    using (var db = new SchoolDB_Context())
                    {
                        int key = Convert.ToInt32(ArchTb_ID.Text);
                        var item = db.ArchiveOfStudents.Find(key);
                        if (item != null)
                        {
                            db.ArchiveOfStudents.Remove(item);
                            db.SaveChanges();
                            dgArchStudents.DataSource = db.ArchiveOfStudents.ToList();
                        }
                    }
                }
            }
            ShowCountRows();
        }

        private void dgArchStudents_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ArchTb_ID.Text = dgArchStudents.SelectedCells[0].Value.ToString();
                tbAClass.Text = dgArchStudents.SelectedCells[1].Value.ToString();
                tbASName.Text = dgArchStudents.SelectedCells[2].Value.ToString();
                tbAName.Text = dgArchStudents.SelectedCells[3].Value.ToString();
                tbAMName.Text = dgArchStudents.SelectedCells[4].Value.ToString();
                tbAFrom.Text = dgArchStudents.SelectedCells[24].Value.ToString();
                tbAWhere.Text = dgArchStudents.SelectedCells[25].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка! Данных нет!", "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        private void ChangeColomnNames() // Переименовка столбцов в DataGrid.
        {
            dgArchStudents.Columns["ArchStudentsID"].HeaderText = "ID_Ученика";
            dgArchStudents.Columns["FirstName"].HeaderText = "Имя";
            dgArchStudents.Columns["SurName"].HeaderText = "Фамилия";
            dgArchStudents.Columns["MiddleName"].HeaderText = "Отчество";
            dgArchStudents.Columns["Sex"].HeaderText = "Пол";
            dgArchStudents.Columns["DOB"].HeaderText = "Дата рождения";
            dgArchStudents.Columns["Class"].HeaderText = "Класс";
            dgArchStudents.Columns["SNILS"].HeaderText = "СНИЛС";
            dgArchStudents.Columns["INN"].HeaderText = "ИНН";
            dgArchStudents.Columns["Pasport"].HeaderText = "Паспорт/Св.оРождении";
            dgArchStudents.Columns["Address"].HeaderText = "Адрес регистрации";
            dgArchStudents.Columns["AddresLive"].HeaderText = "Адрес проживания";
            dgArchStudents.Columns["From"].HeaderText = "Прибыл";
            dgArchStudents.Columns["Where"].HeaderText = "Убыл";
            dgArchStudents.Columns["PPhone"].HeaderText = "Телефон Родителей";
            dgArchStudents.Columns["PMail"].HeaderText = "Почта Родителей";
            dgArchStudents.Columns["Age"].HeaderText = "Возраст";
            dgArchStudents.Columns["OVZ"].HeaderText = "ОВЗ";
            dgArchStudents.Columns["OVZGroup"].HeaderText = "Группа ОВЗ";
            dgArchStudents.Columns["Invalid"].HeaderText = "Инвалид";
            dgArchStudents.Columns["Sirota"].HeaderText = "Сирота";
            dgArchStudents.Columns["SOP"].HeaderText = "СОП";
            dgArchStudents.Columns["AcademicPerfomance"].HeaderText = "Успеваемость";
            dgArchStudents.Columns["Activist"].HeaderText = "Активист";
            dgArchStudents.Columns["HealthCategory"].HeaderText = "Группа здоровья";
            dgArchStudents.Columns["HeadOfTheClass"].HeaderText = "Староста класса";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var db = new SchoolDB_Context())
            {
                var students = from s in db.ArchiveOfStudents
                               where s.FirstName.Contains(tbAName.Text)
                               where s.SurName.Contains(tbASName.Text)
                               where s.MiddleName.Contains(tbAMName.Text)
                               where s.Class.Contains(tbAClass.Text)
                               where s.Where.Contains(tbAWhere.Text)
                               where s.Where.Contains(tbAFrom.Text)
                               select s;
                dgArchStudents.DataSource = students.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExcelPrint.PrintDataGridToExel(dgArchStudents, saveFileDialog1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var db = new SchoolDB_Context())
            {
                dgArchStudents.DataSource = db.ArchiveOfStudents.ToList();
            }
            ShowCountRows();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbAClass.Text = string.Empty;
            tbAFrom.Text = string.Empty;
            tbAMName.Text = string.Empty;
            tbAName.Text = string.Empty;
            tbASName.Text = string.Empty;
            tbAWhere.Text = string.Empty;
            ArchTb_ID.Text = string.Empty;
            ShowCountRows();
        }

        private void AllGoBackToDataBase() // Метод для переноса на основу ВСЕХ отображенных учеников.
        {
            using (var db = new SchoolDB_Context())
            {
                for (int i = 0; i < dgArchStudents.Rows.Count; i++)
                {

                    var key = Convert.ToInt32(dgArchStudents[0, i].Value);  //dgStudents[0,i].Value
                    var item = db.ArchiveOfStudents.Find(key);

                    var Student = new Student()
                    {
                        Address = item.Address,
                        Age = item.Age,
                        StudentsID = item.ArchStudentsID,
                        OVZ = item.OVZ,
                        Class = item.Class,
                        DOB = item.DOB,
                        FirstName = item.FirstName,
                        SurName = item.SurName,
                        MiddleName = item.MiddleName,
                        INN = item.INN,
                        From = "Восстановлен " + dateTimePicker1.Text + " | " + tbNumberOfOrderArch.Text + " | " + item.From,
                        Where = "",
                        Pasport = item.Pasport,
                        SNILS = item.SNILS,
                        Sex = item.Sex,
                        PMail = item.PMail,
                        PPhone = item.PPhone,
                        AcademicPerfomance = item.AcademicPerfomance,
                        Activist = item.Activist,
                        AddresLive = item.AddresLive,
                        HealthCategory = item.HealthCategory,
                        Invalid = item.Invalid,
                        Sirota = item.Sirota,
                        OVZGroup = item.OVZGroup,
                        SOP = item.SOP
                    };
                    db.ArchiveOfStudents.Remove(item);
                    db.Students.Add(Student);
                    db.SaveChanges();
                }
                dgArchStudents.DataSource = db.ArchiveOfStudents.ToList();
            }
        }
        private void SelectArchStudentGoToDataBase() // Метод для переноса на основу ОДНОГО отображенных учеников.
        {
            using (var db = new SchoolDB_Context())
            {

                    var key = Convert.ToInt32(dgArchStudents.SelectedCells[0].Value);
                    var item = db.ArchiveOfStudents.Find(key);


                    var student = new Student()
                    {
                        Address = item.Address,
                        Age = item.Age,
                        StudentsID = item.ArchStudentsID,
                        OVZ = item.OVZ,
                        Class = item.Class,
                        DOB = item.DOB,
                        FirstName = item.FirstName,
                        SurName = item.SurName,
                        MiddleName = item.MiddleName,
                        INN = item.INN,
                        From = "Восстановлен " + dateTimePicker1.Text + " | " + tbNumberOfOrderArch.Text + " | " + item.From,
                        Where = string.Empty,
                        Pasport = item.Pasport,
                        SNILS = item.SNILS,
                        Sex = item.Sex,
                        PMail = item.PMail,
                        PPhone = item.PPhone,
                        AcademicPerfomance = item.AcademicPerfomance,
                        Activist = item.Activist,
                        AddresLive = item.AddresLive,
                        HealthCategory = item.HealthCategory,
                        Invalid = item.Invalid,
                        Sirota = item.Sirota,
                        OVZGroup = item.OVZGroup,
                        SOP = item.SOP
                    };
                    db.ArchiveOfStudents.Remove(item);
                    db.Students.Add(student);
                    db.SaveChanges();
                
                dgArchStudents.DataSource = db.ArchiveOfStudents.ToList();
                Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                MessageBox.Show("Нужно выбрать только один тип восстановления!", "Внимание!");
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Нужно выбрать один тип восстановления!", "Внимание!");
            }
            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                if (tbNumberOfOrderArch.Text != string.Empty)
                {
                    SelectArchStudentGoToDataBase();
                }
                else
                {
                    MessageBox.Show("Введите номер приказа!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
            if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                if (tbNumberOfOrderArch.Text != string.Empty)
                {
                    AllGoBackToDataBase();
                }
                else
                {
                    MessageBox.Show("Введите номер приказа!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            ShowCountRows();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void ArchTb_ID_TextChanged(object sender, EventArgs e)
        {

        }
        public void ShowCountRows()
        {
            textBox1.Text = dgArchStudents.Rows.Count.ToString();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }
    }
}
