using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolNumber2
{
    public partial class StudentCardForm : Form
    {
        public StudentCardForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void StudentCardForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var wprint = new WordPrint("Doc1.docx");

                var items = new Dictionary<string, string>
                {
                {"<NAME>", lbName.Text },
                {"<SURNAME>", lbSName.Text },
                {"<MIDDLENAME>", lbMName.Text },
                {"<SEX>", lbSex.Text },
                {"<DOB>", lbDOB.Text },
                {"<AGE>" , lbAge.Text },
                {"<OVZ>" , lbOVZ.Text },
                {"<OVZGroup>" , lbOVZGroup.Text },
                {"<CLASS>", lbClass.Text },
                {"<SNILS>", lbSNILS.Text },
                {"<INN>", lbINN.Text },
                {"<PASPORT>", lbPassport.Text },
                {"<ADDRESS>", lbAdress.Text },
                {"<ADDRESSLIVE>", lbAdressLive.Text },
                {"<FROM>", lbFrom.Text },
                {"<INVALID>", lbIvalid.Text },
                {"<PPHONE>", lbPhone.Text },
                {"<PMAIL>", lbMail.Text },
                {"<SOP>", lbSOP.Text },
                {"<ACADEMICPERFOMANCE>", lbAcademicPerf.Text },
                {"<ACTIVIST>", lbActivist.Text },
                {"<HEADOFTHECLASS>", lbHeadClass.Text },
                {"<HEALTHCATEGORY>", lbHealthCategory.Text },
                {"<SIROTA>", lbSirota.Text }
                };

                wprint.Process(items,saveFileDialog1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FinalGradeForm gradeForm = new FinalGradeForm(this);
            gradeForm.Show();
        }
    }
}
