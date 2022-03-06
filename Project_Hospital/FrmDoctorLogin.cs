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
    public partial class FrmDoctorLogin : Form
    {
        public FrmDoctorLogin()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();

        private void MskIN_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmDoctorLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Doctors Where DoctorIN=@p1 and DoctorPassword=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", MskIN.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmDoctorDetail fr = new FrmDoctorDetail();
                fr.DrIN = MskIN.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password or IN");
            }
        }
    }
}
