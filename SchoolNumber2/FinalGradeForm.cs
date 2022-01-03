using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SchoolNumber2
{
    public partial class FinalGradeForm : Form
    {
        private int searchClass { get; set; }
        public FinalGradeForm()
        {
            InitializeComponent();
        }
        
        public FinalGradeForm(Form2 form2) // Используем конструктор формы. Попадаем в форму оценок через форму Форму2(Основная форма для работы с БД учеников) с использованием 
        {                                  // значений из последней формы.
            
            InitializeComponent();
            lbClass.Text = form2.tbClass.Text;
            lbID.Text = form2.tb_ID.Text;
            lbFName.Text = form2.tbName.Text;
            lbSName.Text = form2.tbSName.Text;
            lbMName.Text = form2.tbMName.Text;
        }

        public FinalGradeForm(StudentCardForm cardForm) // Используем конструктор формы. Попадаем в форму оценок через форму Карты ученика с использованием 
        {                                               // значений из последней формы.
            InitializeComponent();
            lbClass.Text = cardForm.lbClass.Text;
            lbID.Text = cardForm.lb_ID.Text;
            lbFName.Text = cardForm.lbName.Text;
            lbSName.Text = cardForm.lbSName.Text;
            lbMName.Text = cardForm.lbMName.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FinalGradeForm_Load(object sender, EventArgs e) // Ищем за какой класс для ученика выдать оценки.
        {     
            
            string countClass = lbClass.Text;

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
                searchClass = val;
            }                       
            if (searchClass <= 4) // С первого по четвертый класс свои предметы.
                {
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label15.Visible = true;
                    label14.Visible = true;
                    label13.Visible = true;
                    label12.Visible = true;
                    label11.Visible = true;
                    label20.Visible = true;
                    label19.Visible = true;
                    label18.Visible = true;
                    label17.Visible = true;
                    label16.Visible = true;
                    label25.Visible = true;
                    tbChtenRodYazChuv.Visible = true;
                    tbChtenRodYazRuss.Visible = true;
                    tbFIZRA.Visible = true;
                    tbGosYazChuv.Visible = true;
                    tbHistCultRodnKray.Visible = true;
                    tbInostYazEng.Visible = true;
                    tbIZO.Visible = true;
                    tbLiteratura.Visible = true;
                    tbMatematika.Visible = true;
                    tbMuzika.Visible = true;
                    tbOkrMir.Visible = true;
                    tbOkrMir.Visible = true;
                    tbOsnovReligSvetskEtiki.Visible = true;
                    tbRodnoyYazRuss.Visible = true;
                    tbRodnoyYzChuv.Visible = true;
                    tbRusskiyYaz.Visible = true;
                    tbTechnology.Visible = true;
                    this.Width = 660;
                    this.Height = 520;
                    button2.Location.Offset(10, 435);
                }
            if (searchClass >= 5 && searchClass <= 9) // С пятого по девятый класс свои предметы.
            {
                    tbChtenRodYazChuv.Visible = true;
                    tbChtenRodYazRuss.Visible = true;
                    tbFIZRA.Visible = true;
                    tbAlgebra.Visible = true;
                    tbHistCultRodnKray.Visible = true;
                    tbInostYazEng.Visible = true;
                    tbIZO.Visible = true;
                    tbLiteratura.Visible = true;
                    tbMatematika.Visible = true;
                    tbMuzika.Visible = true;
                    tbOkrMir.Visible = true;
                    tbOkrMir.Visible = true;
                    tbVtoroyInostYazGer.Visible = true;
                    tbRodnoyYazRuss.Visible = true;
                    tbRodnoyYzChuv.Visible = true;
                    tbRusskiyYaz.Visible = true;
                    tbTechnology.Visible = true;
                    tbFizika.Visible = true;
                    tbXimia.Visible = true;
                    tbObshestvo.Visible = true;
                    tbMoyGorod.Visible = true;
                    tbOBZ.Visible = true;
                    tbOsnDuxKultRuss.Visible = true;
                    tbInformatika.Visible = true;
                    tbGeography.Visible = true;
                    tbGeometry.Visible = true;
                    tbShahmate.Visible = true;
                    tbBiology.Visible = true;
                    tbHistRussVseOHistr.Visible = true;
                    tbMatematika.Location.Offset(498, 268);
                    label13.Location.Offset(408, 276);
                    tbVtoroyInostYazGer.Location.Offset(498, 211);
                    label24.Location.Offset(241, 219);
                    tbObshestvo.Location.Offset(498, 239);
                    label22.Location.Offset(376, 247);
                    tbFizika.Location.Offset(498, 442);
                    label26.Location.Offset(433, 450);
                    tbXimia.Location.Offset(498, 471);
                    label35.Location.Offset(438, 479);
                    tbBiology.Location.Offset(920, 158);
                    tbShahmate.Location.Offset(920, 187);
                    tbOBZ.Location.Offset(920, 215);
                    tbMoyGorod.Location.Offset(920, 244);
                    label31.Location.Offset(838, 252);
                    label32.Location.Offset(651, 223);
                    label33.Location.Offset(845, 195);
                    label34.Location.Offset(843, 166);
                    label30.Visible = true;
                    label28.Visible = true;
                    label29.Visible = true;
                    label21.Visible = true;
                    label27.Visible = true;
                    label26.Visible = true;
                    label35.Visible = true;
                    label34.Visible = true;
                    label33.Visible = true;
                    label32.Visible = true;
                    label31.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label15.Visible = true;
                    label14.Visible = true;
                    label13.Visible = true;
                    label12.Visible = true;
                    label20.Visible = true;
                    label19.Visible = true;
                    label18.Visible = true;
                    label17.Visible = true;
                    label16.Visible = true;
                    label22.Visible = true;
                    label23.Visible = true;
                    label24.Visible = true;

                }
            if (searchClass >= 10) // С десятого по одиннадцатый класс свои предметы.
            {
                    label6.Visible = true; tbRusskiyYaz.Visible = true;
                    label7.Visible = true; tbLiteratura.Visible = true;
                    label32.Visible = true; tbOBZ.Visible = true;
                    label22.Visible = true; tbObshestvo.Visible = true;
                    label37.Visible = true; tbPravo.Visible = true;
                    label38.Visible = true; tbHistory.Visible = true;
                    label39.Visible = true; tbEconomica.Visible = true;
                    label40.Visible = true; tbAlgebraProff.Visible = true;
                    label34.Visible = true; tbBiology.Visible = true;
                    label28.Visible = true; tbInformatika.Visible = true;
                    label14.Visible = true; tbInostYazEng.Visible = true;
                    label26.Visible = true; tbFizika.Visible = true;
                    label18.Visible = true; tbFIZRA.Visible = true;
                    //label30.Visible = true; tbAlgebra.Visible = true;
                    label15.Visible = true; tbChtenRodYazChuv.Visible = true;
                    //label29.Visible = true; tbGeometry.Visible = true;
                    label45.Visible = true; tbAnalizTeksta.Visible = true;
                    label36.Visible = true; tbAstronomy.Visible = true;
                    label15.Visible = true; tbChtenRodYazChuv.Visible = true;
                    label21.Visible = true; tbGeography.Visible = true;
                }

            
        }
        public void ResetGradeTextBoxes()
        {
            tbMatematika.Text = "";
            tbRusskiyYaz.Text = "";
            tbRodnoyYzChuv.Text = "";
            tbRodnoyYazRuss.Text = "";
            tbLiteratura.Text = "";
            tbChtenRodYazChuv.Text = "";
            tbChtenRodYazRuss.Text = "";
            tbInostYazEng.Text = "";
            tbOkrMir.Text = "";
            tbOsnovReligSvetskEtiki.Text = "";
            tbMuzika.Text = "";
            tbIZO.Text = "";
            tbFIZRA.Text = "";
            tbTechnology.Text = "";
            tbHistCultRodnKray.Text = "";
            tbGosYazChuv.Text = "";
            tbOsnDuxKultRuss.Text = "";
            tbOsnovReligSvetskEtiki.Text = "";
            tbRodnoyYazRuss.Text = "";
            tbRodnoyYzChuv.Text = "";
            tbShahmate.Text = "";
            tbVtoroyInostYazGer.Text = "";
            tbXimia.Text = "";
            tbFizika.Text = "";
            tbGeography.Text = "";
            tbGeometry.Text = "";
            tbInformatika.Text = "";
            tbAlgebra.Text = "";
            tbHistRussVseOHistr.Text = "";
            tbObshestvo.Text = "";
            tbBiology.Text = "";
            tbOBZ.Text = "";
            tbMoyGorod.Text = "";
            tbAnalizTeksta.Text = "";
            tbAstronomy.Text = "";
            tbEconomica.Text = "";
            tbPravo.Text = "";
            tbHistory.Text = "";
            tbAlgebraProff.Text = "";
        } // Сбрасываем отображение оценок.

        private void button1_Click(object sender, EventArgs e) // Проверка. Есть ли запись в базе по заданным кретериям. Если есть, то создовать уже нельзя.
        {
            if (cbQuarter.Text != "" && cbClass.Text != "")
            {
                using (var db = new SchoolDB_Context())
                {
                    var searchQuarter = from q in db.FinalGrades 
                                        where q.WhatQuarter == cbQuarter.Text && q.SearchID == lbID.Text && q.WhatClass == cbClass.Text
                                        select q;
                    int resultSearchQuarter = searchQuarter.Count();

                    if (searchClass <= 4 && resultSearchQuarter == 0)
                    {

                        var finalGrade = new FinalGrade
                        {
                            WhatClass = cbClass.Text,
                            SearchID = lbID.Text,
                            WhatQuarter = cbQuarter.Text,
                            Matematika = tbMatematika.Text,
                            RusskiyYazuk = tbRusskiyYaz.Text,
                            RodnoyChuvashYazuk = tbRodnoyYzChuv.Text,
                            RodnoyRusskiyYazuk = tbRodnoyYazRuss.Text,
                            LitareturnoeChtenie = tbLiteratura.Text,
                            LiteraturnoeChtenieNaRodmonYzukeChuv = tbChtenRodYazChuv.Text,
                            LiteraturnoeChtenieNaRodmonYzukeRuss = tbChtenRodYazRuss.Text,
                            InostranuyYazukEnglish = tbInostYazEng.Text,
                            OkrMir = tbOkrMir.Text,
                            OsnovuReligiiISvetskoyEtiki = tbOsnovReligSvetskEtiki.Text,
                            Muzika = tbMuzika.Text,
                            IZO = tbIZO.Text,
                            FIZRA = tbFIZRA.Text,
                            Technology = tbTechnology.Text,
                            HistoryKultureRodnogoKray = tbHistCultRodnKray.Text,
                            GosYazukChuvRespublici = tbGosYazChuv.Text
                        };

                        db.FinalGrades.Add(finalGrade);
                        db.SaveChanges();
                        ResetGradeTextBoxes();
                        MessageBox.Show("Оценки внесены!", "Внимание!");
                        ResetGradeTextBoxes();
                    }
                    else if (searchClass <= 9 && searchClass >= 5 && resultSearchQuarter == 0)
                    {
                        var finalGrade = new FinalGrade
                        {

                            WhatClass = cbClass.Text, // Здесь записывается число класса ученика, для поиска и определения.
                            SearchID = lbID.Text, // Записываем ID ученика для дальнейшего поиска и сортировки записей по этому ID.
                            WhatQuarter = cbQuarter.Text, // Определяем четверть. Ищем по результату этой записи.
                            Matematika = tbMatematika.Text,
                            RusskiyYazuk = tbRusskiyYaz.Text,
                            RodnoyChuvashYazuk = tbRodnoyYzChuv.Text,
                            RodnoyRusskiyYazuk = tbRodnoyYazRuss.Text,
                            LitareturnoeChtenie = tbLiteratura.Text,
                            LiteraturnoeChtenieNaRodmonYzukeChuv = tbChtenRodYazChuv.Text,
                            LiteraturnoeChtenieNaRodmonYzukeRuss = tbChtenRodYazRuss.Text,
                            InostranuyYazukEnglish = tbInostYazEng.Text,
                            OkrMir = tbOkrMir.Text,
                            OsnovuReligiiISvetskoyEtiki = tbOsnovReligSvetskEtiki.Text,
                            Muzika = tbMuzika.Text,
                            IZO = tbIZO.Text,
                            FIZRA = tbFIZRA.Text,
                            Technology = tbTechnology.Text,
                            HistoryKultureRodnogoKray = tbHistCultRodnKray.Text,
                            GosYazukChuvRespublici = tbGosYazChuv.Text,
                            Algebra = tbAlgebra.Text,
                            Biology = tbBiology.Text,
                            Fizika = tbFizika.Text,
                            Geography = tbGeography.Text,
                            Geometry = tbGeometry.Text,
                            Informatika = tbInformatika.Text,
                            OBZ = tbOBZ.Text,
                            Obshetvoznanie = tbObshestvo.Text,
                            MoyGorod = tbMoyGorod.Text,
                            Shahmate = tbShahmate.Text,
                            Ximia = tbXimia.Text,
                            InostranuyYazukGermany = tbVtoroyInostYazGer.Text,
                            HistoryRussiaVseobshayHistory = tbHistRussVseOHistr.Text,
                            OsnovuDuxovnoNravstvennoyKultNarodovRussia = tbOsnDuxKultRuss.Text
                        };
                        db.FinalGrades.Add(finalGrade);
                        db.SaveChanges();
                        ResetGradeTextBoxes();
                        MessageBox.Show("Оценки внесены!", "Внимание!");
                        
                       
                    }
                    else if (searchClass >= 10 && resultSearchQuarter == 0)
                    {
                        var finalGrade = new FinalGrade
                        {

                            WhatClass = cbClass.Text, // Здесь записывается число класса ученика, для поиска и определения.
                            SearchID = lbID.Text, // Записываем ID ученика для дальнейшего поиска и сортировки записей по этому ID.
                            WhatQuarter = cbQuarter.Text, // Определяем четверть. Ищем по результату этой записи.
                            RusskiyYazuk = tbRusskiyYaz.Text,
                            RodnoyChuvashYazuk = tbRodnoyYzChuv.Text,
                            LitareturnoeChtenie = tbLiteratura.Text,
                            LiteraturnoeChtenieNaRodmonYzukeChuv = tbChtenRodYazChuv.Text,
                            InostranuyYazukEnglish = tbInostYazEng.Text,
                            FIZRA = tbFIZRA.Text,
                            Technology = tbTechnology.Text,
                            GosYazukChuvRespublici = tbGosYazChuv.Text,
                            Algebra = tbAlgebra.Text,
                            Biology = tbBiology.Text,
                            Fizika = tbFizika.Text,
                            Geography = tbGeography.Text,
                            Geometry = tbGeometry.Text,
                            Informatika = tbInformatika.Text,
                            OBZ = tbOBZ.Text,
                            Obshetvoznanie = tbObshestvo.Text,
                            Pravo = tbPravo.Text,
                            History = tbHistory.Text,
                            Ekonomika = tbEconomica.Text,
                            MatematikaAlgebraIMatematikaAnalizGeometry = tbAlgebraProff.Text,
                            Astronomia = tbAstronomy.Text,
                            RaznoAspectnuyAnalizTeksta = tbAnalizTeksta.Text
   
                        };
                        db.FinalGrades.Add(finalGrade);
                        db.SaveChanges();
                        ResetGradeTextBoxes();
                        MessageBox.Show("Оценки внесены!", "Внимание!");
                    }
                    else
                    {
                        MessageBox.Show("Оценки за данный период уже существуют!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }              
            }
            else
            {
                MessageBox.Show("Нужно выбрать класс и период ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // Показать 
        {  
        }

        private void button3_Click(object sender, EventArgs e) // Показать оценки.
        {
            if (cbQuarter.Text != "" && cbClass.Text != "")
            {
                using (var db = new SchoolDB_Context())
                {
                    var item = from x in db.FinalGrades
                               where x.SearchID == lbID.Text && x.WhatClass == cbClass.Text && x.WhatQuarter == cbQuarter.Text
                               select x;
                    foreach (var result in item)
                    {
                        tbAlgebra.Text = result.Algebra;
                        tbAlgebraProff.Text = result.MatematikaAlgebraIMatematikaAnalizGeometry;
                        tbAnalizTeksta.Text = result.RaznoAspectnuyAnalizTeksta;
                        tbAstronomy.Text = result.Astronomia;
                        tbBiology.Text = result.Biology;
                        tbChtenRodYazChuv.Text = result.LiteraturnoeChtenieNaRodmonYzukeChuv;
                        tbChtenRodYazRuss.Text = result.LiteraturnoeChtenieNaRodmonYzukeRuss;
                        tbEconomica.Text = result.Ekonomika;
                        tbFizika.Text = result.Fizika;
                        tbFIZRA.Text = result.FIZRA;
                        tbGeography.Text = result.Geography;
                        tbGeometry.Text = result.Geometry;
                        tbGosYazChuv.Text = result.GosYazukChuvRespublici;
                        tbHistCultRodnKray.Text = result.HistoryKultureRodnogoKray;
                        tbHistory.Text = result.History;
                        tbHistRussVseOHistr.Text = result.HistoryRussiaVseobshayHistory;
                        tbInformatika.Text = result.Informatika;
                        tbInostYazEng.Text = result.InostranuyYazukEnglish;
                        tbIZO.Text = result.IZO;
                        tbLiteratura.Text = result.LitareturnoeChtenie;
                        tbMatematika.Text = result.Matematika;
                        tbMoyGorod.Text = result.MoyGorod;
                        tbMuzika.Text = result.Muzika;
                        tbObshestvo.Text = result.Obshetvoznanie;
                        tbOBZ.Text = result.OBZ;
                        tbOkrMir.Text = result.OkrMir;
                        tbOsnDuxKultRuss.Text = result.OsnovuDuxovnoNravstvennoyKultNarodovRussia;
                        tbOsnovReligSvetskEtiki.Text = result.OsnovuReligiiISvetskoyEtiki;
                        tbPravo.Text = result.Pravo;
                        tbRodnoyYazRuss.Text = result.RodnoyRusskiyYazuk;
                        tbRodnoyYzChuv.Text = result.RodnoyChuvashYazuk;
                        tbRusskiyYaz.Text = result.RusskiyYazuk;
                        tbShahmate.Text = result.Shahmate;
                        tbTechnology.Text = result.Technology;
                        tbVtoroyInostYazGer.Text = result.InostranuyYazukGermany;
                        tbXimia.Text = result.Ximia;

                    }

                }
            }
            else
                MessageBox.Show("Нужно выбрать период и класс!", "Внимание!");            
        }


        private void button4_Click(object sender, EventArgs e) // Редактируем оценки.
        {
            using (var db = new SchoolDB_Context())
            {
                var item = from x in db.FinalGrades
                           where x.SearchID == lbID.Text && x.WhatClass == cbClass.Text && x.WhatQuarter == cbQuarter.Text
                           select x;
                
                foreach (var findkey in item)
                {                    
                    int resultKey = findkey.GradeID;
                    var newitem = db.FinalGrades.Find(resultKey);
                    if (newitem != null)
                    {
                        newitem.Algebra = tbAlgebra.Text;
                        newitem.AspektuClassicFiziki = tbFizika.Text;
                        newitem.Astronomia = tbAstronomy.Text;
                        newitem.Biology = tbBiology.Text;
                        newitem.Ekonomika = tbEconomica.Text;
                        newitem.Fizika = tbFizika.Text;
                        newitem.FIZRA = tbFIZRA.Text;
                        newitem.Geography = tbGeography.Text;
                        newitem.Geometry = tbGeometry.Text;
                        newitem.GosYazukChuvRespublici = tbGosYazChuv.Text;
                        newitem.History = tbHistory.Text;
                        newitem.HistoryKultureRodnogoKray = tbHistCultRodnKray.Text;
                        newitem.HistoryRussiaVseobshayHistory = tbHistRussVseOHistr.Text;
                        newitem.Informatika = tbInformatika.Text;
                        newitem.InostranuyYazukEnglish = tbInostYazEng.Text;
                        newitem.InostranuyYazukGermany = tbVtoroyInostYazGer.Text;
                        newitem.IstoriaIKulturaRodnogoKraya = tbHistCultRodnKray.Text;
                        newitem.IZO = tbIZO.Text;
                        newitem.LitareturnoeChtenie = tbLiteratura.Text;
                        newitem.LiteraturnoeChtenieNaRodmonYzukeChuv = tbChtenRodYazChuv.Text;
                        newitem.LiteraturnoeChtenieNaRodmonYzukeRuss = tbChtenRodYazRuss.Text;
                        newitem.Matematika = tbMatematika.Text;
                        newitem.MatematikaAlgebraIMatematikaAnalizGeometry = tbAlgebraProff.Text;
                        newitem.MoyGorod = tbMoyGorod.Text;
                        newitem.Muzika = tbMuzika.Text;
                        newitem.Obshetvoznanie = tbObshestvo.Text;
                        newitem.OBZ = tbOBZ.Text;
                        newitem.OkrMir = tbOkrMir.Text;
                        newitem.OsnovuDuxovnoNravstvennoyKultNarodovRussia = tbOsnDuxKultRuss.Text;
                        newitem.OsnovuReligiiISvetskoyEtiki = tbOsnovReligSvetskEtiki.Text;
                        newitem.Ximia = tbXimia.Text;
                        newitem.PonytiaIZakonuXimii = tbPonytiaiZakonXimii.Text;
                        newitem.Pravo = tbPravo.Text;
                        newitem.RaznoAspectnuyAnalizTeksta = tbAnalizTeksta.Text;
                        newitem.RodnoyChuvashYazuk = tbRodnoyYzChuv.Text;
                        newitem.RodnoyRusskiyYazuk = tbRodnoyYazRuss.Text;
                        newitem.RusskiyYazuk = tbRusskiyYaz.Text;
                        newitem.Shahmate = tbShahmate.Text;
                        newitem.Technology = tbTechnology.Text;
                        newitem.BiologyKletkiIOrganizma = tbBiologyKletok.Text;
                        db.SaveChanges();
                        MessageBox.Show("Оценки отредактированны!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                              
            }
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClass.Text == "1" || cbClass.Text == "2" || cbClass.Text == "3" || cbClass.Text == "4")
            {
                HideGrades();
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label15.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label20.Visible = true;
                label19.Visible = true;
                label18.Visible = true;
                label17.Visible = true;
                label16.Visible = true;
                label25.Visible = true;
                tbChtenRodYazChuv.Visible = true;
                tbChtenRodYazRuss.Visible = true;
                tbFIZRA.Visible = true;
                tbGosYazChuv.Visible = true;
                tbHistCultRodnKray.Visible = true;
                tbInostYazEng.Visible = true;
                tbIZO.Visible = true;
                tbLiteratura.Visible = true;
                tbMatematika.Visible = true;
                tbMuzika.Visible = true;
                tbOkrMir.Visible = true;
                tbOkrMir.Visible = true;
                tbOsnovReligSvetskEtiki.Visible = true;
                tbRodnoyYazRuss.Visible = true;
                tbRodnoyYzChuv.Visible = true;
                tbRusskiyYaz.Visible = true;
                tbTechnology.Visible = true;
                this.Width = 660;
                this.Height = 620;

            }
            if (cbClass.Text == "5" || cbClass.Text == "6" || cbClass.Text == "7" || cbClass.Text == "8" || cbClass.Text == "9")
            {
                HideGrades();
                tbChtenRodYazChuv.Visible = true;
                tbChtenRodYazRuss.Visible = true;
                tbFIZRA.Visible = true;
                tbAlgebra.Visible = true;
                tbHistCultRodnKray.Visible = true;
                tbInostYazEng.Visible = true;
                tbIZO.Visible = true;
                tbLiteratura.Visible = true;
                tbMatematika.Visible = true;
                tbMuzika.Visible = true;
                tbOkrMir.Visible = true;
                tbOkrMir.Visible = true;
                tbVtoroyInostYazGer.Visible = true;
                tbRodnoyYazRuss.Visible = true;
                tbRodnoyYzChuv.Visible = true;
                tbRusskiyYaz.Visible = true;
                tbTechnology.Visible = true;
                tbFizika.Visible = true;
                tbXimia.Visible = true;
                tbObshestvo.Visible = true;
                tbMoyGorod.Visible = true;
                tbOBZ.Visible = true;
                tbOsnDuxKultRuss.Visible = true;
                tbInformatika.Visible = true;
                tbGeography.Visible = true;
                tbGeometry.Visible = true;
                tbShahmate.Visible = true;
                tbBiology.Visible = true;
                tbHistRussVseOHistr.Visible = true;
                label30.Visible = true;
                label28.Visible = true;
                label29.Visible = true;
                label21.Visible = true;
                label27.Visible = true;
                label26.Visible = true;
                label35.Visible = true;
                label34.Visible = true;
                label33.Visible = true;
                label32.Visible = true;
                label31.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label15.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label12.Visible = true;
                label20.Visible = true;
                label19.Visible = true;
                label18.Visible = true;
                label17.Visible = true;
                label16.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                this.Width = 1081;
                this.Height = 612;
            }
            if (cbClass.Text == "10" || cbClass.Text == "11")
            {
                HideGrades();
                label6.Visible = true; tbRusskiyYaz.Visible = true;
                label7.Visible = true; tbLiteratura.Visible = true;
                label32.Visible = true; tbOBZ.Visible = true;
                label22.Visible = true; tbObshestvo.Visible = true;
                label37.Visible = true; tbPravo.Visible = true;
                label38.Visible = true; tbHistory.Visible = true;
                label39.Visible = true; tbEconomica.Visible = true;
                label40.Visible = true; tbAlgebraProff.Visible = true;
                label34.Visible = true; tbBiology.Visible = true;
                label28.Visible = true; tbInformatika.Visible = true;
                label14.Visible = true; tbInostYazEng.Visible = true;
                label26.Visible = true; tbFizika.Visible = true;
                label18.Visible = true; tbFIZRA.Visible = true;
                //label30.Visible = true; tbAlgebra.Visible = true;
                label15.Visible = true; tbChtenRodYazChuv.Visible = true;
                //label29.Visible = true; tbGeometry.Visible = true;
                label45.Visible = true; tbAnalizTeksta.Visible = true;
                label36.Visible = true; tbAstronomy.Visible = true;
                label15.Visible = true; tbChtenRodYazChuv.Visible = true;
                label21.Visible = true; tbGeography.Visible = true;
                this.Width = 1081;
                this.Height = 612;
            }
        }
        private void HideGrades()
        {
            label6.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label16.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label43.Visible = false;
            label44.Visible = false;
            label45.Visible = false;
            
            tbAlgebra.Visible = false;
            tbAlgebraProff.Visible = false;
            tbAnalizTeksta.Visible = false;
            tbAstronomy.Visible = false;
            tbBiology.Visible = false;
            tbChtenRodYazChuv.Visible = false;
            tbChtenRodYazRuss.Visible = false;
            tbEconomica.Visible = false;
            tbFizika.Visible = false;
            tbFIZRA.Visible = false;
            tbGeography.Visible = false;
            tbGeometry.Visible = false;
            tbGosYazChuv.Visible = false;
            tbHistCultRodnKray.Visible = false;
            tbHistory.Visible = false;
            tbHistRussVseOHistr.Visible = false;
            tbInformatika.Visible = false;
            tbInostYazEng.Visible = false;
            tbIZO.Visible = false;
            tbLiteratura.Visible = false;
            tbMatematika.Visible = false;
            tbMoyGorod.Visible = false;
            tbMuzika.Visible = false;
            tbObshestvo.Visible = false;
            tbOBZ.Visible = false;
            tbOkrMir.Visible = false;
            tbOsnDuxKultRuss.Visible = false;
            tbOsnovReligSvetskEtiki.Visible = false;
            tbPravo.Visible = false;
            tbRodnoyYazRuss.Visible = false;
            tbRodnoyYzChuv.Visible = false;
            tbRusskiyYaz.Visible = false;
            tbShahmate.Visible = false;
            tbTechnology.Visible = false;
            tbVtoroyInostYazGer.Visible = false;
            tbXimia.Visible = false;

        }

        private void cbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void FinalGradeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
        }
    }
    
}
