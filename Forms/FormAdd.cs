using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Students.Forms
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private SqlConnection sqlConnection = null;
        
        private void FormAdd_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
            sqlConnection.Open();
        }

        void CheckLetters(KeyPressEventArgs e) //Проверка на буквы русского алфавита
        {
            char l = e.KeyChar;
            if (l < 'А' || l > 'я')
            {
                e.Handled = true;
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Students] (Fam, Im, Otch, Birthday, Faculty, Direction, Level, Course, Gr, Form, Graduation, Phone, Email) VALUES (@Fam, @Im, @Otch, @Birthday, @Faculty, @Direction, @Level, @Course, @Gr, @Form, @Graduation, @Phone, @Email)", sqlConnection);

            command.Parameters.AddWithValue("Fam", rtbFamAdd.Text);
            command.Parameters.AddWithValue("Im", rtbImAdd.Text);
            command.Parameters.AddWithValue("Otch", rtbOtchAdd.Text);
            command.Parameters.AddWithValue("Birthday", dtpBirthdayAdd.Text);
            command.Parameters.AddWithValue("Faculty", cbFacultyAdd.Text);
            command.Parameters.AddWithValue("Direction", cbDirectionAdd.Text);
            command.Parameters.AddWithValue("Level", cbLevelAdd.Text);
            command.Parameters.AddWithValue("Course", cbCourseAdd.Text);
            command.Parameters.AddWithValue("Gr", rtbGrAdd.Text);
            command.Parameters.AddWithValue("Form", cbFormAdd.Text);
            command.Parameters.AddWithValue("Graduation", mtbGraduationAdd.Text);
            command.Parameters.AddWithValue("Phone", mtbPhoneAdd.Text);
            command.Parameters.AddWithValue("Email", rtbEmailAdd.Text);

            command.ExecuteNonQuery();
        }

        private void rtbFamAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckLetters(e);
        }

        private void rtbImAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckLetters(e);
        }

        private void rtbOtchAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckLetters(e);
        }

        private void cbFacultyAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDirectionAdd.Items.Clear();
            cbDirectionAdd.Text = "";
            switch (cbFacultyAdd.Text)
            {
                case "ФИРТ":
                    cbDirectionAdd.Items.AddRange(new string[] { "ПРО", "МО", "ИВТ", "ПИ", "БИБ", "ИБ" });
                    break;
                case "АВИЭТ":
                    cbDirectionAdd.Items.AddRange(new string[] { "ИКТ", "БТС", "П", "СУЛА", "ЭН", "ЭЭ"});
                    break;
                case "ФАДЭТ":
                    cbDirectionAdd.Items.AddRange(new string[] { "ТЭТ", "ТЭД", "ПАД", "ЭМД", "ДЛМ", "АС" });
                    break;
                case "ИАТМ":
                    cbDirectionAdd.Items.AddRange(new string[] { "АТП", "КТО", "МА", "ММ", "МХ", "НИ" });
                    break;
                case "ФЗЧС":
                    cbDirectionAdd.Items.AddRange(new string[] { "ПБ", "ТБ"});
                    break;
                case "ИНЭК":
                    cbDirectionAdd.Items.AddRange(new string[] { "БИ", "И", "М", "ФЭБ", "УП", "ЭК" });
                    break;
            }
        }

        private void cbDirectionAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLevelAdd.Items.Clear();
            cbLevelAdd.Text = "";
            switch (cbDirectionAdd.Text)
            {
                case "СУЛА":
                    cbLevelAdd.Items.Add("специалитет");
                    cbLevelAdd.Text = ("специалитет");
                    break;
                case "ПБ":
                    cbLevelAdd.Items.Add("специалитет");
                    cbLevelAdd.Text = ("специалитет");
                    break;
                default:
                    cbLevelAdd.Items.AddRange(new string[] { "бакалавриат", "магистратура"});
                    break;
            }
        }

        private void cbLevelAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCourseAdd.Items.Clear();
            cbCourseAdd.Text = "";
            switch (cbLevelAdd.Text)
            {
                case "бакалавриат":
                    cbCourseAdd.Items.AddRange(new string[] { "1", "2", "3", "4" });
                    break;
                case "магистратура":
                    cbCourseAdd.Items.AddRange(new string[] { "1", "2" });
                    break;
                case "специалитет":
                    cbCourseAdd.Items.AddRange(new string[] { "1", "2", "3", "4", "5"});
                    break;
            }
        }

        private void rtbGrAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
