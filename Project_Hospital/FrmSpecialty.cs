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

namespace Project_Hospital
{
    public partial class FrmSpecialty : Form
    {
        public FrmSpecialty()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSpecialty_Load(object sender, EventArgs e)
        {
            //Doctor List Pull
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Specialty", conn.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            TxtSpecialty.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Specialty (SpecialtyName) values (@p1)", conn.connection());
            cmd.Parameters.AddWithValue("@p1", TxtSpecialty.Text);
            

            cmd.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Specialty Created");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Delete from Tbl_Specialty where Specialtyid=@p2", conn.connection());
            cmd3.Parameters.AddWithValue("@p2", Txtid.Text);
            cmd3.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Specialty is deleted");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Update Tbl_Specialty SET SpecialtyName=@p1 where Specialtyid=@p2", conn.connection());
            cmd2.Parameters.AddWithValue("@p2", Txtid.Text);
            cmd2.Parameters.AddWithValue("@p1", TxtSpecialty.Text);
            cmd2.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Specialty Updated");
        }
    }
}
