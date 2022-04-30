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
            this.lblTempDatabase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTempDatabase
            // 
            this.lblTempDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTempDatabase.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTempDatabase.Location = new System.Drawing.Point(0, 0);
            this.lblTempDatabase.Name = "lblTempDatabase";
            this.lblTempDatabase.Size = new System.Drawing.Size(1008, 204);
            this.lblTempDatabase.TabIndex = 0;
            this.lblTempDatabase.Text = "Database";
            this.lblTempDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1008, 204);
            this.Controls.Add(this.lblTempDatabase);
            this.Name = "FormDatabase";
            this.Text = "FormDatabase";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTempDatabase;
    }
}