namespace Students.Forms
{
    partial class FormDelete
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
            this.panelButtonDelete = new System.Windows.Forms.Panel();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.panelDB_Delete = new System.Windows.Forms.Panel();
            this.dgvDB_Delete = new System.Windows.Forms.DataGridView();
            this.panelButtonDelete.SuspendLayout();
            this.panelDB_Delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtonDelete
            // 
            this.panelButtonDelete.Controls.Add(this.btnDeleteStudent);
            this.panelButtonDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonDelete.Location = new System.Drawing.Point(0, 592);
            this.panelButtonDelete.Name = "panelButtonDelete";
            this.panelButtonDelete.Size = new System.Drawing.Size(1008, 72);
            this.panelButtonDelete.TabIndex = 1;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.btnDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteStudent.FlatAppearance.BorderSize = 2;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteStudent.Image = global::Students.Properties.Resources.clear;
            this.btnDeleteStudent.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(1008, 72);
            this.btnDeleteStudent.TabIndex = 28;
            this.btnDeleteStudent.Text = "    Удалить студента";
            this.btnDeleteStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // panelDB_Delete
            // 
            this.panelDB_Delete.Controls.Add(this.dgvDB_Delete);
            this.panelDB_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDB_Delete.Location = new System.Drawing.Point(0, 0);
            this.panelDB_Delete.Name = "panelDB_Delete";
            this.panelDB_Delete.Size = new System.Drawing.Size(1008, 592);
            this.panelDB_Delete.TabIndex = 2;
            // 
            // dgvDB_Delete
            // 
            this.dgvDB_Delete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDB_Delete.Location = new System.Drawing.Point(0, 0);
            this.dgvDB_Delete.Name = "dgvDB_Delete";
            this.dgvDB_Delete.ReadOnly = true;
            this.dgvDB_Delete.RowHeadersWidth = 62;
            this.dgvDB_Delete.RowTemplate.Height = 28;
            this.dgvDB_Delete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDB_Delete.Size = new System.Drawing.Size(1008, 592);
            this.dgvDB_Delete.TabIndex = 0;
            this.dgvDB_Delete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDB_Delete_CellClick);
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1008, 664);
            this.Controls.Add(this.panelDB_Delete);
            this.Controls.Add(this.panelButtonDelete);
            this.Name = "FormDelete";
            this.Text = "FormDelete";
            this.Load += new System.EventHandler(this.FormDelete_Load);
            this.panelButtonDelete.ResumeLayout(false);
            this.panelDB_Delete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB_Delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtonDelete;
        private System.Windows.Forms.Panel panelDB_Delete;
        private System.Windows.Forms.DataGridView dgvDB_Delete;
        private System.Windows.Forms.Button btnDeleteStudent;
    }
}