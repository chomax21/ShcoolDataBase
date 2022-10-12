namespace SchoolNumber2
{
    partial class ShowListDeadCoursForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowListDeadCoursForm));
            this.dgShowDeadCours = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMark = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowDeadCours)).BeginInit();
            this.SuspendLayout();
            // 
            // dgShowDeadCours
            // 
            this.dgShowDeadCours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgShowDeadCours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgShowDeadCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShowDeadCours.Location = new System.Drawing.Point(0, 0);
            this.dgShowDeadCours.Name = "dgShowDeadCours";
            this.dgShowDeadCours.RowTemplate.Height = 25;
            this.dgShowDeadCours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgShowDeadCours.Size = new System.Drawing.Size(935, 434);
            this.dgShowDeadCours.TabIndex = 0;
            this.dgShowDeadCours.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShowDeadCours_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фильтр по остатку дней до срока окончания курса :";
            // 
            // tbFilter
            // 
            this.tbFilter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbFilter.Location = new System.Drawing.Point(477, 447);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(100, 23);
            this.tbFilter.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(583, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отобразить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Отмечен :";
            this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
            // 
            // cbMark
            // 
            this.cbMark.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbMark.FormattingEnabled = true;
            this.cbMark.Items.AddRange(new object[] {
            "Да",
            "Нет",
            "-"});
            this.cbMark.Location = new System.Drawing.Point(771, 447);
            this.cbMark.Name = "cbMark";
            this.cbMark.Size = new System.Drawing.Size(90, 23);
            this.cbMark.TabIndex = 18;
            // 
            // ShowListDeadCoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 487);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMark);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgShowDeadCours);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowListDeadCoursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список сотрудников";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowListDeadCoursForm_FormClosed);
            this.Load += new System.EventHandler(this.ShowListDeadCoursForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgShowDeadCours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgShowDeadCours;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMark;
    }
}