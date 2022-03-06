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
    public partial class FrmDoctorInfoUpdate : Form
    {
        public FrmDoctorInfoUpdate()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        public string DRIN;

        private void FrmDoctorInfoUpdate_Load(object sender, EventArgs e)
        {
            MskIN.Text = DRIN;
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Doctors where DoctorIN=@p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1",DRIN);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                TxtName.Text=dr[1].ToString();
                TxtSurname.Text=dr[2].ToString();
                TxtPassword.Text=dr[5].ToString();
                CmbSpecialty.Text=dr[3].ToString();
            }
            conn.connection().Close();
        }

        private void BtnUpdateInfo_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Update Tbl_Doctors SET DoctorName=@p1,DoctorSurname=@p2,DoctorSpecialty=@p3,DoctorPassword=@p4 where DoctorIN=@p5", conn.connection());
            cmd1.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd1.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd1.Parameters.AddWithValue("@p3", CmbSpecialty.Text);
            cmd1.Parameters.AddWithValue("@p4", TxtPassword.Text);
            cmd1.Parameters.AddWithValue("@p5", DRIN);
            cmd1.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Informations Updated");
        }
    }
}
