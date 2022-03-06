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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Secretary Where SecretaryIN=@p1 and SecretaryPassword=@p2", conn.connection());
            cmd.Parameters.AddWithValue("@p1", MskIN.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmSecretaryDetail fr = new FrmSecretaryDetail();
                fr.IN = MskIN.Text;
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
