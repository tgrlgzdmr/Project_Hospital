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
    public partial class FrmEditInformation : Form
    {
        public FrmEditInformation()
        {
            InitializeComponent();
        }
        public string TCIN;
        sqlconnection conn = new sqlconnection();
        private void FrmEditInformation_Load(object sender, EventArgs e)
        {
            MskIN.Text = TCIN;
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Patients where PatientIN=@p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", MskIN.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                
                MskPhoneNumber.Text = dr[4].ToString();
                TxtPassword.Text = dr[5].ToString();
                CmbGender.Text = dr[6].ToString();
            }
            conn.connection().Close();

        }

        private void BtnUpdateInfo_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Update Tbl_Patients SET PatientName=@p1,PatientSurname=@p2,PatientPhone=@p3,PatientPassword=@p4,PatientGender=@p5 where PatientIN=@p6",conn.connection());
            cmd2.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd2.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd2.Parameters.AddWithValue("@p3", MskPhoneNumber.Text);
            cmd2.Parameters.AddWithValue("@p4", TxtPassword.Text);
            cmd2.Parameters.AddWithValue("@p5", CmbGender.Text);
            cmd2.Parameters.AddWithValue("@p6", MskIN.Text);
            cmd2.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Your Update is complate\nPassword: " + TxtPassword.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
