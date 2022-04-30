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
            this.lblTempDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTempDelete
            // 
            this.lblTempDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTempDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTempDelete.Location = new System.Drawing.Point(0, 0);
            this.lblTempDelete.Name = "lblTempDelete";
            this.lblTempDelete.Size = new System.Drawing.Size(1008, 204);
            this.lblTempDelete.TabIndex = 1;
            this.lblTempDelete.Text = "Delete";
            this.lblTempDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1008, 204);
            this.Controls.Add(this.lblTempDelete);
            this.Name = "FormDelete";
            this.Text = "FormDelete";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTempDelete;
    }
}