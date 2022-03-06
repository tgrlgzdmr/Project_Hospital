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
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void LnkSingin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientSingIn fr = new FrmPatientSingIn();
            fr.Show();
            
        }
        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Patients Where PatientIN=@p1 and PatientPassword=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", MskIN.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmPatientDetail fr = new FrmPatientDetail();
                fr.IN=MskIN.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password or IN");
            }
        }

        private void FrmPatientLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
