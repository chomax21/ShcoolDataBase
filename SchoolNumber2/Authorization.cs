using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace SchoolNumber2
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e) // Форма загружается, проверяется наличие логина/пароля, если их нет устанавливается стандартное значение.
        {
            using (var db = new SchoolDB_Context())
            {
                //db.Database.EnsureCreated();
                db.Database.Migrate();
                var item = db.LoginPasses.Find(1);

                if (item == null)
                {
                    var loginpass = new LoginPass() { Login = "admin", Pass = "admin" };
                    db.LoginPasses.Add(loginpass);
                    db.SaveChanges();
                }
            }
            textBox2.UseSystemPasswordChar = true; // Скрытые вводимого пароля.
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // Вкл/Выкл сокрытия пароля.
        {


        }

        private void button1_Click_1(object sender, EventArgs e) // Авторизация и проверка логиа/пароля.
        {
            using (var db = new SchoolDB_Context())
            {
                var item = db.LoginPasses.Find(1);
                if (item.Login == textBox1.Text && item.Pass == textBox2.Text)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин/пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }
    }
}
