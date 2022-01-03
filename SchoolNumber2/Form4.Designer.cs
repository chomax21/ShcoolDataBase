
namespace SchoolNumber2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dgArchStudents = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ArchTb_ID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbAName = new System.Windows.Forms.TextBox();
            this.tbASName = new System.Windows.Forms.TextBox();
            this.tbAMName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbAClass = new System.Windows.Forms.TextBox();
            this.tbAWhere = new System.Windows.Forms.TextBox();
            this.tbAFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button8 = new System.Windows.Forms.Button();
            this.tbNumberOfOrderArch = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgArchStudents)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgArchStudents
            // 
            this.dgArchStudents.AllowUserToAddRows = false;
            this.dgArchStudents.AllowUserToDeleteRows = false;
            this.dgArchStudents.AllowUserToResizeColumns = false;
            this.dgArchStudents.AllowUserToResizeRows = false;
            this.dgArchStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgArchStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgArchStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgArchStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArchStudents.Location = new System.Drawing.Point(4, 3);
            this.dgArchStudents.Name = "dgArchStudents";
            this.dgArchStudents.ReadOnly = true;
            this.dgArchStudents.RowTemplate.Height = 25;
            this.dgArchStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgArchStudents.Size = new System.Drawing.Size(1343, 492);
            this.dgArchStudents.TabIndex = 1;
            this.dgArchStudents.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgArchStudents_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(751, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArchTb_ID
            // 
            this.ArchTb_ID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ArchTb_ID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ArchTb_ID.Location = new System.Drawing.Point(186, 526);
            this.ArchTb_ID.Name = "ArchTb_ID";
            this.ArchTb_ID.Size = new System.Drawing.Size(60, 23);
            this.ArchTb_ID.TabIndex = 3;
            this.ArchTb_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArchTb_ID.UseWaitCursor = true;
            this.ArchTb_ID.TextChanged += new System.EventHandler(this.ArchTb_ID_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(832, 559);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Востановить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbAName
            // 
            this.tbAName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbAName.Location = new System.Drawing.Point(582, 526);
            this.tbAName.Name = "tbAName";
            this.tbAName.Size = new System.Drawing.Size(161, 23);
            this.tbAName.TabIndex = 5;
            // 
            // tbASName
            // 
            this.tbASName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbASName.Location = new System.Drawing.Point(419, 526);
            this.tbASName.Name = "tbASName";
            this.tbASName.Size = new System.Drawing.Size(157, 23);
            this.tbASName.TabIndex = 6;
            // 
            // tbAMName
            // 
            this.tbAMName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbAMName.Location = new System.Drawing.Point(749, 526);
            this.tbAMName.Name = "tbAMName";
            this.tbAMName.Size = new System.Drawing.Size(155, 23);
            this.tbAMName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(792, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Отчество";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(668, 559);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.Location = new System.Drawing.Point(391, 555);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 43);
            this.button4.TabIndex = 12;
            this.button4.Text = "Excel";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbAClass
            // 
            this.tbAClass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbAClass.Location = new System.Drawing.Point(252, 526);
            this.tbAClass.Name = "tbAClass";
            this.tbAClass.Size = new System.Drawing.Size(161, 23);
            this.tbAClass.TabIndex = 13;
            // 
            // tbAWhere
            // 
            this.tbAWhere.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbAWhere.Location = new System.Drawing.Point(1073, 527);
            this.tbAWhere.Name = "tbAWhere";
            this.tbAWhere.Size = new System.Drawing.Size(157, 23);
            this.tbAWhere.TabIndex = 14;
            this.tbAWhere.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbAFrom
            // 
            this.tbAFrom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbAFrom.Location = new System.Drawing.Point(911, 526);
            this.tbAFrom.Name = "tbAFrom";
            this.tbAFrom.Size = new System.Drawing.Size(155, 23);
            this.tbAFrom.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Класс";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(963, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Приход";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1129, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Уход";
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.Location = new System.Drawing.Point(473, 558);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 35);
            this.button5.TabIndex = 19;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button6.Location = new System.Drawing.Point(556, 559);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 34);
            this.button6.TabIndex = 20;
            this.button6.Text = "Сброс полей";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.tbNumberOfOrderArch);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Location = new System.Drawing.Point(974, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 173);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(174, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(2, 134);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(175, 33);
            this.button8.TabIndex = 5;
            this.button8.Text = "Восстановить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tbNumberOfOrderArch
            // 
            this.tbNumberOfOrderArch.Location = new System.Drawing.Point(3, 76);
            this.tbNumberOfOrderArch.Name = "tbNumberOfOrderArch";
            this.tbNumberOfOrderArch.Size = new System.Drawing.Size(175, 23);
            this.tbNumberOfOrderArch.TabIndex = 4;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(99, 31);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 19);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Всех";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Одного";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "№ Приказа";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightCoral;
            this.button7.Location = new System.Drawing.Point(3, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 22);
            this.button7.TabIndex = 0;
            this.button7.Text = "Закрыть";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Кол-во";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(36, 521);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 29);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseWaitCursor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1353, 606);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAFrom);
            this.Controls.Add(this.tbAWhere);
            this.Controls.Add(this.tbAClass);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAMName);
            this.Controls.Add(this.tbASName);
            this.Controls.Add(this.tbAName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ArchTb_ID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgArchStudents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Архив учеников";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgArchStudents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgArchStudents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ArchTb_ID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbAName;
        private System.Windows.Forms.TextBox tbASName;
        private System.Windows.Forms.TextBox tbAMName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tbAClass;
        private System.Windows.Forms.TextBox tbAWhere;
        private System.Windows.Forms.TextBox tbAFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbNumberOfOrderArch;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}