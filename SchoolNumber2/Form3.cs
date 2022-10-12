using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolNumber2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        void button1_Click(object sender, EventArgs e)
        {
            using (var db = new SchoolDB_Context()) // Добавляем сотрудников
            {
                DateTime time1 = dateTimePicker2.Value; // Происходит вычисление возраста на текущий момент.
                DateTime time2 = DateTime.Now;
                int timeResult = (time2 - time1).Days;
                int timeResult2 = timeResult / 365;

                var teacher1 = new Teacher()
                {
                    TName = tbTName.Text,
                    TSurName = tbTSName.Text,
                    TMiddleName = tbTMName.Text,
                    TDOB = dateTimePicker2.Text,
                    Spicialization = tbTSpecialization.Text,
                    BaseClass = tbTBaseCl.Text,
                    TPassport = tbTPassport.Text,
                    Phone = tbTPhone.Text,
                    Email = tbTEmail.Text,
                    SpecItem = cbSpecItem.Text,
                    SpecItemHours = tbSpecItemHours.Text,
                    DopSpecItem = cbDopSpecItem.Text,
                    DopSpecItemHours = tbSpecItemHours.Text,
                    TINN = tbTINN.Text,
                    TSNILS = tbTSNILS.Text,
                    TAdress = tbTAdress.Text,
                    TAge = timeResult2.ToString(),
                    DPU = tbDPU.Text,
                    DPUHours = tbDPUHours.Text,
                    Expirience = tbExpirience.Text,
                    ExpirienceTeaching = tbExpirienceTeach.Text,
                    GPDHours = tbGPDHours.Text,
                    TCategory = cbCategory.Text,
                    PFDOT = tbPFD.Text,
                    PFDOTHours = tbPFDHours.Text,
                    TEducation = tbEducation.Text,
                    EducationSpecialization = tbEducationSpec.Text,
                    TAdressLive = tbAdressLive.Text,
                    HonorEmploy = cbHonorEmp.Text,
                    YangSpicialist = cbYangEmp.Text,
                    PrimaryOrSecondary = cbPrimaryOrSec.Text,
                    KPK = tbKPK.Text,
                    Сoefficient = tbCoefficient.Text,
                    Rate = tbRate.Text
                                       
                };
                db.Teachers.Add(teacher1);
                db.SaveChanges();
                dgTeachers.DataSource = db.Teachers.ToList();
            }
            GetCountTeachersInDataBase();
            ResetTeachersFields();
        }



        void button3_Click(object sender, EventArgs e) // Удаляем сотрудников
        {
            if (MessageBox.Show("Вы точно хотите удалить запись? Данные будут утеряны! ",
                "Предупреждение!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new SchoolDB_Context())
                    {
                        int key = Convert.ToInt32(tbT_ID.Text);
                        var item = db.Teachers.Find(key);
                        if (item != null)
                        {
                            db.Teachers.Remove(item);
                            db.SaveChanges();
                            dgTeachers.DataSource = db.Teachers.ToList();
                        }
                    }

                }
                catch 
                {
                    MessageBox.Show("Данных нет!", "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
               
            }
            GetCountTeachersInDataBase();
            ResetTeachersFields();
        }

        private void dgTeachers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) // Заполняем поля из таблицы
        {
            try
            {
                tbT_ID.Text = dgTeachers.SelectedCells[0].Value.ToString();
                tbTSName.Text = dgTeachers.SelectedCells[1].Value.ToString();
                tbTName.Text = dgTeachers.SelectedCells[2].Value.ToString();
                tbTMName.Text = dgTeachers.SelectedCells[3].Value.ToString();
                dateTimePicker2.Text = dgTeachers.SelectedCells[4].Value.ToString();
                tbTAge.Text = dgTeachers.SelectedCells[5].Value.ToString();
                tbTAdress.Text = dgTeachers.SelectedCells[6].Value.ToString();
                tbAdressLive.Text = dgTeachers.SelectedCells[7].Value.ToString();
                tbTSNILS.Text = dgTeachers.SelectedCells[8].Value.ToString();
                tbTINN.Text = dgTeachers.SelectedCells[9].Value.ToString();
                tbTPassport.Text = dgTeachers.SelectedCells[10].Value.ToString();
                tbTPhone.Text = dgTeachers.SelectedCells[11].Value.ToString();
                tbTEmail.Text = dgTeachers.SelectedCells[12].Value.ToString();
                tbEducation.Text = dgTeachers.SelectedCells[13].Value.ToString();
                tbEducationSpec.Text = dgTeachers.SelectedCells[14].Value.ToString();
                tbExpirience.Text = dgTeachers.SelectedCells[15].Value.ToString();
                tbExpirienceTeach.Text = dgTeachers.SelectedCells[16].Value.ToString();
                tbRate.Text = dgTeachers.SelectedCells[17].Value.ToString();
                tbTSpecialization.Text = dgTeachers.SelectedCells[18].Value.ToString();                                

                if (dgTeachers.SelectedCells[19].Value != null)
                    cbSpecItem.Text = dgTeachers.SelectedCells[19].Value.ToString();
                else
                    cbSpecItem.Text = "";


                tbSpecItemHours.Text = dgTeachers.SelectedCells[20].Value.ToString();


                if (dgTeachers.SelectedCells[21].Value != null)
                    cbDopSpecItem.Text = dgTeachers.SelectedCells[21].Value.ToString();
                else
                    cbDopSpecItem.Text = "";

                tbDopSpecItemHours.Text = dgTeachers.SelectedCells[22].Value.ToString();
                tbGPDHours.Text = dgTeachers.SelectedCells[23].Value.ToString();
                tbDPU.Text = dgTeachers.SelectedCells[24].Value.ToString();
                tbDPUHours.Text = dgTeachers.SelectedCells[25].Value.ToString();
                tbPFD.Text = dgTeachers.SelectedCells[26].Value.ToString();
                tbPFDHours.Text = dgTeachers.SelectedCells[27].Value.ToString();


                if (dgTeachers.SelectedCells[28] != null)
                    cbCategory.Text = dgTeachers.SelectedCells[28].Value.ToString();
                else
                    cbCategory.Text = "";


                if (dgTeachers.SelectedCells[29] != null)
                    cbHonorEmp.Text = dgTeachers.SelectedCells[29].Value.ToString();
                else
                    cbHonorEmp.Text = "";


                if (dgTeachers.SelectedCells[30] != null)
                    cbYangEmp.Text = dgTeachers.SelectedCells[30].Value.ToString();
                else
                    cbYangEmp.Text = "";

                tbCoefficient.Text = dgTeachers.SelectedCells[31].Value.ToString();
                tbKPK.Text = dgTeachers.SelectedCells[32].Value.ToString();


                if (dgTeachers.SelectedCells[33] != null)
                    cbPrimaryOrSec.Text = dgTeachers.SelectedCells[33].Value.ToString();
                else
                    cbPrimaryOrSec.Text = "";


                tbTBaseCl.Text = dgTeachers.SelectedCells[34].Value.ToString();

            }
            catch 
            {
                MessageBox.Show("Данных нет!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            
               
            
        }

        void button2_Click(object sender, EventArgs e)  //Редактируем Сотрудников
        {
            using (var db = new SchoolDB_Context())
            {
                DateTime time1 = dateTimePicker2.Value;
                DateTime time2 = DateTime.Now;
                int timeResult = (time2 - time1).Days;
                int timeResult2 = timeResult / 365;

                var key = Convert.ToInt32(tbT_ID.Text);
                var item = db.Teachers.Find(key);
                if (item != null)
                {
                    item.TName = tbTName.Text;
                    item.TSurName = tbTSName.Text;
                    item.TMiddleName = tbTMName.Text;
                    item.TDOB = dateTimePicker2.Text;
                    item.Spicialization = tbTSpecialization.Text;
                    item.BaseClass = tbTBaseCl.Text;
                    item.Phone = tbTPhone.Text;
                    item.Email = tbTEmail.Text;
                    item.TSNILS = tbTSNILS.Text;
                    item.TINN = tbTINN.Text;
                    item.TAge = timeResult2.ToString();
                    item.TCategory = cbCategory.Text;
                    item.Spicialization = tbTSpecialization.Text;
                    item.SpecItem = cbSpecItem.Text;
                    item.SpecItemHours = tbSpecItemHours.Text;
                    item.DopSpecItem = cbDopSpecItem.Text;
                    item.DopSpecItemHours = tbDopSpecItemHours.Text;
                    item.DPU = tbDPU.Text;
                    item.DPUHours = tbDPUHours.Text;
                    item.Expirience = tbExpirience.Text;
                    item.ExpirienceTeaching = tbExpirienceTeach.Text;
                    item.GPDHours = tbGPDHours.Text;
                    item.TPassport = tbTPassport.Text;
                    item.EducationSpecialization = tbEducationSpec.Text;
                    item.TEducation = tbEducation.Text;
                    item.HonorEmploy = cbHonorEmp.Text;
                    item.YangSpicialist = cbYangEmp.Text;
                    item.KPK = tbKPK.Text;
                    item.Rate = tbRate.Text;
                    item.TAdress = tbTAdress.Text;
                    item.TAdressLive = tbAdressLive.Text;
                    item.Сoefficient = tbCoefficient.Text;
                    item.PFDOT = tbPFD.Text;
                    item.PFDOTHours = tbPFDHours.Text;

                    db.SaveChanges();
                    dgTeachers.DataSource = db.Teachers.ToList();
                }
            };
            GetCountTeachersInDataBase();
            ResetTeachersFields();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Загружается форма сотрудников, проверяем отображается ли БД, если нет выводим данные с БД в датагрид,
            // далее переименование столбцов.
            using (var db = new SchoolDB_Context())
            {
                if (dgTeachers != null)
                {
                    dgTeachers.DataSource = db.Teachers.ToList();
                    ChangeTeachersColomnNames();
                    GetCountTeachersInDataBase();
                }             
            }
        }

        void ChangeTeachersColomnNames() // Назначаем имена столбцам.
        {
            dgTeachers.Columns["TeachersID"].HeaderText = "ID";
            dgTeachers.Columns["TName"].HeaderText = "Имя";
            dgTeachers.Columns["TSurName"].HeaderText = "Фамилия";
            dgTeachers.Columns["TMiddleName"].HeaderText = "Отчество";
            dgTeachers.Columns["TDOB"].HeaderText = "Дата рождения";
            dgTeachers.Columns["Spicialization"].HeaderText = "Должность";
            dgTeachers.Columns["BaseClass"].HeaderText = "Классное руководство";
            dgTeachers.Columns["Phone"].HeaderText = "Телефон";
            dgTeachers.Columns["Email"].HeaderText = "Почта";
            dgTeachers.Columns["Expirience"].HeaderText = "Стаж";
            dgTeachers.Columns["ExpirienceTeaching"].HeaderText = "Стаж педагог";
            dgTeachers.Columns["TCategory"].HeaderText = "Категория";
            dgTeachers.Columns["SpecItem"].HeaderText = "Предмет";
            dgTeachers.Columns["SpecItemHours"].HeaderText = "Часы основа";
            dgTeachers.Columns["DopSpecItem"].HeaderText = "Доп.предмет";
            dgTeachers.Columns["DopSpecItemHours"].HeaderText = "Часы доп.";
            dgTeachers.Columns["DPU"].HeaderText = "ДПУ";
            dgTeachers.Columns["DPUHours"].HeaderText = "ДПУ часы";
            dgTeachers.Columns["GPDHours"].HeaderText = "ГПД часы";
            dgTeachers.Columns["TSNILS"].HeaderText = "СНИЛС";
            dgTeachers.Columns["TINN"].HeaderText = "ИНН";
            dgTeachers.Columns["TAdress"].HeaderText = "Адрес";
            dgTeachers.Columns["TAdressLive"].HeaderText = "Адрес проживания";
            dgTeachers.Columns["TEducation"].HeaderText = "Образование";
            dgTeachers.Columns["EducationSpecialization"].HeaderText = "Специальность";
            dgTeachers.Columns["Rate"].HeaderText = "Процентная ставка";
            dgTeachers.Columns["PFDOT"].HeaderText = "ПФДОТ";
            dgTeachers.Columns["PFDOTHours"].HeaderText = "ПФДОТ часы";
            dgTeachers.Columns["HonorEmploy"].HeaderText = "Почетный работник";
            dgTeachers.Columns["YangSpicialist"].HeaderText = "Молодой специалист";
            dgTeachers.Columns["Сoefficient"].HeaderText = "Коэфициент вредности";
            dgTeachers.Columns["KPK"].HeaderText = "Курсы квалификации";
            dgTeachers.Columns["PrimaryOrSecondary"].HeaderText = "Основной или совместитель";
            dgTeachers.Columns["TAge"].HeaderText = "Возраст";
            dgTeachers.Columns["TPassport"].HeaderText = "Паспорт";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();           
            Hide();
        }

        private void button5_Click(object sender, EventArgs e) // Exel
        {
            ExcelPrint.PrintDataGridToExel(dgTeachers, saveFileDialog1);
        }
        public void ResetTeachersFields() // Сбрасываем значения полей.
        {
            tbDopSpecItemHours.Text = string.Empty;
            tbDPUHours.Text = string.Empty;
            tbExpirience.Text = string.Empty;
            tbDPU.Text = string.Empty;
            tbExpirienceTeach.Text = string.Empty;
            tbGPDHours.Text = string.Empty;
            tbSpecItemHours.Text = string.Empty;
            tbTAdress.Text = string.Empty;
            tbTAge.Text = string.Empty;
            tbTBaseCl.Text = string.Empty;
            tbTEmail.Text = string.Empty;
            tbTINN.Text = string.Empty;
            tbTMName.Text = string.Empty;
            tbTName.Text = string.Empty;
            tbTPassport.Text = string.Empty;
            tbTPhone.Text = string.Empty;
            tbTPhone.Text = string.Empty;
            tbTSName.Text = string.Empty;
            tbTSNILS.Text = string.Empty;
            tbTSpecialization.Text = string.Empty;
            tbT_ID.Text = string.Empty;
            cbCategory.Text = string.Empty;
            cbDopSpecItem.Text = string.Empty;
            cbSpecItem.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            tbPFD.Text = string.Empty;
            tbPFDHours.Text = string.Empty;
            tbKPK.Text = string.Empty;
            tbRate.Text = string.Empty;
            tbCoefficient.Text = string.Empty;
            tbAdressLive.Text = string.Empty;
            cbHonorEmp.Text = string.Empty;
            cbYangEmp.Text = string.Empty;
            cbPrimaryOrSec.Text = string.Empty;
            tbEducation.Text = string.Empty;
            tbEducationSpec.Text = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e) // Кнопка вызываюшая метод сброса полей.
        {
            ResetTeachersFields();
        }

        private void button7_Click(object sender, EventArgs e) // Кнопка обновления.
        {
            using (var db = new SchoolDB_Context())
            {
                dgTeachers.DataSource = db.Teachers.ToList();               
            }
            GetCountTeachersInDataBase();
            ResetTeachersFields();
        }
        public void GetCountTeachersInDataBase() // Подсчет учеников отображаемых в Базе данных.
        {
            using (var db = new SchoolDB_Context())
            {
                int size = db.Teachers.Count();
                textBox1.Text = size.ToString();
            }

        }

        private async void button8_Click(object sender, EventArgs e)
        {
            if (tbT_ID.Text != string.Empty)
            {
                var wprint = new WordPrint("DocTeachers.docx");

                var items = new Dictionary<string, string>
                {
                {"<SURNAME>", tbTSName.Text },
                {"<NAME>", tbTName.Text },
                {"<MIDDLENAME>", tbTMName.Text },
                {"<DOB>", dateTimePicker2.Text },
                {"<AGE>" , tbTAge.Text },
                {"<ADRESS>" , tbTAdress.Text },
                {"<ADRESSLIVE>", tbAdressLive.Text },
                {"<SNILS>", tbTSNILS.Text },
                {"<INN>", tbTINN.Text },
                {"<PASPORT>", tbTPassport.Text },
                {"<PHONE>", tbTPhone.Text },
                {"<MAIL>", tbTEmail.Text },
                {"<EDUCATION>", tbEducation.Text },
                {"<EDUCATIONSPECIALIIZATION>", tbEducationSpec.Text },
                {"<EXPIRIENCE>", tbExpirience.Text },
                {"<EXPIRIENCETEACHING>", tbExpirienceTeach.Text },
                {"<RATE>", tbRate.Text },
                {"<SPECIALIZATION>", tbTSpecialization.Text },
                {"<SPECITEM>", cbSpecItem.Text },
                {"<SPECITEMHORS>", tbSpecItemHours.Text },
                {"<DOPSPECITEM>", cbDopSpecItem.Text },
                {"<DOPSPECITEMHOURS>", tbDopSpecItemHours.Text },
                {"<GPDHOURS>", tbGPDHours.Text },
                {"<DPU>", tbDPU.Text },
                {"<DPUHOURS>", tbDPUHours.Text },
                {"<PFDOT>", tbPFD.Text },
                {"<PFDOTHOURS>", tbPFDHours.Text },
                {"<CATEGORY>", cbCategory.Text },
                {"<HONOREMPLOY>", cbHonorEmp.Text },
                {"<YANGSPEC>", cbYangEmp.Text },
                {"<COOEFICIENT>", tbCoefficient.Text },
                {"<PRIMARYORSECONDAY>", cbPrimaryOrSec.Text },
                {"<BASECLASS>", tbTBaseCl.Text }
                };
                await Task.Run(() => wprint.Process(items));
            }                          
        }

        private void button9_Click(object sender, EventArgs e) // Поиск и сортировка.
        {
            using (var db = new SchoolDB_Context())
            {
                var search = from s in db.Teachers
                             where s.TName.Contains(tbTName.Text)
                             where s.TSurName.Contains(tbTSName.Text)
                             where s.TMiddleName.Contains(tbTMName.Text)
                             where s.TMiddleName.Contains(tbTMName.Text)
                             where s.BaseClass.Contains(tbTBaseCl.Text)
                             where s.TEducation.Contains(tbEducation.Text)
                             where s.EducationSpecialization.Contains(tbEducationSpec.Text)
                             where s.EducationSpecialization.Contains(tbEducationSpec.Text)
                             where s.Spicialization.Contains(tbTSpecialization.Text)
                             where s.SpecItem.Contains(cbSpecItem.Text)
                             where s.DopSpecItemHours.Contains(tbDopSpecItemHours.Text)
                             where s.TCategory.Contains(cbCategory.Text)
                             where s.HonorEmploy.Contains(cbHonorEmp.Text)
                             where s.YangSpicialist.Contains(cbYangEmp.Text)
                             where s.PrimaryOrSecondary.Contains(cbPrimaryOrSec.Text)
                             select s;
                dgTeachers.DataSource = search.ToList();
            }
        }

        private void button10_Click(object sender, EventArgs e) // Кнопка для вывода формы курсов сотрудников.
        {
            if (tbT_ID.Text != string.Empty)
            {
                TeacherCoursForm coursForm = new TeacherCoursForm(this);
                coursForm.Show();
            }
            else
            {
                MessageBox.Show("Нужно выбрать сотрудника!", "Внимани!");
            }
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e) // Закрываем форму сотрудников. Возвращаемся к основной форме.
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
