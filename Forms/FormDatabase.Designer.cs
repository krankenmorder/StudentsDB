namespace Students.Forms
{
    partial class FormDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatabase));
            this.rtbEmailFind = new System.Windows.Forms.RichTextBox();
            this.lblEmailFind = new System.Windows.Forms.Label();
            this.cbFormFind = new System.Windows.Forms.ComboBox();
            this.lblFormFind = new System.Windows.Forms.Label();
            this.lblGraduationFind = new System.Windows.Forms.Label();
            this.lblGrFind = new System.Windows.Forms.Label();
            this.rtbGrFind = new System.Windows.Forms.RichTextBox();
            this.cbCourseFind = new System.Windows.Forms.ComboBox();
            this.lblCourseFind = new System.Windows.Forms.Label();
            this.cbLevelFind = new System.Windows.Forms.ComboBox();
            this.lblLevelFind = new System.Windows.Forms.Label();
            this.cbDirectionFind = new System.Windows.Forms.ComboBox();
            this.lblDirectionFind = new System.Windows.Forms.Label();
            this.cbFacultyFind = new System.Windows.Forms.ComboBox();
            this.lblFacultyFind = new System.Windows.Forms.Label();
            this.rtbOtchFind = new System.Windows.Forms.RichTextBox();
            this.lblOtchFind = new System.Windows.Forms.Label();
            this.rtbImFind = new System.Windows.Forms.RichTextBox();
            this.lblImFind = new System.Windows.Forms.Label();
            this.rtbFamFind = new System.Windows.Forms.RichTextBox();
            this.lblFamFind = new System.Windows.Forms.Label();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.panelBoxesFind = new System.Windows.Forms.Panel();
            this.rtbPhoneFind = new System.Windows.Forms.RichTextBox();
            this.rtbBirthdayFind = new System.Windows.Forms.RichTextBox();
            this.rtbGraduationFind = new System.Windows.Forms.RichTextBox();
            this.lblPhoneFind = new System.Windows.Forms.Label();
            this.lblBirthdayFind = new System.Windows.Forms.Label();
            this.panelDB_Find = new System.Windows.Forms.Panel();
            this.dgvDB_Find = new System.Windows.Forms.DataGridView();
            this.panelBoxesFind.SuspendLayout();
            this.panelDB_Find.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB_Find)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbEmailFind
            // 
            this.rtbEmailFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbEmailFind.Location = new System.Drawing.Point(856, 86);
            this.rtbEmailFind.Name = "rtbEmailFind";
            this.rtbEmailFind.Size = new System.Drawing.Size(140, 33);
            this.rtbEmailFind.TabIndex = 49;
            this.rtbEmailFind.Text = "";
            // 
            // lblEmailFind
            // 
            this.lblEmailFind.AutoSize = true;
            this.lblEmailFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmailFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmailFind.Location = new System.Drawing.Point(673, 89);
            this.lblEmailFind.Name = "lblEmailFind";
            this.lblEmailFind.Size = new System.Drawing.Size(73, 25);
            this.lblEmailFind.TabIndex = 53;
            this.lblEmailFind.Text = "E-mail:";
            // 
            // cbFormFind
            // 
            this.cbFormFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFormFind.FormattingEnabled = true;
            this.cbFormFind.ItemHeight = 25;
            this.cbFormFind.Items.AddRange(new object[] {
            "бюджетная",
            "коммерция",
            "целевая"});
            this.cbFormFind.Location = new System.Drawing.Point(856, 8);
            this.cbFormFind.Name = "cbFormFind";
            this.cbFormFind.Size = new System.Drawing.Size(140, 33);
            this.cbFormFind.TabIndex = 52;
            // 
            // lblFormFind
            // 
            this.lblFormFind.AutoSize = true;
            this.lblFormFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFormFind.Location = new System.Drawing.Point(673, 11);
            this.lblFormFind.Name = "lblFormFind";
            this.lblFormFind.Size = new System.Drawing.Size(177, 25);
            this.lblFormFind.TabIndex = 51;
            this.lblFormFind.Text = "Форма обучения:";
            // 
            // lblGraduationFind
            // 
            this.lblGraduationFind.AutoSize = true;
            this.lblGraduationFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGraduationFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGraduationFind.Location = new System.Drawing.Point(673, 50);
            this.lblGraduationFind.Name = "lblGraduationFind";
            this.lblGraduationFind.Size = new System.Drawing.Size(132, 25);
            this.lblGraduationFind.TabIndex = 50;
            this.lblGraduationFind.Text = "Год выпуска:";
            // 
            // lblGrFind
            // 
            this.lblGrFind.AutoSize = true;
            this.lblGrFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGrFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGrFind.Location = new System.Drawing.Point(357, 167);
            this.lblGrFind.Name = "lblGrFind";
            this.lblGrFind.Size = new System.Drawing.Size(82, 25);
            this.lblGrFind.TabIndex = 47;
            this.lblGrFind.Text = "Группа:";
            // 
            // rtbGrFind
            // 
            this.rtbGrFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbGrFind.Location = new System.Drawing.Point(502, 164);
            this.rtbGrFind.MaxLength = 2;
            this.rtbGrFind.Name = "rtbGrFind";
            this.rtbGrFind.Size = new System.Drawing.Size(140, 33);
            this.rtbGrFind.TabIndex = 46;
            this.rtbGrFind.Text = "";
            this.rtbGrFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbGrFind_KeyPress);
            // 
            // cbCourseFind
            // 
            this.cbCourseFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourseFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCourseFind.FormattingEnabled = true;
            this.cbCourseFind.ItemHeight = 25;
            this.cbCourseFind.Location = new System.Drawing.Point(502, 125);
            this.cbCourseFind.Name = "cbCourseFind";
            this.cbCourseFind.Size = new System.Drawing.Size(140, 33);
            this.cbCourseFind.TabIndex = 45;
            // 
            // lblCourseFind
            // 
            this.lblCourseFind.AutoSize = true;
            this.lblCourseFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCourseFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCourseFind.Location = new System.Drawing.Point(357, 128);
            this.lblCourseFind.Name = "lblCourseFind";
            this.lblCourseFind.Size = new System.Drawing.Size(60, 25);
            this.lblCourseFind.TabIndex = 44;
            this.lblCourseFind.Text = "Курс:";
            // 
            // cbLevelFind
            // 
            this.cbLevelFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevelFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbLevelFind.FormattingEnabled = true;
            this.cbLevelFind.ItemHeight = 25;
            this.cbLevelFind.Items.AddRange(new object[] {
            "бакалавриат",
            "специалитет",
            "магистратура"});
            this.cbLevelFind.Location = new System.Drawing.Point(502, 86);
            this.cbLevelFind.Name = "cbLevelFind";
            this.cbLevelFind.Size = new System.Drawing.Size(140, 33);
            this.cbLevelFind.TabIndex = 43;
            this.cbLevelFind.SelectedIndexChanged += new System.EventHandler(this.cbLevelFind_SelectedIndexChanged);
            // 
            // lblLevelFind
            // 
            this.lblLevelFind.AutoSize = true;
            this.lblLevelFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLevelFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLevelFind.Location = new System.Drawing.Point(357, 89);
            this.lblLevelFind.Name = "lblLevelFind";
            this.lblLevelFind.Size = new System.Drawing.Size(94, 25);
            this.lblLevelFind.TabIndex = 42;
            this.lblLevelFind.Text = "Уровень:";
            // 
            // cbDirectionFind
            // 
            this.cbDirectionFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDirectionFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDirectionFind.FormattingEnabled = true;
            this.cbDirectionFind.ItemHeight = 25;
            this.cbDirectionFind.Location = new System.Drawing.Point(502, 47);
            this.cbDirectionFind.Name = "cbDirectionFind";
            this.cbDirectionFind.Size = new System.Drawing.Size(140, 33);
            this.cbDirectionFind.TabIndex = 41;
            this.cbDirectionFind.SelectedIndexChanged += new System.EventHandler(this.cbDirectionFind_SelectedIndexChanged);
            // 
            // lblDirectionFind
            // 
            this.lblDirectionFind.AutoSize = true;
            this.lblDirectionFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDirectionFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDirectionFind.Location = new System.Drawing.Point(357, 50);
            this.lblDirectionFind.Name = "lblDirectionFind";
            this.lblDirectionFind.Size = new System.Drawing.Size(139, 25);
            this.lblDirectionFind.TabIndex = 40;
            this.lblDirectionFind.Text = "Направление:";
            // 
            // cbFacultyFind
            // 
            this.cbFacultyFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFacultyFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFacultyFind.FormattingEnabled = true;
            this.cbFacultyFind.ItemHeight = 25;
            this.cbFacultyFind.Items.AddRange(new object[] {
            "ФИРТ",
            "АВИЭТ",
            "ФАДЭТ",
            "ИАТМ",
            "ФЗЧС",
            "ИНЭК"});
            this.cbFacultyFind.Location = new System.Drawing.Point(502, 8);
            this.cbFacultyFind.Name = "cbFacultyFind";
            this.cbFacultyFind.Size = new System.Drawing.Size(140, 33);
            this.cbFacultyFind.TabIndex = 39;
            this.cbFacultyFind.SelectedIndexChanged += new System.EventHandler(this.cbFacultyFind_SelectedIndexChanged);
            // 
            // lblFacultyFind
            // 
            this.lblFacultyFind.AutoSize = true;
            this.lblFacultyFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFacultyFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFacultyFind.Location = new System.Drawing.Point(357, 11);
            this.lblFacultyFind.Name = "lblFacultyFind";
            this.lblFacultyFind.Size = new System.Drawing.Size(123, 25);
            this.lblFacultyFind.TabIndex = 37;
            this.lblFacultyFind.Text = "Факультет:";
            // 
            // rtbOtchFind
            // 
            this.rtbOtchFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbOtchFind.Location = new System.Drawing.Point(185, 86);
            this.rtbOtchFind.Name = "rtbOtchFind";
            this.rtbOtchFind.Size = new System.Drawing.Size(140, 33);
            this.rtbOtchFind.TabIndex = 35;
            this.rtbOtchFind.Text = "";
            this.rtbOtchFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbOtchFind_KeyPress);
            // 
            // lblOtchFind
            // 
            this.lblOtchFind.AutoSize = true;
            this.lblOtchFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOtchFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblOtchFind.Location = new System.Drawing.Point(12, 89);
            this.lblOtchFind.Name = "lblOtchFind";
            this.lblOtchFind.Size = new System.Drawing.Size(110, 25);
            this.lblOtchFind.TabIndex = 34;
            this.lblOtchFind.Text = "Отчество:";
            // 
            // rtbImFind
            // 
            this.rtbImFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbImFind.Location = new System.Drawing.Point(185, 47);
            this.rtbImFind.Name = "rtbImFind";
            this.rtbImFind.Size = new System.Drawing.Size(140, 33);
            this.rtbImFind.TabIndex = 33;
            this.rtbImFind.Text = "";
            this.rtbImFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbImFind_KeyPress);
            // 
            // lblImFind
            // 
            this.lblImFind.AutoSize = true;
            this.lblImFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblImFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblImFind.Location = new System.Drawing.Point(12, 50);
            this.lblImFind.Name = "lblImFind";
            this.lblImFind.Size = new System.Drawing.Size(60, 25);
            this.lblImFind.TabIndex = 32;
            this.lblImFind.Text = "Имя:";
            // 
            // rtbFamFind
            // 
            this.rtbFamFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbFamFind.Location = new System.Drawing.Point(185, 8);
            this.rtbFamFind.Name = "rtbFamFind";
            this.rtbFamFind.Size = new System.Drawing.Size(140, 33);
            this.rtbFamFind.TabIndex = 31;
            this.rtbFamFind.Text = "";
            this.rtbFamFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbFamFind_KeyPress);
            // 
            // lblFamFind
            // 
            this.lblFamFind.AutoSize = true;
            this.lblFamFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFamFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFamFind.Location = new System.Drawing.Point(12, 11);
            this.lblFamFind.Name = "lblFamFind";
            this.lblFamFind.Size = new System.Drawing.Size(109, 25);
            this.lblFamFind.TabIndex = 30;
            this.lblFamFind.Text = "Фамилия:";
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnFindStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindStudent.FlatAppearance.BorderSize = 2;
            this.btnFindStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFindStudent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFindStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnFindStudent.Image")));
            this.btnFindStudent.Location = new System.Drawing.Point(678, 125);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(318, 72);
            this.btnFindStudent.TabIndex = 56;
            this.btnFindStudent.Text = "Найти студента";
            this.btnFindStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindStudent.UseVisualStyleBackColor = false;
            this.btnFindStudent.Click += new System.EventHandler(this.btnFindStudent_Click);
            // 
            // panelBoxesFind
            // 
            this.panelBoxesFind.Controls.Add(this.rtbPhoneFind);
            this.panelBoxesFind.Controls.Add(this.rtbBirthdayFind);
            this.panelBoxesFind.Controls.Add(this.rtbGraduationFind);
            this.panelBoxesFind.Controls.Add(this.lblPhoneFind);
            this.panelBoxesFind.Controls.Add(this.btnFindStudent);
            this.panelBoxesFind.Controls.Add(this.lblFamFind);
            this.panelBoxesFind.Controls.Add(this.rtbFamFind);
            this.panelBoxesFind.Controls.Add(this.lblImFind);
            this.panelBoxesFind.Controls.Add(this.rtbEmailFind);
            this.panelBoxesFind.Controls.Add(this.rtbImFind);
            this.panelBoxesFind.Controls.Add(this.lblEmailFind);
            this.panelBoxesFind.Controls.Add(this.lblOtchFind);
            this.panelBoxesFind.Controls.Add(this.cbFormFind);
            this.panelBoxesFind.Controls.Add(this.rtbOtchFind);
            this.panelBoxesFind.Controls.Add(this.lblFormFind);
            this.panelBoxesFind.Controls.Add(this.lblGraduationFind);
            this.panelBoxesFind.Controls.Add(this.lblFacultyFind);
            this.panelBoxesFind.Controls.Add(this.lblBirthdayFind);
            this.panelBoxesFind.Controls.Add(this.lblGrFind);
            this.panelBoxesFind.Controls.Add(this.cbFacultyFind);
            this.panelBoxesFind.Controls.Add(this.rtbGrFind);
            this.panelBoxesFind.Controls.Add(this.lblDirectionFind);
            this.panelBoxesFind.Controls.Add(this.cbCourseFind);
            this.panelBoxesFind.Controls.Add(this.cbDirectionFind);
            this.panelBoxesFind.Controls.Add(this.lblCourseFind);
            this.panelBoxesFind.Controls.Add(this.lblLevelFind);
            this.panelBoxesFind.Controls.Add(this.cbLevelFind);
            this.panelBoxesFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBoxesFind.Location = new System.Drawing.Point(0, 460);
            this.panelBoxesFind.Name = "panelBoxesFind";
            this.panelBoxesFind.Size = new System.Drawing.Size(1008, 204);
            this.panelBoxesFind.TabIndex = 57;
            // 
            // rtbPhoneFind
            // 
            this.rtbPhoneFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbPhoneFind.Location = new System.Drawing.Point(185, 164);
            this.rtbPhoneFind.MaxLength = 16;
            this.rtbPhoneFind.Name = "rtbPhoneFind";
            this.rtbPhoneFind.Size = new System.Drawing.Size(140, 33);
            this.rtbPhoneFind.TabIndex = 59;
            this.rtbPhoneFind.Text = "";
            // 
            // rtbBirthdayFind
            // 
            this.rtbBirthdayFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbBirthdayFind.Location = new System.Drawing.Point(185, 125);
            this.rtbBirthdayFind.MaxLength = 10;
            this.rtbBirthdayFind.Name = "rtbBirthdayFind";
            this.rtbBirthdayFind.Size = new System.Drawing.Size(140, 33);
            this.rtbBirthdayFind.TabIndex = 58;
            this.rtbBirthdayFind.Text = "";
            // 
            // rtbGraduationFind
            // 
            this.rtbGraduationFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbGraduationFind.Location = new System.Drawing.Point(856, 47);
            this.rtbGraduationFind.MaxLength = 4;
            this.rtbGraduationFind.Name = "rtbGraduationFind";
            this.rtbGraduationFind.Size = new System.Drawing.Size(140, 33);
            this.rtbGraduationFind.TabIndex = 57;
            this.rtbGraduationFind.Text = "";
            // 
            // lblPhoneFind
            // 
            this.lblPhoneFind.AutoSize = true;
            this.lblPhoneFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPhoneFind.Location = new System.Drawing.Point(12, 167);
            this.lblPhoneFind.Name = "lblPhoneFind";
            this.lblPhoneFind.Size = new System.Drawing.Size(105, 25);
            this.lblPhoneFind.TabIndex = 48;
            this.lblPhoneFind.Text = "Телефон:";
            // 
            // lblBirthdayFind
            // 
            this.lblBirthdayFind.AutoSize = true;
            this.lblBirthdayFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirthdayFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBirthdayFind.Location = new System.Drawing.Point(12, 130);
            this.lblBirthdayFind.Name = "lblBirthdayFind";
            this.lblBirthdayFind.Size = new System.Drawing.Size(167, 25);
            this.lblBirthdayFind.TabIndex = 38;
            this.lblBirthdayFind.Text = "Дата рождения:";
            // 
            // panelDB_Find
            // 
            this.panelDB_Find.Controls.Add(this.dgvDB_Find);
            this.panelDB_Find.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDB_Find.Location = new System.Drawing.Point(0, 0);
            this.panelDB_Find.Name = "panelDB_Find";
            this.panelDB_Find.Size = new System.Drawing.Size(1008, 460);
            this.panelDB_Find.TabIndex = 58;
            // 
            // dgvDB_Find
            // 
            this.dgvDB_Find.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB_Find.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDB_Find.Location = new System.Drawing.Point(0, 0);
            this.dgvDB_Find.Name = "dgvDB_Find";
            this.dgvDB_Find.RowHeadersWidth = 62;
            this.dgvDB_Find.RowTemplate.Height = 28;
            this.dgvDB_Find.Size = new System.Drawing.Size(1008, 460);
            this.dgvDB_Find.TabIndex = 0;
            // 
            // FormDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1008, 664);
            this.Controls.Add(this.panelDB_Find);
            this.Controls.Add(this.panelBoxesFind);
            this.Name = "FormDatabase";
            this.Text = "FormDatabase";
            this.Load += new System.EventHandler(this.FormDatabase_Load);
            this.panelBoxesFind.ResumeLayout(false);
            this.panelBoxesFind.PerformLayout();
            this.panelDB_Find.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB_Find)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbEmailFind;
        private System.Windows.Forms.Label lblEmailFind;
        private System.Windows.Forms.ComboBox cbFormFind;
        private System.Windows.Forms.Label lblFormFind;
        private System.Windows.Forms.Label lblGraduationFind;
        private System.Windows.Forms.Label lblGrFind;
        private System.Windows.Forms.RichTextBox rtbGrFind;
        private System.Windows.Forms.ComboBox cbCourseFind;
        private System.Windows.Forms.Label lblCourseFind;
        private System.Windows.Forms.ComboBox cbLevelFind;
        private System.Windows.Forms.Label lblLevelFind;
        private System.Windows.Forms.ComboBox cbDirectionFind;
        private System.Windows.Forms.Label lblDirectionFind;
        private System.Windows.Forms.ComboBox cbFacultyFind;
        private System.Windows.Forms.Label lblFacultyFind;
        private System.Windows.Forms.RichTextBox rtbOtchFind;
        private System.Windows.Forms.Label lblOtchFind;
        private System.Windows.Forms.RichTextBox rtbImFind;
        private System.Windows.Forms.Label lblImFind;
        private System.Windows.Forms.RichTextBox rtbFamFind;
        private System.Windows.Forms.Label lblFamFind;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.Panel panelBoxesFind;
        private System.Windows.Forms.Panel panelDB_Find;
        private System.Windows.Forms.DataGridView dgvDB_Find;
        private System.Windows.Forms.RichTextBox rtbGraduationFind;
        private System.Windows.Forms.RichTextBox rtbPhoneFind;
        private System.Windows.Forms.RichTextBox rtbBirthdayFind;
        private System.Windows.Forms.Label lblPhoneFind;
        private System.Windows.Forms.Label lblBirthdayFind;
    }
}