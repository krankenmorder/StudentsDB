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
            this.lblTempEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTempEdit
            // 
            this.lblTempEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTempEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTempEdit.Location = new System.Drawing.Point(0, 0);
            this.lblTempEdit.Name = "lblTempEdit";
            this.lblTempEdit.Size = new System.Drawing.Size(1008, 204);
            this.lblTempEdit.TabIndex = 1;
            this.lblTempEdit.Text = "Edit";
            this.lblTempEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1008, 204);
            this.Controls.Add(this.lblTempEdit);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTempEdit;
    }
}