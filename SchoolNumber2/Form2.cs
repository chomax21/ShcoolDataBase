using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolNumber2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void GetCountStudentsInDataBase() // Подсчет учеников отображаемых в Базе данных.
        {
            using (var db = new SchoolDB_Context())
            {
                textBox1.Text = dgStudents.RowCount.ToString();
            }

        }

        public void ResetField() // Сбрасываем показание полей.
        {
            tb_ID.Text = string.Empty;
            tbName.Text = string.Empty;
            tbSName.Text = string.Empty;
            tbMName.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            tbClass.Text = string.Empty;
            tbSNILS.Text = string.Empty;
            tbINN.Text = string.Empty;
            tbPasport.Text = string.Empty;
            tbAddress.Text = string.Empty;
            tbFrom.Text = string.Empty;
            tbWhere.Text = string.Empty;
            tbPPhone.Text = string.Empty;
            tbPEmail.Text = string.Empty;
            tbAge.Text = string.Empty;
            cbOVZ.Text = string.Empty;
            cbSex.Text = string.Empty;
            cbAcadPerfm.Text = string.Empty;
            cbActivist.Text = string.Empty;
            cbGroupHealth.Text = string.Empty;
            cbInvalid.Text = string.Empty;
            cbOVZGroup.Text = string.Empty;
            cbSirota.Text = string.Empty;
            cbSOP.Text = string.Empty;
            cbHeadClass.Text = string.Empty;
            tbAdressLive.Text = string.Empty;
        }

        private void ChangeColomnNames() // Переименовка столбцов в DataGrid.
        {
            dgStudents.Columns["StudentsID"].HeaderText = "ID_Ученика";
            dgStudents.Columns["FirstName"].HeaderText = "Имя";
            dgStudents.Columns["SurName"].HeaderText = "Фамилия";
            dgStudents.Columns["MiddleName"].HeaderText = "Отчество";
            dgStudents.Columns["Sex"].HeaderText = "Пол";
            dgStudents.Columns["DOB"].HeaderText = "Дата рождения";
            dgStudents.Columns["Class"].HeaderText = "Класс";
            dgStudents.Columns["SNILS"].HeaderText = "СНИЛС";
            dgStudents.Columns["INN"].HeaderText = "ИНН";
            dgStudents.Columns["Pasport"].HeaderText = "Паспорт/Св.оРождении";
            dgStudents.Columns["Address"].HeaderText = "Адрес регистрации";
            dgStudents.Columns["AddresLive"].HeaderText = "Адрес проживания";
            dgStudents.Columns["From"].HeaderText = "Прибыл";
            dgStudents.Columns["Where"].HeaderText = "Убыл";
            dgStudents.Columns["PPhone"].HeaderText = "Телефон Родителей";
            dgStudents.Columns["PMail"].HeaderText = "Почта Родителей";
            dgStudents.Columns["Age"].HeaderText = "Возраст";
            dgStudents.Columns["OVZ"].HeaderText = "ОВЗ";
            dgStudents.Columns["OVZGroup"].HeaderText = "Группа ОВЗ";
            dgStudents.Columns["Invalid"].HeaderText = "Инвалид";
            dgStudents.Columns["Sirota"].HeaderText = "Сирота";
            dgStudents.Columns["SOP"].HeaderText = "СОП";
            dgStudents.Columns["AcademicPerfomance"].HeaderText = "Успеваемость";
            dgStudents.Columns["Activist"].HeaderText = "Активист";
            dgStudents.Columns["HealthCategory"].HeaderText = "Группа здоровья";
            dgStudents.Columns["HeadOfTheClass"].HeaderText = "Староста";


        }

        private void Form2_Load(object sender, EventArgs e)  // Загружается форма учеников, проверяем отображается ли БД, если нет выводим данные с БД в датагрид,
                                                             // далее переименование столбцов.
        {
            using (var db = new SchoolDB_Context())
            {

                if (dgStudents != null)
                {
                    dgStudents.DataSource = db.Students.ToList();
                    ChangeColomnNames();
                    GetCountStudentsInDataBase();
                }
            }


        }

        private void button4_Click(object sender, EventArgs e) // Форма ушла, пришла форма.
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)   // Кнопка добавления учеников в БД.
        {
            using (var db = new SchoolDB_Context())
            {
                DateTime time1 = dateTimePicker1.Value; // Происходит вычисление возраста на текущий момент.
                DateTime time2 = DateTime.Now;
                int timeResult = (time2 - time1).Days;
                int timeResult2 = timeResult / 365;

                var student1 = new Student()
                {
                    FirstName = tbName.Text,
                    SurName = tbSName.Text,
                    MiddleName = tbMName.Text,
                    Sex = cbSex.Text,
                    DOB = dateTimePicker1.Text,
                    Age = timeResult2.ToString(),
                    OVZ = cbOVZ.Text,
                    OVZGroup = cbOVZGroup.Text,
                    AcademicPerfomance = cbAcadPerfm.Text,
                    Activist = cbActivist.Text,
                    HealthCategory = cbGroupHealth.Text,
                    AddresLive = tbAdressLive.Text,
                    Sirota = cbSirota.Text,
                    Invalid = cbInvalid.Text,
                    SOP = cbSOP.Text,
                    Class = tbClass.Text,
                    SNILS = tbSNILS.Text,
                    INN = tbINN.Text,
                    Pasport = tbPasport.Text,
                    Address = tbAddress.Text,
                    From = tbFrom.Text + " | " + dateTimePicker2.Text,
                    Where = tbWhere.Text,
                    PPhone = tbPPhone.Text,
                    PMail = tbPEmail.Text

                };

                db.Students.Add(student1);
                db.SaveChanges();
                dgStudents.DataSource = db.Students.ToList();
                ChangeColomnNames();
                GetCountStudentsInDataBase();
                ResetField();
            }
        }
        private void button2_Click(object sender, EventArgs e)  // Поиск и сортировка
        {
            using (var db = new SchoolDB_Context())
            {
                var students = from s in db.Students
                               where s.Class.StartsWith(tbClass.Text)
                               where s.FirstName.Contains(tbName.Text)
                               where s.MiddleName.Contains(tbMName.Text)
                               where s.SurName.Contains(tbSName.Text)
                               where s.OVZ.Contains(cbOVZ.Text)
                               where s.Sex.Contains(cbSex.Text)
                               where s.From.Contains(tbFrom.Text)
                               where s.HeadOfTheClass.Contains(cbHeadClass.Text)
                               where s.HealthCategory.Contains(cbGroupHealth.Text)
                               where s.Sirota.Contains(cbSirota.Text)
                               where s.AcademicPerfomance.Contains(cbAcadPerfm.Text)
                               where s.Invalid.Contains(cbInvalid.Text)
                               where s.Age.Contains(tbAge.Text)
                               where s.PPhone.Contains(tbPPhone.Text)
                               select s;
                dgStudents.DataSource = students.ToList();

            };
            GetCountStudentsInDataBase();
        }

        private void button3_Click(object sender, EventArgs e) // Удаление.
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
                    int key = Convert.ToInt32(tb_ID.Text);
                    var item = db.Students.Find(key);
                    if (item != null)
                    {
                        db.Students.Remove(item);
                        db.SaveChanges();
                        dgStudents.DataSource = db.Students.ToList();
                    }
                }
            }

            GetCountStudentsInDataBase();
            ResetField();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)  // Выделяем и заполняем Текстбоксы.
        {
            try
            {
                tb_ID.Text = dgStudents.SelectedCells[0].Value.ToString();
                tbClass.Text = dgStudents.SelectedCells[1].Value.ToString();
                tbSName.Text = dgStudents.SelectedCells[2].Value.ToString();
                tbName.Text = dgStudents.SelectedCells[3].Value.ToString();
                tbMName.Text = dgStudents.SelectedCells[4].Value.ToString();
                dateTimePicker1.Text = dgStudents.SelectedCells[5].Value.ToString();
                tbAge.Text = dgStudents.SelectedCells[6].Value.ToString();
                if (dgStudents.SelectedCells[7].Value != null)
                    cbSex.Text = dgStudents.SelectedCells[7].Value.ToString();
                else
                    cbSex.Text = "";

                tbAddress.Text = dgStudents.SelectedCells[8].Value.ToString();
                tbAdressLive.Text = dgStudents.SelectedCells[9].Value.ToString();
                tbSNILS.Text = dgStudents.SelectedCells[10].Value.ToString();
                tbINN.Text = dgStudents.SelectedCells[11].Value.ToString();
                tbPasport.Text = dgStudents.SelectedCells[12].Value.ToString();
                tbPPhone.Text = dgStudents.SelectedCells[13].Value.ToString();
                tbPEmail.Text = dgStudents.SelectedCells[14].Value.ToString();
                if (dgStudents.SelectedCells[15].Value != null)
                    cbOVZ.Text = dgStudents.SelectedCells[15].Value.ToString();
                else
                    cbOVZ.Text = "";

                if (dgStudents.SelectedCells[16].Value != null)
                    cbOVZGroup.Text = dgStudents.SelectedCells[16].Value.ToString();
                else
                    cbOVZGroup.Text = "";

                if (dgStudents.SelectedCells[17].Value != null)
                    cbInvalid.Text = dgStudents.SelectedCells[17].Value.ToString();
                else
                    cbInvalid.Text = "";

                if (dgStudents.SelectedCells[18].Value != null)
                    cbSirota.Text = dgStudents.SelectedCells[18].Value.ToString();
                else
                    cbSirota.Text = "";

                if (dgStudents.SelectedCells[19].Value != null)
                    cbSOP.Text = dgStudents.SelectedCells[19].Value.ToString();
                else
                    cbSOP.Text = "";

                if (dgStudents.SelectedCells[20].Value != null)
                    cbAcadPerfm.Text = dgStudents.SelectedCells[20].Value.ToString();
                else
                    cbAcadPerfm.Text = "";

                if (dgStudents.SelectedCells[21].Value != null)
                    cbActivist.Text = dgStudents.SelectedCells[21].Value.ToString();
                else
                    cbActivist.Text = "";

                if (dgStudents.SelectedCells[22].Value != null)
                    cbHeadClass.Text = dgStudents.SelectedCells[22].Value.ToString();
                else
                    cbHeadClass.Text = "";

                if (dgStudents.SelectedCells[23].Value != null)
                    cbGroupHealth.Text = dgStudents.SelectedCells[23].Value.ToString();
                else
                    cbGroupHealth.Text = "";

                tbFrom.Text = dgStudents.SelectedCells[24].Value.ToString();
                tbWhere.Text = dgStudents.SelectedCells[25].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Данных нет!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void button6_Click(object sender, EventArgs e) // Сброс по кнопке.
        {
            ResetField();
            GetCountStudentsInDataBase();
        }

        private void button5_Click(object sender, EventArgs e) // Редактируем БД.
        {
            using (var db = new SchoolDB_Context())
            {
                DateTime time1 = dateTimePicker1.Value;
                DateTime time2 = DateTime.Now;
                int timeResult = (time2 - time1).Days;
                int timeResult2 = timeResult / 365;

                var key = Convert.ToInt32(tb_ID.Text);
                var item = db.Students.Find(key);

                if (item != null)
                {
                    item.FirstName = tbName.Text;
                    item.SurName = tbSName.Text;
                    item.MiddleName = tbMName.Text;
                    item.Sex = cbSex.Text;
                    item.DOB = dateTimePicker1.Text;
                    item.Age = timeResult2.ToString();
                    item.OVZ = cbOVZ.Text;
                    item.Class = tbClass.Text;
                    item.SNILS = tbSNILS.Text;
                    item.INN = tbINN.Text;
                    item.Pasport = tbPasport.Text;
                    item.Address = tbAddress.Text;
                    item.AddresLive = tbAdressLive.Text;
                    item.OVZGroup = cbOVZGroup.Text;
                    item.Sirota = cbSirota.Text;
                    item.HealthCategory = cbGroupHealth.Text;
                    item.SOP = cbSOP.Text;
                    item.AcademicPerfomance = cbAcadPerfm.Text;
                    item.Invalid = cbInvalid.Text;
                    item.From = tbFrom.Text;
                    item.PPhone = tbPPhone.Text;
                    item.PMail = tbPEmail.Text;
                    item.Activist = cbActivist.Text;
                    item.HeadOfTheClass = cbHeadClass.Text;
                    db.SaveChanges();
                    dgStudents.DataSource = db.Students.ToList();
                }
            };
            GetCountStudentsInDataBase();
            ResetField();
        }

        private void Form2_MouseDoubleClick(object sender, MouseEventArgs e) // Сброс по двойному щелчку.
        {
            ResetField();
            GetCountStudentsInDataBase();
        }

        private void button7_Click(object sender, EventArgs e) // Обновить.
        {
            using (var db = new SchoolDB_Context())
            {
                dgStudents.DataSource = db.Students.ToList();
            }
            GetCountStudentsInDataBase();
            ResetField();
        }

        private async void button8_Click(object sender, EventArgs e)  // Экспорт в WORD.
        {
            try
            {
                var wprint = new WordPrint("Doc1.docx");

                var items = new Dictionary<string, string>
                {
                {"<NAME>", tbName.Text },
                {"<SURNAME>", tbSName.Text },
                {"<MIDDLENAME>", tbMName.Text },
                {"<SEX>", cbSex.Text },
                {"<DOB>", dateTimePicker1.Text },
                {"<AGE>" , tbAge.Text },
                {"<CATEGORY>" , cbOVZ.Text },
                {"<CLASS>", tbClass.Text },
                {"<SNILS>", tbSNILS.Text },
                {"<INN>", tbINN.Text },
                {"<PASPORT>", tbPasport.Text },
                {"<ADDRESS>", tbAddress.Text },
                {"<ADDRESSLIVE>", tbAdressLive.Text },
                {"<FROM>", tbFrom.Text },
                {"<PPHONE>", tbPPhone.Text },
                {"<PMAIL>", tbPEmail.Text },
                {"<OVZ>", cbOVZ.Text },
                {"<OVZGROUP>", cbOVZGroup.Text },
                {"<INVALID>", cbInvalid.Text },
                {"<SOP>", cbSOP.Text },
                {"<ACADEMICPERFOMANCE>", cbAcadPerfm.Text },
                {"<ACTIVIST>", cbActivist.Text },
                {"<HEADOFTHECLASS>", cbHeadClass.Text },
                {"<HEALTHCATEGORY>", cbGroupHealth.Text },
                {"<SIROTA>", cbSirota.Text }
                };

                await Task.Run(() => wprint.Process(items));
                 //wprint.Process(items);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        public void button9_Click(object sender, EventArgs e) // Экспорт в Exel.
        {
            ExcelPrint.PrintDataGridToExel(dgStudents, sFDialog);
        }

        private void button1_Click_1(object sender, EventArgs e) // Кнопка вызова панели для переноса учеников в архив.
        {
            MessageBox.Show("Внимание будьте внимательны! При переносе \n" +
                            "одного ученика переносится выбранный ученик \n" +
                            "в таблице. При переносе всех, переносятся все \n" +
                            "отображенные ученики. Можно выполнить сортировку \n" +
                            "через поиск для создания нужной категории.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panel1.Visible = true;
            panel1.BringToFront();
        }

        private void button9_Click_1(object sender, EventArgs e) // Отобразить архив.
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button10_Click(object sender, EventArgs e) // Переводим всех на год вперед. 11 и 9 Класс уходит в архив.
        {
            if (MessageBox.Show("Внимание! Вы собираетесь перевести всех учеников на год вперед! 11 и 9 классы уходят в архив! Продолжить?", "Внимание!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                using (var db = new SchoolDB_Context())
                {
                    var nextyear = from n in db.Students
                                   where n.Class.Contains("11") || n.Class.Contains("9")
                                   select n;

                    foreach (var item in nextyear)
                    {
                        var archtsudent = new ArchiveOfStudent
                        {
                            Address = item.Address,
                            Age = item.Age,
                            ArchStudentsID = item.StudentsID,
                            OVZ = item.OVZ,
                            Class = item.Class,
                            DOB = item.DOB,
                            FirstName = item.FirstName,
                            SurName = item.SurName,
                            MiddleName = item.MiddleName,
                            INN = item.INN,
                            From = item.From,
                            Where = item.Where,
                            Pasport = item.Pasport,
                            SNILS = item.SNILS,
                            Sex = item.Sex,
                            PMail = item.PMail,
                            PPhone = item.PPhone,
                            AcademicPerfomance = item.AcademicPerfomance,
                            Activist = item.Activist,
                            HeadOfTheClass = item.HeadOfTheClass,
                            AddresLive = item.AddresLive,
                            HealthCategory = item.HealthCategory,
                            Invalid = item.Invalid,
                            Sirota = item.Sirota,
                            OVZGroup = item.OVZGroup,
                            SOP = item.SOP
                        };
                        db.Students.Remove(item);
                        db.ArchiveOfStudents.Add(archtsudent);
                        db.SaveChanges();
                    }

                    var _nextyear = from s in db.Students
                                    select s;

                    foreach (var item in _nextyear)
                    {
                        string stringCountClassResult = Regex.Replace(item.Class, @"[^А-Я]+", string.Empty);
                        string countClass = item.Class;

                        string intCountClassResult = string.Empty;
                        int val = 0;
                        for (int i = 0; i < countClass.Length; i++)
                        {
                            if (Char.IsDigit(countClass[i]))
                            {
                                intCountClassResult += countClass[i];
                            }
                        }
                        if (intCountClassResult.Length > 0)
                        {
                            val = int.Parse(intCountClassResult);
                        }
                        val++;

                        item.Class = (val + stringCountClassResult).ToString();
                        db.SaveChanges();
                        dgStudents.DataSource = db.Students.ToList();
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // Чекбокс и кнопка. Определят виден ли дополнительный dateTimePicker для подсчета возраста с заданого времени.
        {
            if (checkBox2.Checked == true)
            {
                dateTimePicker4.Visible = true;
                button11.Visible = true;

            }
            else
            {
                dateTimePicker4.Visible = false;
                button11.Visible = false;
            }
        }

        private void button11_Click(object sender, EventArgs e) // Кнопка выполнения и отображения подсчета возраста с заданого времени.
        {
            for (int i = 0; i < dgStudents.Rows.Count; i++)
            {
                DateTime time1 = Convert.ToDateTime(dgStudents[5, i].Value.ToString());
                DateTime time2 = dateTimePicker4.Value;
                int timeResult = (time2 - time1).Days;
                int timeResult2 = timeResult / 365;
                dgStudents[6, i].Value = timeResult2.ToString();
            }
        }

        private void AllGoTOoArchive() // Метод для переноса в архив ВСЕХ отображенных учеников.
        {
            using (var db = new SchoolDB_Context())
            {
                for (int i = 0; i < dgStudents.Rows.Count; i++)
                {

                    var key = Convert.ToInt32(dgStudents[0, i].Value);  //dgStudents[0,i].Value

                    var item = db.Students.Find(key);

                    var ArchStudetn = new ArchiveOfStudent()
                    {
                        Address = item.Address,
                        Age = item.Age,
                        ArchStudentsID = item.StudentsID,
                        OVZ = item.OVZ,
                        Class = item.Class,
                        DOB = item.DOB,
                        FirstName = item.FirstName,
                        SurName = item.SurName,
                        MiddleName = item.MiddleName,
                        INN = item.INN,
                        From = item.From,
                        Where = DateTime.Today.ToString("dd/MM/yyyy") + " | " + tbNumberOfOrder.Text + " | " + tbWhere.Text,
                        Pasport = item.Pasport,
                        SNILS = item.SNILS,
                        Sex = item.Sex,
                        PMail = item.PMail,
                        PPhone = item.PPhone,
                        AcademicPerfomance = item.AcademicPerfomance,
                        Activist = item.Activist,
                        HeadOfTheClass = item.HeadOfTheClass,
                        AddresLive = item.AddresLive,
                        HealthCategory = item.HealthCategory,
                        Invalid = item.Invalid,
                        Sirota = item.Sirota,
                        OVZGroup = item.OVZGroup,
                        SOP = item.SOP
                    };
                    db.Students.Remove(item);
                    db.ArchiveOfStudents.Add(ArchStudetn);
                    db.SaveChanges();

                }
                dgStudents.DataSource = db.Students.ToList();
            }

        }
        private void SelectedStudentGoToArchive() // Метод для отправки в архив ВЫБРАННОГО ученика!
        {
            using (var db = new SchoolDB_Context())
            {
                
                var key = Convert.ToInt32(dgStudents.SelectedCells[0].Value);  //dgStudents[0,i].Value
                
                var item = db.Students.Find(key);
                
                var ArchStudetn = new ArchiveOfStudent()
                {
                    Address = item.Address,
                    Age = item.Age,
                    ArchStudentsID = item.StudentsID,
                    OVZ = item.OVZ,
                    Class = item.Class,
                    DOB = item.DOB,
                    FirstName = item.FirstName,
                    SurName = item.SurName,
                    MiddleName = item.MiddleName,
                    INN = item.INN,
                    From = item.From,
                    Where = DateTime.Today.ToString("dd/MM/yyyy") + " | " + tbNumberOfOrder.Text + " | " + tbWhere.Text,
                    Pasport = item.Pasport,
                    SNILS = item.SNILS,
                    Sex = item.Sex,
                    PMail = item.PMail,
                    HeadOfTheClass = item.HeadOfTheClass,
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
                db.Students.Remove(item);
                db.ArchiveOfStudents.Add(ArchStudetn);
                db.SaveChanges();                
                dgStudents.DataSource = db.Students.ToList();
            }
        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(checkBox1, "Будет осуществлен перенос в архив \nвсех отображенных в таблице учеников. \nОтсортируйте с помощью поиска учеников \nдля правильного результата.");
        }

        private void checkBox3_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(checkBox3, "Будет осуществлен перенос одного \n выбранного ученика в архив.");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox3.Checked == true)
            {
                MessageBox.Show("Нужно выбрать только один тип переноса!", "Внимание!");
            }
            if (checkBox1.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Нужно выбрать один из типов переноса!", "Внимание!");
            }
            if (checkBox1.Checked == true && checkBox3.Checked == false)
            {
                if (tbNumberOfOrder.Text != string.Empty && tbWhere.Text != string.Empty)
                {
                    AllGoTOoArchive();
                }
                else
                {
                    MessageBox.Show("Введите номер приказа и куда убыл ученик!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
            if (checkBox1.Checked == false && checkBox3.Checked == true)
            {
                if (tbNumberOfOrder.Text != string.Empty && tbWhere.Text != string.Empty)
                {
                    SelectedStudentGoToArchive();
                }
                else
                {
                    MessageBox.Show("Введите номер приказа и куда убыл ученик!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.BringToFront();
        }

        private void Form2_Enter(object sender, EventArgs e)
        {
            using (var db = new SchoolDB_Context())
            {
                dgStudents.DataSource = db.Students.ToList();
            }
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            using (var db = new SchoolDB_Context())
            {
                dgStudents.DataSource = db.Students.ToList();
            }
        }

        private void tbAge_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(tbAge, "Возраст расчитывается автоматически!");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ShowClassForm form = new ShowClassForm();
            form.Show();
            Hide();
        }

        private void button16_Click(object sender, EventArgs e) // Кнопка отображения итоговых оценок.
        {
            FinalGradeForm gradeForm = new FinalGradeForm(this);
            gradeForm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.BringToFront();
        }


        private void dgStudents_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) // Заполняем текстбоксы значениями из DataGridWiev. Так же присутсвуют combobox-ы для которых проводится проверка на null;
        {
            try
            {
                tb_ID.Text = dgStudents.SelectedCells[0].Value.ToString();
                tbClass.Text = dgStudents.SelectedCells[1].Value.ToString();
                tbSName.Text = dgStudents.SelectedCells[2].Value.ToString();
                tbName.Text = dgStudents.SelectedCells[3].Value.ToString();
                tbMName.Text = dgStudents.SelectedCells[4].Value.ToString();
                dateTimePicker1.Text = dgStudents.SelectedCells[5].Value.ToString();
                tbAge.Text = dgStudents.SelectedCells[6].Value.ToString();
                if (dgStudents.SelectedCells[7].Value != null)
                    cbSex.Text = dgStudents.SelectedCells[7].Value.ToString();
                else
                    cbSex.Text = "";

                tbAddress.Text = dgStudents.SelectedCells[8].Value.ToString();
                tbAdressLive.Text = dgStudents.SelectedCells[9].Value.ToString();
                tbSNILS.Text = dgStudents.SelectedCells[10].Value.ToString();
                tbINN.Text = dgStudents.SelectedCells[11].Value.ToString();
                tbPasport.Text = dgStudents.SelectedCells[12].Value.ToString();
                tbPPhone.Text = dgStudents.SelectedCells[13].Value.ToString();
                tbPEmail.Text = dgStudents.SelectedCells[14].Value.ToString();
                if (dgStudents.SelectedCells[15].Value != null)
                    cbOVZ.Text = dgStudents.SelectedCells[15].Value.ToString();
                else
                    cbOVZ.Text = "";

                if (dgStudents.SelectedCells[16].Value != null)
                    cbOVZGroup.Text = dgStudents.SelectedCells[16].Value.ToString();
                else
                    cbOVZGroup.Text = "";

                if (dgStudents.SelectedCells[17].Value != null)
                    cbInvalid.Text = dgStudents.SelectedCells[17].Value.ToString();
                else
                    cbInvalid.Text = "";

                if (dgStudents.SelectedCells[18].Value != null)
                    cbSirota.Text = dgStudents.SelectedCells[18].Value.ToString();
                else
                    cbSirota.Text = "";

                if (dgStudents.SelectedCells[19].Value != null)
                    cbSOP.Text = dgStudents.SelectedCells[19].Value.ToString();
                else
                    cbSOP.Text = "";

                if (dgStudents.SelectedCells[20].Value != null)
                    cbAcadPerfm.Text = dgStudents.SelectedCells[20].Value.ToString();
                else
                    cbAcadPerfm.Text = "";

                if (dgStudents.SelectedCells[21].Value != null)
                    cbActivist.Text = dgStudents.SelectedCells[21].Value.ToString();
                else
                    cbActivist.Text = "";

                if (dgStudents.SelectedCells[22].Value != null)
                    cbHeadClass.Text = dgStudents.SelectedCells[22].Value.ToString();
                else
                    cbHeadClass.Text = "";

                if (dgStudents.SelectedCells[23].Value != null)
                    cbGroupHealth.Text = dgStudents.SelectedCells[23].Value.ToString();
                else
                    cbGroupHealth.Text = "";

                tbFrom.Text = dgStudents.SelectedCells[24].Value.ToString();
                tbWhere.Text = dgStudents.SelectedCells[25].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Данных нет!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dgStudents_MouseDoubleClick(object sender, MouseEventArgs e)  // Событие. Двойной щелчок по ученику в DataGridView отображает форму оценок, с оценками данного ученика.
        {
            FinalGradeForm gradeForm = new FinalGradeForm(this);
            gradeForm.Show();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel2.BringToFront();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void checkBox2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(checkBox2, "Функция позволяющая расчитать возраст учеников под конкретную дату.");
        }
    }
}
