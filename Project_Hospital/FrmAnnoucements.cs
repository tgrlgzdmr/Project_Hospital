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
    public partial class FrmAnnoucements : Form
    {
        public FrmAnnoucements()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();

        private void FrmAnnoucements_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Annoucements", conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
