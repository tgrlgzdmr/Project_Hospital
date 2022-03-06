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
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
        }

        public string IN;

        sqlconnection conn = new sqlconnection();
        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            LblIN.Text = IN;

            //Name Surname Pull
            SqlCommand cmd = new SqlCommand("Select PatientName, PatientSurname From Tbl_Patients where PatientIN=@p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", LblIN.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                LblNameSurname.Text= dr[0] + " " + dr[1];
            }
            conn.connection().Close();

            //Appointment History
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointment where PatientIN="+IN,conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Specialty Pull
            SqlCommand cmd2 = new SqlCommand("Select SpecialtyName From Tbl_Specialty",conn.connection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while( dr2.Read())
            {
                CmbSpecialty.Items.Add(dr2[0]);
            }
            conn.connection().Close();
        }

        private void CmbSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctors where DoctorSpecialty=@p1", conn.connection());
            cmd3.Parameters.AddWithValue("@p1", CmbSpecialty.Text);
            SqlDataReader dr3 =cmd3.ExecuteReader();
            while(dr3.Read())
            {
                CmbDoctor.Items.Add(dr3[0] + " " + dr3[1]);
                conn.connection().Close();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointment where (AppointmentSituation=0) and AppointmentSpecialty='" + CmbSpecialty.Text + "'", conn.connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointment where (AppointmentSituation=0) and AppointmentDoctor='" + CmbDoctor.Text + "'", conn.connection());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        
        private void LnkEditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEditInformation fr = new FrmEditInformation();
            fr.TCIN = LblIN.Text;
            fr.Show();
        }

        private void BtnAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("Update Tbl_Appointment SET AppointmentSituation=1, PatientIN=@p1, AppointmentDisease=@p2 where Appointmentid=@p3",conn.connection());
            cmd4.Parameters.AddWithValue("@p1",LblIN.Text);
            cmd4.Parameters.AddWithValue("@p2", RchDisease.Text);
            cmd4.Parameters.AddWithValue("@p3",Txtid.Text);
            cmd4.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Appointment created");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView2.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView2.Rows[chosen].Cells[0].Value.ToString();
            CmbDoctor.Text=dataGridView2.Rows[chosen].Cells[4].Value.ToString();

        }
    }
}
