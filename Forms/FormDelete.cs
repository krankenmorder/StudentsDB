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
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
        }
        int idDelete = 0;
        private SqlConnection sqlConnection = null;
        private void FormDelete_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Students", sqlConnection);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dgvDB_Delete.DataSource = dataset.Tables[0];
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand($"DELETE [Students] Where Id={idDelete}", sqlConnection);

            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Студент удалён из БД.");
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Students", sqlConnection);
            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dgvDB_Delete.DataSource = dataset.Tables[0];
        }

        private void dgvDB_Delete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idDelete = Convert.ToInt32(dgvDB_Delete.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите заполненную строку БД.");
            }
        }
    }
}
