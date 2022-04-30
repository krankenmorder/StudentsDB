using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Button currentButton;
        private Form activeForm;

        // Анимация кнопок
        private void ActivateButton(object btnSender, Color color)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        // Обработчики нажатия на кнопки
        private void btnDatabase_Click(object sender, EventArgs e)
        {
            Color color = Color.Blue;
            OpenChildForm(new Forms.FormDatabase(), sender, color);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Color color = Color.Green;
            OpenChildForm(new Forms.FormAdd(), sender, color);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Color color = Color.Orange;
            OpenChildForm(new Forms.FormEdit(), sender, color);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Color color = Color.Red;
            OpenChildForm(new Forms.FormDelete(), sender, color);
        }

        // 

        private void OpenChildForm(Form childForm, object btnSender, Color color)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender, color); // Анимация кнопок
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelBottom.Controls.Add(childForm);
            this.panelBottom.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
