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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();

        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            //Doctor List Pull
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doctors", conn.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Chosen Specialty Pull
            SqlCommand cmd2 = new SqlCommand("Select SpecialtyName From Tbl_Specialty", conn.connection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                CmbSpecialty.Items.Add(dr2[0]);
            }
            conn.connection().Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Doctors (DoctorName,DoctorSurname,DoctorSpecialty,DoctorIN,DoctorPassword) values (@p1,@p2,@p3,@p4,@p5)", conn.connection());
            cmd.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", CmbSpecialty.Text);
            cmd.Parameters.AddWithValue("@p4", MskIN.Text);
            cmd.Parameters.AddWithValue("@p5", TxtPassword.Text);
            
            cmd.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Registration is complate\nPassword: " + TxtPassword.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            MskIN.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
            CmbSpecialty.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Update Tbl_Doctors SET DoctorName=@p1,DoctorSurname=@p2,DoctorSpecialty=@p3,DoctorPassword=@p4 where DoctorIN=@p5", conn.connection());
            cmd2.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd2.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd2.Parameters.AddWithValue("@p3", CmbSpecialty.Text);
            cmd2.Parameters.AddWithValue("@p4", TxtPassword.Text);
            cmd2.Parameters.AddWithValue("@p5", MskIN.Text);
            
            cmd2.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Your Update is complate\nPassword: " + TxtPassword.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("Delete from Tbl_Doctors where DoctorIN=@p6", conn.connection());
            cmd3.Parameters.AddWithValue("@p6",MskIN.Text);
            cmd3.ExecuteNonQuery();
            conn.connection().Close ();
            MessageBox.Show("Member is deleted");
        }
    }
}
