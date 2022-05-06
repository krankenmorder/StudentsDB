using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Students.Forms
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }

        int idEdit = 0;

        private SqlConnection sqlConnection = null;

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            //Fam, Im, Otch, Birthday, Faculty, Direction, Level, Course, Gr, Form, Graduation, Phone, Email
            SqlCommand command = new SqlCommand($"UPDATE [Students] SET [Fam] = @Fam, [Im] = @Im, [Otch] = @Otch, [Birthday] = @Birthday, [Faculty] = @Faculty, [Direction] = @Direction, [Level] = @Level, [Course] = @Course, [Gr] = @Gr, [Form] = @Form, [Graduation] = @Graduation, [Phone] = @Phone, [Email] = @Email " +
                $"WHERE Id={idEdit}", sqlConnection);

            command.Parameters.AddWithValue("Fam", rtbFamEdit.Text);
            command.Parameters.AddWithValue("Im", rtbImEdit.Text);
            command.Parameters.AddWithValue("Otch", rtbOtchEdit.Text);
            command.Parameters.AddWithValue("Birthday", dtpBirthdayEdit.Text);
            command.Parameters.AddWithValue("Faculty", cbFacultyEdit.Text);
            command.Parameters.AddWithValue("Direction", cbDirectionEdit.Text);
            command.Parameters.AddWithValue("Level", cbLevelEdit.Text);
            command.Parameters.AddWithValue("Course", cbCourseEdit.Text);
            command.Parameters.AddWithValue("Gr", rtbGrEdit.Text);
            command.Parameters.AddWithValue("Form", cbFormEdit.Text);
            command.Parameters.AddWithValue("Graduation", mtbGraduationEdit.Text);
            command.Parameters.AddWithValue("Phone", mtbPhoneEdit.Text);
            command.Parameters.AddWithValue("Email", rtbEmailEdit.Text);

            command.ExecuteNonQuery();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Students", sqlConnection);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dgvDB_Edit.DataSource = dataset.Tables[0];
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Students", sqlConnection);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dgvDB_Edit.DataSource = dataset.Tables[0];
        }

        void CheckLetters(KeyPressEventArgs e) //Проверка на буквы русского алфавита
        {
            char l = e.KeyChar;
            if (l < 'А' || l > 'я')
            {
                e.Handled = true;
            }
        }

        private void rtbFamEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckLetters(e);
        }

        private void rtbImEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckLetters(e);
        }

        private void rtbOtchEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckLetters(e);
        }

        private void cbFacultyEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDirectionEdit.Items.Clear();
            cbDirectionEdit.Text = "";
            switch (cbFacultyEdit.Text)
            {
                case "ФИРТ":
                    cbDirectionEdit.Items.AddRange(new string[] { "ПРО", "МО", "ИВТ", "ПИ", "БИБ", "ИБ" });
                    break;
                case "АВИЭТ":
                    cbDirectionEdit.Items.AddRange(new string[] { "ИКТ", "БТС", "П", "СУЛА", "ЭН", "ЭЭ" });
                    break;
                case "ФАДЭТ":
                    cbDirectionEdit.Items.AddRange(new string[] { "ТЭТ", "ТЭД", "ПАД", "ЭМД", "ДЛМ", "АС" });
                    break;
                case "ИАТМ":
                    cbDirectionEdit.Items.AddRange(new string[] { "АТП", "КТО", "МА", "ММ", "МХ", "НИ" });
                    break;
                case "ФЗЧС":
                    cbDirectionEdit.Items.AddRange(new string[] { "ПБ", "ТБ" });
                    break;
                case "ИНЭК":
                    cbDirectionEdit.Items.AddRange(new string[] { "БИ", "И", "М", "ФЭБ", "УП", "ЭК" });
                    break;
            }
        }

        private void cbDirectionEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLevelEdit.Items.Clear();
            cbLevelEdit.Text = "";
            switch (cbDirectionEdit.Text)
            {
                case "СУЛА":
                    cbLevelEdit.Items.Add("специалитет");
                    cbLevelEdit.Text = ("специалитет");
                    break;
                case "ПБ":
                    cbLevelEdit.Items.Add("специалитет");
                    cbLevelEdit.Text = ("специалитет");
                    break;
                default:
                    cbLevelEdit.Items.AddRange(new string[] { "бакалавриат", "магистратура" });
                    break;
            }
        }

        private void cbLevelEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCourseEdit.Items.Clear();
            cbCourseEdit.Text = "";
            switch (cbLevelEdit.Text)
            {
                case "бакалавриат":
                    cbCourseEdit.Items.AddRange(new string[] { "1", "2", "3", "4" });
                    break;
                case "магистратура":
                    cbCourseEdit.Items.AddRange(new string[] { "1", "2" });
                    break;
                case "специалитет":
                    cbCourseEdit.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
                    break;
            }
        }

        private void rtbGrEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void dgvDB_Edit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idEdit = Convert.ToInt32(dgvDB_Edit.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите заполненную строку БД.");
            }
            rtbFamEdit.Text = dgvDB_Edit.SelectedRows[0].Cells[1].Value.ToString();
            rtbImEdit.Text = dgvDB_Edit.SelectedRows[0].Cells[2].Value.ToString();
            rtbOtchEdit.Text = dgvDB_Edit.SelectedRows[0].Cells[3].Value.ToString();
            dtpBirthdayEdit.Text = dgvDB_Edit.SelectedRows[0].Cells[4].Value.ToString();
            cbFacultyEdit.Text = dgvDB_Edit.SelectedRows[0].Cells[5].Value.ToString();
            cbDirectionEdit.Text = dgvDB_Edit.SelectedRows[0].Cells[6].Value.ToString();
            cbLevelEdit.Text = dgvDB_Edit.SelectedRows[0].Cells[7].Value.ToString();
            cbCourseEdit.Text = dgvDB_Edit.SelectedRows[0].Cells[8].Value.ToString();
            rtbGrEdit.Text = dgvDB_Edit.SelectedRows[0].Cells[9].Value.ToString();
            cbFormEdit.Text = dgvDB_Edit.SelectedRows[0].Cells[10].Value.ToString();
            mtbGraduationEdit.Text = dgvDB_Edit.SelectedRows[0].Cells[11].Value.ToString();
            mtbPhoneEdit.Text = dgvDB_Edit.SelectedRows[0].Cells[12].Value.ToString();
            rtbEmailEdit.Text = dgvDB_Edit.SelectedRows[0].Cells[13].Value.ToString();
        }
    }
}
