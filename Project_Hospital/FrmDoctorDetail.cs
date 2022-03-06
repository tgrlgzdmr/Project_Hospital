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
    public partial class FrmDoctorDetail : Form
    {
        public FrmDoctorDetail()
        {
            InitializeComponent();
        }
        public string DrIN;
        sqlconnection conn = new sqlconnection();

        private void FrmDoctorDetail_Load(object sender, EventArgs e)
        {
            LblIN.Text = DrIN;
            SqlCommand cmd = new SqlCommand("Select DoctorName + ' ' + DoctorSurname from Tbl_Doctors where DoctorIN=@p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1",DrIN);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                LblNameSurname.Text=dr[0].ToString();
            }
            conn.connection().Close();



            //Appointment List Pull
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointment where AppointmentDoctor='" + LblNameSurname.Text + "'", conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.connection().Close();
            
            
            


        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmDoctorInfoUpdate fr = new FrmDoctorInfoUpdate();
            fr.DRIN = DrIN;
            fr.Show();

        }

        private void BtnAnnouncements_Click(object sender, EventArgs e)
        {
            FrmAnnoucements frm = new FrmAnnoucements();
            frm.Show();
        }

        private void BtmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            RchDetail.Text = dataGridView1.Rows[chosen].Cells[7].Value.ToString();
            
        }

        
    }
}
