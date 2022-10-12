namespace SchoolNumber2
{
    partial class TeacherCoursForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherCoursForm));
            this.dgTeacherCours = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_IDTeachCours = new System.Windows.Forms.TextBox();
            this.tb_NameTeachCours = new System.Windows.Forms.TextBox();
            this.dateTimeTeachCours = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeDeadLineCours = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.cbMark = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeacherCours)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTeacherCours
            // 
            this.dgTeacherCours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTeacherCours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTeacherCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTeacherCours.Location = new System.Drawing.Point(1, 2);
            this.dgTeacherCours.Name = "dgTeacherCours";
            this.dgTeacherCours.RowTemplate.Height = 25;
            this.dgTeacherCours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTeacherCours.Size = new System.Drawing.Size(1015, 430);
            this.dgTeacherCours.TabIndex = 0;
            this.dgTeacherCours.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgTeacherCours_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(203, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(416, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Location = new System.Drawing.Point(531, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Location = new System.Drawing.Point(301, 496);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_IDTeachCours
            // 
            this.tb_IDTeachCours.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_IDTeachCours.Location = new System.Drawing.Point(29, 467);
            this.tb_IDTeachCours.Name = "tb_IDTeachCours";
            this.tb_IDTeachCours.ReadOnly = true;
            this.tb_IDTeachCours.Size = new System.Drawing.Size(60, 23);
            this.tb_IDTeachCours.TabIndex = 5;
            // 
            // tb_NameTeachCours
            // 
            this.tb_NameTeachCours.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tb_NameTeachCours.Location = new System.Drawing.Point(203, 467);
            this.tb_NameTeachCours.Name = "tb_NameTeachCours";
            this.tb_NameTeachCours.Size = new System.Drawing.Size(529, 23);
            this.tb_NameTeachCours.TabIndex = 6;
            // 
            // dateTimeTeachCours
            // 
            this.dateTimeTeachCours.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimeTeachCours.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTeachCours.Location = new System.Drawing.Point(884, 456);
            this.dateTimeTeachCours.Name = "dateTimeTeachCours";
            this.dateTimeTeachCours.Size = new System.Drawing.Size(111, 23);
            this.dateTimeTeachCours.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Сотрудника";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Название курса";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(882, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дата прохождения ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(884, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Срок окончания";
            // 
            // dateTimeDeadLineCours
            // 
            this.dateTimeDeadLineCours.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dateTimeDeadLineCours.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDeadLineCours.Location = new System.Drawing.Point(884, 502);
            this.dateTimeDeadLineCours.Name = "dateTimeDeadLineCours";
            this.dateTimeDeadLineCours.Size = new System.Drawing.Size(111, 23);
            this.dateTimeDeadLineCours.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button5.Location = new System.Drawing.Point(646, 496);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 29);
            this.button5.TabIndex = 15;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cbMark
            // 
            this.cbMark.FormattingEnabled = true;
            this.cbMark.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.cbMark.Location = new System.Drawing.Point(748, 467);
            this.cbMark.Name = "cbMark";
            this.cbMark.Size = new System.Drawing.Size(90, 23);
            this.cbMark.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(760, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Отмечен";
            // 
            // TeacherCoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 539);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMark);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateTimeDeadLineCours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeTeachCours);
            this.Controls.Add(this.tb_NameTeachCours);
            this.Controls.Add(this.tb_IDTeachCours);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgTeacherCours);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherCoursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсы повышение квалификации сотрудника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherCoursForm_FormClosed);
            this.Load += new System.EventHandler(this.TeacherCoursForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTeacherCours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTeacherCours;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_IDTeachCours;
        private System.Windows.Forms.TextBox tb_NameTeachCours;
        private System.Windows.Forms.DateTimePicker dateTimeTeachCours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeDeadLineCours;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbMark;
        private System.Windows.Forms.Label label5;
    }
}