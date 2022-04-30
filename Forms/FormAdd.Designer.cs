namespace Students.Forms
{
    partial class FormAdd
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
            this.lblTempAdd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTempAdd
            // 
            this.lblTempAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTempAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTempAdd.Location = new System.Drawing.Point(0, 0);
            this.lblTempAdd.Name = "lblTempAdd";
            this.lblTempAdd.Size = new System.Drawing.Size(1008, 204);
            this.lblTempAdd.TabIndex = 1;
            this.lblTempAdd.Text = "Add";
            this.lblTempAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1008, 204);
            this.Controls.Add(this.lblTempAdd);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTempAdd;
    }
}