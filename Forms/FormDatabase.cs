using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Students.Forms
{
    public partial class FormDatabase : Form
    {
        public FormDatabase()
        {
            InitializeComponent();
        }

        private SqlConnection sqlConnection = null;

        private void FormDatabase_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Students", sqlConnection);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dgvDB_Find.DataSource = dataset.Tables[0];
        }

        void CheckLetters(KeyPressEventArgs e) //Проверка на буквы русского алфавита
        {
            char l = e.KeyChar;
            if (l < 'А' || l > 'я')
            {
                e.Handled = true;
            }
        }


        private void rtbFamFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckLetters(e);
        }

        private void rtbImFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckLetters(e);
        }

        private void rtbOtchFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckLetters(e);
        }

        private void cbFacultyFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDirectionFind.Items.Clear();
            cbDirectionFind.Text = "";
            switch (cbFacultyFind.Text)
            {
                case "ФИРТ":
                    cbDirectionFind.Items.AddRange(new string[] { "ПРО", "МО", "ИВТ", "ПИ", "БИБ", "ИБ" });
                    break;
                case "АВИЭТ":
                    cbDirectionFind.Items.AddRange(new string[] { "ИКТ", "БТС", "П", "СУЛА", "ЭН", "ЭЭ" });
                    break;
                case "ФАДЭТ":
                    cbDirectionFind.Items.AddRange(new string[] { "ТЭТ", "ТЭД", "ПАД", "ЭМД", "ДЛМ", "АС" });
                    break;
                case "ИАТМ":
                    cbDirectionFind.Items.AddRange(new string[] { "АТП", "КТО", "МА", "ММ", "МХ", "НИ" });
                    break;
                case "ФЗЧС":
                    cbDirectionFind.Items.AddRange(new string[] { "ПБ", "ТБ" });
                    break;
                case "ИНЭК":
                    cbDirectionFind.Items.AddRange(new string[] { "БИ", "И", "М", "ФЭБ", "УП", "ЭК" });
                    break;
            }
        }

        private void cbDirectionFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLevelFind.Items.Clear();
            cbLevelFind.Text = "";
            switch (cbDirectionFind.Text)
            {
                case "СУЛА":
                    cbLevelFind.Items.Add("специалитет");
                    cbLevelFind.Text = ("специалитет");
                    break;
                case "ПБ":
                    cbLevelFind.Items.Add("специалитет");
                    cbLevelFind.Text = ("специалитет");
                    break;
                default:
                    cbLevelFind.Items.AddRange(new string[] { "бакалавриат", "магистратура" });
                    break;
            }
        }

        private void cbLevelFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCourseFind.Items.Clear();
            cbCourseFind.Text = "";
            switch (cbLevelFind.Text)
            {
                case "бакалавриат":
                    cbCourseFind.Items.AddRange(new string[] { "1", "2", "3", "4" });
                    break;
                case "магистратура":
                    cbCourseFind.Items.AddRange(new string[] { "1", "2" });
                    break;
                case "специалитет":
                    cbCourseFind.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
                    break;
            }
        }

        private void rtbGrFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT Id, [Fam], [Im], [Otch], " +
                    $"[Birthday], [Faculty], [Direction], [Level], [Course], [Gr], [Form], [Graduation],[Phone],[Email] FROM Students " +
                    $" WHERE[Fam] LIKE N'%{rtbFamFind.Text}%' and [Im] LIKE N'%{rtbImFind.Text}%' " +
                    $" and [Otch] LIKE N'%{rtbOtchFind.Text}%' and [Birthday] LIKE N'%{rtbBirthdayFind.Text}%' and [Faculty] LIKE N'%{cbFacultyFind.Text}%' and [Direction] LIKE N'%{cbDirectionFind.Text}%' and [Level] LIKE N'%{cbLevelFind.Text}%' and [Course] LIKE N'%{cbCourseFind.Text}%' and [Gr] LIKE N'%{rtbGrFind.Text}%' and [Form] LIKE N'%{cbFormFind.Text}%' and [Graduation] LIKE N'%{rtbGraduationFind.Text}%' and [Phone] LIKE N'%{rtbPhoneFind.Text}%' and [Email] LIKE N'%{rtbEmailFind.Text}%'", sqlConnection);

            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dgvDB_Find.DataSource = dataset.Tables[0];
        }
    }
}
