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
    public partial class FrmPatientSingIn : Form
    {
        public FrmPatientSingIn()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnSingin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Patients (PatientName,PatientSurname,PatientIN,PatientPhone,PatientPassword,PatientGender) values (@p1,@p2,@p3,@p4,@p5,@p6)", conn.connection());
            cmd.Parameters.AddWithValue("@p1", TxtName.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
            cmd.Parameters.AddWithValue("@p3", MskIN.Text);
            cmd.Parameters.AddWithValue("@p4", MskPhoneNumber.Text);
            cmd.Parameters.AddWithValue("@p5", TxtPassword.Text);
            cmd.Parameters.AddWithValue("@p6", CmbGender.Text);
            cmd.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Your registration is complate\nPassword: " + TxtPassword.Text,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void FrmPatientSingIn_Load(object sender, EventArgs e)
        {

        }
    }
}
