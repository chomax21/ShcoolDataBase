using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolNumber2
{
    public partial class ChangePassForm : Form
    {
        public ChangePassForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new SchoolDB_Context())
            {
                var item = db.LoginPasses.Find(1);
                if (item.Login == textBox1.Text && item.Pass == textBox2.Text)
                {
                    label1.Text = "Введите новый пароль";
                    label1.ForeColor = Color.Green;
                    button1.Hide();
                    button2.Show();
                }
                else
                    label1.ForeColor = Color.Red;
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (var db = new SchoolDB_Context())
            {
                var item = db.LoginPasses.Find(1);
                item.Login = textBox1.Text;
                item.Pass = textBox2.Text;
                db.SaveChanges();
                MessageBox.Show("Логин/пароль изменен");
                Form1 form1 = new Form1();
                form1.Show();
                Hide();

            }
        }

        private void ChangePassForm_Load(object sender, EventArgs e)
        {
            button2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChangePassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
