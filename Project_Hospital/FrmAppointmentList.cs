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
    public partial class FrmAppointmentList : Form
    {
        public FrmAppointmentList()
        {
            InitializeComponent();
        }
        sqlconnection conn = new sqlconnection();

        private void FrmAppointmentList_Load(object sender, EventArgs e)
        {
            //Appointment List Pull
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Appointment", conn.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            
            FrmSecretaryDetail fr = new FrmSecretaryDetail();
            fr.Appid= dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            fr.AppDate= dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            fr.AppClock=dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            fr.AppSpc= dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            fr.AppDoctor= dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            if ((bool)dataGridView1.Rows[chosen].Cells[5].Value)
            {
                fr.AppSt= true;

            }
            else
            {
                fr.AppSt = false;

            }
            fr.AppPtIn= dataGridView1.Rows[chosen].Cells[6].Value.ToString();
            fr.Show();
            this.Hide();

        }
    }
}
