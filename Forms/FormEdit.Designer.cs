namespace Students.Forms
{
    partial class FormEdit
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
            this.panelDB_Edit = new System.Windows.Forms.Panel();
            this.dgvDB_Edit = new System.Windows.Forms.DataGridView();
            this.panelBoxesEdit = new System.Windows.Forms.Panel();
            this.rtbGrEdit = new System.Windows.Forms.RichTextBox();
            this.mtbGraduationEdit = new System.Windows.Forms.MaskedTextBox();
            this.lblFamEdit = new System.Windows.Forms.Label();
            this.mtbPhoneEdit = new System.Windows.Forms.MaskedTextBox();
            this.rtbFamEdit = new System.Windows.Forms.RichTextBox();
            this.rtbEmailEdit = new System.Windows.Forms.RichTextBox();
            this.lblImEdit = new System.Windows.Forms.Label();
            this.lblEmailEdit = new System.Windows.Forms.Label();
            this.rtbImEdit = new System.Windows.Forms.RichTextBox();
            this.cbFormEdit = new System.Windows.Forms.ComboBox();
            this.lblOtchEdit = new System.Windows.Forms.Label();
            this.lblFormEdit = new System.Windows.Forms.Label();
            this.rtbOtchEdit = new System.Windows.Forms.RichTextBox();
            this.lblGraduationEdit = new System.Windows.Forms.Label();
            this.dtpBirthdayEdit = new System.Windows.Forms.DateTimePicker();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.lblFacultyEdit = new System.Windows.Forms.Label();
            this.lblPhoneEdit = new System.Windows.Forms.Label();
            this.lblBirthdayEdit = new System.Windows.Forms.Label();
            this.lblGrEdit = new System.Windows.Forms.Label();
            this.cbFacultyEdit = new System.Windows.Forms.ComboBox();
            this.lblDirectionEdit = new System.Windows.Forms.Label();
            this.cbCourseEdit = new System.Windows.Forms.ComboBox();
            this.cbDirectionEdit = new System.Windows.Forms.ComboBox();
            this.lblCourseEdit = new System.Windows.Forms.Label();
            this.lblLevelEdit = new System.Windows.Forms.Label();
            this.cbLevelEdit = new System.Windows.Forms.ComboBox();
            this.panelDB_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB_Edit)).BeginInit();
            this.panelBoxesEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDB_Edit
            // 
            this.panelDB_Edit.Controls.Add(this.dgvDB_Edit);
            this.panelDB_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDB_Edit.Location = new System.Drawing.Point(0, 0);
            this.panelDB_Edit.Name = "panelDB_Edit";
            this.panelDB_Edit.Size = new System.Drawing.Size(1008, 460);
            this.panelDB_Edit.TabIndex = 1;
            // 
            // dgvDB_Edit
            // 
            this.dgvDB_Edit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDB_Edit.Location = new System.Drawing.Point(0, 0);
            this.dgvDB_Edit.Name = "dgvDB_Edit";
            this.dgvDB_Edit.ReadOnly = true;
            this.dgvDB_Edit.RowHeadersWidth = 62;
            this.dgvDB_Edit.RowTemplate.Height = 28;
            this.dgvDB_Edit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDB_Edit.Size = new System.Drawing.Size(1008, 460);
            this.dgvDB_Edit.TabIndex = 0;
            this.dgvDB_Edit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDB_Edit_CellClick);
            // 
            // panelBoxesEdit
            // 
            this.panelBoxesEdit.Controls.Add(this.rtbGrEdit);
            this.panelBoxesEdit.Controls.Add(this.mtbGraduationEdit);
            this.panelBoxesEdit.Controls.Add(this.lblFamEdit);
            this.panelBoxesEdit.Controls.Add(this.mtbPhoneEdit);
            this.panelBoxesEdit.Controls.Add(this.rtbFamEdit);
            this.panelBoxesEdit.Controls.Add(this.rtbEmailEdit);
            this.panelBoxesEdit.Controls.Add(this.lblImEdit);
            this.panelBoxesEdit.Controls.Add(this.lblEmailEdit);
            this.panelBoxesEdit.Controls.Add(this.rtbImEdit);
            this.panelBoxesEdit.Controls.Add(this.cbFormEdit);
            this.panelBoxesEdit.Controls.Add(this.lblOtchEdit);
            this.panelBoxesEdit.Controls.Add(this.lblFormEdit);
            this.panelBoxesEdit.Controls.Add(this.rtbOtchEdit);
            this.panelBoxesEdit.Controls.Add(this.lblGraduationEdit);
            this.panelBoxesEdit.Controls.Add(this.dtpBirthdayEdit);
            this.panelBoxesEdit.Controls.Add(this.btnEditStudent);
            this.panelBoxesEdit.Controls.Add(this.lblFacultyEdit);
            this.panelBoxesEdit.Controls.Add(this.lblPhoneEdit);
            this.panelBoxesEdit.Controls.Add(this.lblBirthdayEdit);
            this.panelBoxesEdit.Controls.Add(this.lblGrEdit);
            this.panelBoxesEdit.Controls.Add(this.cbFacultyEdit);
            this.panelBoxesEdit.Controls.Add(this.lblDirectionEdit);
            this.panelBoxesEdit.Controls.Add(this.cbCourseEdit);
            this.panelBoxesEdit.Controls.Add(this.cbDirectionEdit);
            this.panelBoxesEdit.Controls.Add(this.lblCourseEdit);
            this.panelBoxesEdit.Controls.Add(this.lblLevelEdit);
            this.panelBoxesEdit.Controls.Add(this.cbLevelEdit);
            this.panelBoxesEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBoxesEdit.Location = new System.Drawing.Point(0, 460);
            this.panelBoxesEdit.Name = "panelBoxesEdit";
            this.panelBoxesEdit.Size = new System.Drawing.Size(1008, 204);
            this.panelBoxesEdit.TabIndex = 31;
            // 
            // rtbGrEdit
            // 
            this.rtbGrEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbGrEdit.Location = new System.Drawing.Point(502, 164);
            this.rtbGrEdit.MaxLength = 2;
            this.rtbGrEdit.Name = "rtbGrEdit";
            this.rtbGrEdit.Size = new System.Drawing.Size(140, 33);
            this.rtbGrEdit.TabIndex = 17;
            this.rtbGrEdit.Text = "";
            // 
            // mtbGraduationEdit
            // 
            this.mtbGraduationEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbGraduationEdit.Location = new System.Drawing.Point(856, 47);
            this.mtbGraduationEdit.Mask = "2\\000";
            this.mtbGraduationEdit.Name = "mtbGraduationEdit";
            this.mtbGraduationEdit.Size = new System.Drawing.Size(140, 32);
            this.mtbGraduationEdit.TabIndex = 29;
            // 
            // lblFamEdit
            // 
            this.lblFamEdit.AutoSize = true;
            this.lblFamEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFamEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFamEdit.Location = new System.Drawing.Point(12, 11);
            this.lblFamEdit.Name = "lblFamEdit";
            this.lblFamEdit.Size = new System.Drawing.Size(109, 25);
            this.lblFamEdit.TabIndex = 0;
            this.lblFamEdit.Text = "Фамилия:";
            // 
            // mtbPhoneEdit
            // 
            this.mtbPhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbPhoneEdit.Location = new System.Drawing.Point(185, 163);
            this.mtbPhoneEdit.Mask = "+7(000)000-00-00";
            this.mtbPhoneEdit.Name = "mtbPhoneEdit";
            this.mtbPhoneEdit.Size = new System.Drawing.Size(140, 32);
            this.mtbPhoneEdit.TabIndex = 28;
            // 
            // rtbFamEdit
            // 
            this.rtbFamEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbFamEdit.Location = new System.Drawing.Point(185, 8);
            this.rtbFamEdit.Name = "rtbFamEdit";
            this.rtbFamEdit.Size = new System.Drawing.Size(140, 33);
            this.rtbFamEdit.TabIndex = 1;
            this.rtbFamEdit.Text = "";
            this.rtbFamEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbFamEdit_KeyPress);
            // 
            // rtbEmailEdit
            // 
            this.rtbEmailEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbEmailEdit.Location = new System.Drawing.Point(856, 86);
            this.rtbEmailEdit.Name = "rtbEmailEdit";
            this.rtbEmailEdit.Size = new System.Drawing.Size(140, 33);
            this.rtbEmailEdit.TabIndex = 22;
            this.rtbEmailEdit.Text = "";
            // 
            // lblImEdit
            // 
            this.lblImEdit.AutoSize = true;
            this.lblImEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblImEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblImEdit.Location = new System.Drawing.Point(12, 50);
            this.lblImEdit.Name = "lblImEdit";
            this.lblImEdit.Size = new System.Drawing.Size(60, 25);
            this.lblImEdit.TabIndex = 2;
            this.lblImEdit.Text = "Имя:";
            // 
            // lblEmailEdit
            // 
            this.lblEmailEdit.AutoSize = true;
            this.lblEmailEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmailEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmailEdit.Location = new System.Drawing.Point(673, 89);
            this.lblEmailEdit.Name = "lblEmailEdit";
            this.lblEmailEdit.Size = new System.Drawing.Size(73, 25);
            this.lblEmailEdit.TabIndex = 26;
            this.lblEmailEdit.Text = "E-mail:";
            // 
            // rtbImEdit
            // 
            this.rtbImEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbImEdit.Location = new System.Drawing.Point(185, 47);
            this.rtbImEdit.Name = "rtbImEdit";
            this.rtbImEdit.Size = new System.Drawing.Size(140, 33);
            this.rtbImEdit.TabIndex = 3;
            this.rtbImEdit.Text = "";
            this.rtbImEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbImEdit_KeyPress);
            // 
            // cbFormEdit
            // 
            this.cbFormEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFormEdit.FormattingEnabled = true;
            this.cbFormEdit.ItemHeight = 25;
            this.cbFormEdit.Items.AddRange(new object[] {
            "бюджетная",
            "коммерция",
            "целевая"});
            this.cbFormEdit.Location = new System.Drawing.Point(856, 8);
            this.cbFormEdit.Name = "cbFormEdit";
            this.cbFormEdit.Size = new System.Drawing.Size(140, 33);
            this.cbFormEdit.TabIndex = 25;
            // 
            // lblOtchEdit
            // 
            this.lblOtchEdit.AutoSize = true;
            this.lblOtchEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOtchEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblOtchEdit.Location = new System.Drawing.Point(12, 89);
            this.lblOtchEdit.Name = "lblOtchEdit";
            this.lblOtchEdit.Size = new System.Drawing.Size(110, 25);
            this.lblOtchEdit.TabIndex = 4;
            this.lblOtchEdit.Text = "Отчество:";
            // 
            // lblFormEdit
            // 
            this.lblFormEdit.AutoSize = true;
            this.lblFormEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFormEdit.Location = new System.Drawing.Point(673, 11);
            this.lblFormEdit.Name = "lblFormEdit";
            this.lblFormEdit.Size = new System.Drawing.Size(177, 25);
            this.lblFormEdit.TabIndex = 24;
            this.lblFormEdit.Text = "Форма обучения:";
            // 
            // rtbOtchEdit
            // 
            this.rtbOtchEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbOtchEdit.Location = new System.Drawing.Point(185, 86);
            this.rtbOtchEdit.Name = "rtbOtchEdit";
            this.rtbOtchEdit.Size = new System.Drawing.Size(140, 33);
            this.rtbOtchEdit.TabIndex = 5;
            this.rtbOtchEdit.Text = "";
            this.rtbOtchEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbOtchEdit_KeyPress);
            // 
            // lblGraduationEdit
            // 
            this.lblGraduationEdit.AutoSize = true;
            this.lblGraduationEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGraduationEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGraduationEdit.Location = new System.Drawing.Point(673, 50);
            this.lblGraduationEdit.Name = "lblGraduationEdit";
            this.lblGraduationEdit.Size = new System.Drawing.Size(132, 25);
            this.lblGraduationEdit.TabIndex = 23;
            this.lblGraduationEdit.Text = "Год выпуска:";
            // 
            // dtpBirthdayEdit
            // 
            this.dtpBirthdayEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirthdayEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthdayEdit.Location = new System.Drawing.Point(185, 125);
            this.dtpBirthdayEdit.Name = "dtpBirthdayEdit";
            this.dtpBirthdayEdit.Size = new System.Drawing.Size(140, 32);
            this.dtpBirthdayEdit.TabIndex = 6;
            this.dtpBirthdayEdit.Value = new System.DateTime(2022, 5, 2, 0, 0, 0, 0);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnEditStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStudent.FlatAppearance.BorderSize = 2;
            this.btnEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditStudent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditStudent.Image = global::Students.Properties.Resources.pen;
            this.btnEditStudent.Location = new System.Drawing.Point(678, 125);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(318, 72);
            this.btnEditStudent.TabIndex = 27;
            this.btnEditStudent.Text = "Изменить данные";
            this.btnEditStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditStudent.UseVisualStyleBackColor = false;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // lblFacultyEdit
            // 
            this.lblFacultyEdit.AutoSize = true;
            this.lblFacultyEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFacultyEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFacultyEdit.Location = new System.Drawing.Point(357, 11);
            this.lblFacultyEdit.Name = "lblFacultyEdit";
            this.lblFacultyEdit.Size = new System.Drawing.Size(123, 25);
            this.lblFacultyEdit.TabIndex = 8;
            this.lblFacultyEdit.Text = "Факультет:";
            // 
            // lblPhoneEdit
            // 
            this.lblPhoneEdit.AutoSize = true;
            this.lblPhoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPhoneEdit.Location = new System.Drawing.Point(12, 167);
            this.lblPhoneEdit.Name = "lblPhoneEdit";
            this.lblPhoneEdit.Size = new System.Drawing.Size(105, 25);
            this.lblPhoneEdit.TabIndex = 19;
            this.lblPhoneEdit.Text = "Телефон:";
            // 
            // lblBirthdayEdit
            // 
            this.lblBirthdayEdit.AutoSize = true;
            this.lblBirthdayEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBirthdayEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBirthdayEdit.Location = new System.Drawing.Point(12, 128);
            this.lblBirthdayEdit.Name = "lblBirthdayEdit";
            this.lblBirthdayEdit.Size = new System.Drawing.Size(167, 25);
            this.lblBirthdayEdit.TabIndex = 9;
            this.lblBirthdayEdit.Text = "Дата рождения:";
            // 
            // lblGrEdit
            // 
            this.lblGrEdit.AutoSize = true;
            this.lblGrEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGrEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGrEdit.Location = new System.Drawing.Point(357, 167);
            this.lblGrEdit.Name = "lblGrEdit";
            this.lblGrEdit.Size = new System.Drawing.Size(82, 25);
            this.lblGrEdit.TabIndex = 18;
            this.lblGrEdit.Text = "Группа:";
            // 
            // cbFacultyEdit
            // 
            this.cbFacultyEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFacultyEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFacultyEdit.FormattingEnabled = true;
            this.cbFacultyEdit.ItemHeight = 25;
            this.cbFacultyEdit.Items.AddRange(new object[] {
            "ФИРТ",
            "АВИЭТ",
            "ФАДЭТ",
            "ИАТМ",
            "ФЗЧС",
            "ИНЭК"});
            this.cbFacultyEdit.Location = new System.Drawing.Point(502, 8);
            this.cbFacultyEdit.Name = "cbFacultyEdit";
            this.cbFacultyEdit.Size = new System.Drawing.Size(140, 33);
            this.cbFacultyEdit.TabIndex = 10;
            this.cbFacultyEdit.SelectedIndexChanged += new System.EventHandler(this.cbFacultyEdit_SelectedIndexChanged);
            // 
            // lblDirectionEdit
            // 
            this.lblDirectionEdit.AutoSize = true;
            this.lblDirectionEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDirectionEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDirectionEdit.Location = new System.Drawing.Point(357, 50);
            this.lblDirectionEdit.Name = "lblDirectionEdit";
            this.lblDirectionEdit.Size = new System.Drawing.Size(139, 25);
            this.lblDirectionEdit.TabIndex = 11;
            this.lblDirectionEdit.Text = "Направление:";
            // 
            // cbCourseEdit
            // 
            this.cbCourseEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourseEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCourseEdit.FormattingEnabled = true;
            this.cbCourseEdit.ItemHeight = 25;
            this.cbCourseEdit.Location = new System.Drawing.Point(502, 125);
            this.cbCourseEdit.Name = "cbCourseEdit";
            this.cbCourseEdit.Size = new System.Drawing.Size(140, 33);
            this.cbCourseEdit.TabIndex = 16;
            // 
            // cbDirectionEdit
            // 
            this.cbDirectionEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDirectionEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDirectionEdit.FormattingEnabled = true;
            this.cbDirectionEdit.ItemHeight = 25;
            this.cbDirectionEdit.Location = new System.Drawing.Point(502, 47);
            this.cbDirectionEdit.Name = "cbDirectionEdit";
            this.cbDirectionEdit.Size = new System.Drawing.Size(140, 33);
            this.cbDirectionEdit.TabIndex = 12;
            this.cbDirectionEdit.SelectedIndexChanged += new System.EventHandler(this.cbDirectionEdit_SelectedIndexChanged);
            // 
            // lblCourseEdit
            // 
            this.lblCourseEdit.AutoSize = true;
            this.lblCourseEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCourseEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCourseEdit.Location = new System.Drawing.Point(357, 128);
            this.lblCourseEdit.Name = "lblCourseEdit";
            this.lblCourseEdit.Size = new System.Drawing.Size(60, 25);
            this.lblCourseEdit.TabIndex = 15;
            this.lblCourseEdit.Text = "Курс:";
            // 
            // lblLevelEdit
            // 
            this.lblLevelEdit.AutoSize = true;
            this.lblLevelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLevelEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLevelEdit.Location = new System.Drawing.Point(357, 89);
            this.lblLevelEdit.Name = "lblLevelEdit";
            this.lblLevelEdit.Size = new System.Drawing.Size(94, 25);
            this.lblLevelEdit.TabIndex = 13;
            this.lblLevelEdit.Text = "Уровень:";
            // 
            // cbLevelEdit
            // 
            this.cbLevelEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbLevelEdit.FormattingEnabled = true;
            this.cbLevelEdit.ItemHeight = 25;
            this.cbLevelEdit.Items.AddRange(new object[] {
            "бакалавриат",
            "специалитет",
            "магистратура"});
            this.cbLevelEdit.Location = new System.Drawing.Point(502, 86);
            this.cbLevelEdit.Name = "cbLevelEdit";
            this.cbLevelEdit.Size = new System.Drawing.Size(140, 33);
            this.cbLevelEdit.TabIndex = 14;
            this.cbLevelEdit.SelectedIndexChanged += new System.EventHandler(this.cbLevelEdit_SelectedIndexChanged);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1008, 664);
            this.Controls.Add(this.panelBoxesEdit);
            this.Controls.Add(this.panelDB_Edit);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.panelDB_Edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB_Edit)).EndInit();
            this.panelBoxesEdit.ResumeLayout(false);
            this.panelBoxesEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDB_Edit;
        private System.Windows.Forms.DataGridView dgvDB_Edit;
        private System.Windows.Forms.Panel panelBoxesEdit;
        private System.Windows.Forms.RichTextBox rtbGrEdit;
        private System.Windows.Forms.MaskedTextBox mtbGraduationEdit;
        private System.Windows.Forms.Label lblFamEdit;
        private System.Windows.Forms.MaskedTextBox mtbPhoneEdit;
        private System.Windows.Forms.RichTextBox rtbFamEdit;
        private System.Windows.Forms.RichTextBox rtbEmailEdit;
        private System.Windows.Forms.Label lblImEdit;
        private System.Windows.Forms.Label lblEmailEdit;
        private System.Windows.Forms.RichTextBox rtbImEdit;
        private System.Windows.Forms.ComboBox cbFormEdit;
        private System.Windows.Forms.Label lblOtchEdit;
        private System.Windows.Forms.Label lblFormEdit;
        private System.Windows.Forms.RichTextBox rtbOtchEdit;
        private System.Windows.Forms.Label lblGraduationEdit;
        private System.Windows.Forms.DateTimePicker dtpBirthdayEdit;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Label lblFacultyEdit;
        private System.Windows.Forms.Label lblPhoneEdit;
        private System.Windows.Forms.Label lblBirthdayEdit;
        private System.Windows.Forms.Label lblGrEdit;
        private System.Windows.Forms.ComboBox cbFacultyEdit;
        private System.Windows.Forms.Label lblDirectionEdit;
        private System.Windows.Forms.ComboBox cbCourseEdit;
        private System.Windows.Forms.ComboBox cbDirectionEdit;
        private System.Windows.Forms.Label lblCourseEdit;
        private System.Windows.Forms.Label lblLevelEdit;
        private System.Windows.Forms.ComboBox cbLevelEdit;
    }
}