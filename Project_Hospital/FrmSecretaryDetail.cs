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
    public partial class FrmSecretaryDetail : Form
    {
        public FrmSecretaryDetail()
        {
            InitializeComponent();
        }
        public string IN;
        sqlconnection conn = new sqlconnection();

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ChkSituation_CheckedChanged(object sender, EventArgs e)
        {

        }
        public string Appid;
        public string AppDate;
        public string AppClock;
        public string AppSpc;
        public string AppDoctor;
        public bool AppSt;
        public string AppPtIn;
        private void FrmSecretaryDetail_Load(object sender, EventArgs e)
        {
            Txtid.Text = Appid;
            MskDate.Text = AppDate;
            MskTime.Text = AppClock;
            CmbSpecialty.Text = AppSpc;
            CmbDr.Text=AppDoctor;
            ChkSituation.Checked=AppSt;
            MskIN.Text = AppPtIn;

            LblIN.Text = IN;
            //Name Surname Pull
            SqlCommand cmd = new SqlCommand("Select SecretaryNameSurname From Tbl_Secretary where SecretaryIN=@p1", conn.connection());
            cmd.Parameters.AddWithValue("@p1", LblIN.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[0].ToString();
            }
            conn.connection().Close();

            //Specialty List Pull
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Specialty", conn.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Doctor List Pull
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoctorName + ' ' + DoctorSurname) as DoctorNameSurname,DoctorSpecialty From Tbl_Doctors", conn.connection());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            //Chosen Specialty Pull
            SqlCommand cmd2 = new SqlCommand("Select SpecialtyName From Tbl_Specialty", conn.connection());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                CmbSpecialty.Items.Add(dr2[0]);
            }
            conn.connection().Close();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmdsave = new SqlCommand("insert into Tbl_Appointment (AppointmentDate,AppointmentClock,AppointmentSpecialty,AppointmentDoctor) values (@r1,@r2,@r3,@r4)", conn.connection());
            cmdsave.Parameters.AddWithValue("@r1", MskDate.Text);
            cmdsave.Parameters.AddWithValue("@r2", MskTime.Text);
            cmdsave.Parameters.AddWithValue("@r3", CmbSpecialty.Text);
            cmdsave.Parameters.AddWithValue("@r4", CmbDr.Text);
            cmdsave.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Appointmend Succesfully created");
        }

        private void CmbSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDr.Items.Clear();
            SqlCommand cmd3 = new SqlCommand("Select DoctorName,DoctorSurname from Tbl_Doctors where DoctorSpecialty=@p1", conn.connection());
            cmd3.Parameters.AddWithValue("@p1", CmbSpecialty.Text);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDr.Items.Add(dr3[0] + " " + dr3[1]);
                conn.connection().Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("insert into Tbl_Annoucements (Annoucement) values (@d5)", conn.connection());
            cmd4.Parameters.AddWithValue("@d5",RTxtAnnoucement.Text);
            cmd4.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Annoucement created");
        }

        private void BtnDrPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel drp = new FrmDoctorPanel();
            drp.Show();
        }

        private void BtnSpecialtyPanel_Click(object sender, EventArgs e)
        {
            FrmSpecialty spc =new FrmSpecialty();
            spc.Show();
        }
        


        private void BtnAppointmentList_Click(object sender, EventArgs e)
        {
            FrmAppointmentList app = new FrmAppointmentList();
            app.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd5 = new SqlCommand("Update [dbo].[Tbl_Appointment] SET [AppointmentDate]=@p1,[AppointmentClock]=@p2,[AppointmentSpecialty]=@p3,[AppointmentDoctor]=@p4,[AppointmentSituation]=@p5,[PatientIN]=@p6 where [Appointmentid]=@p7", conn.connection());
            cmd5.Parameters.AddWithValue("@p1", MskDate.Text);
            cmd5.Parameters.AddWithValue("@p2", MskTime.Text);
            cmd5.Parameters.AddWithValue("@p3", CmbSpecialty.Text);
            cmd5.Parameters.AddWithValue("@p4", CmbDr.Text);

            if (ChkSituation.Checked)
            {
                cmd5.Parameters.AddWithValue("@p5", 1);
            }
            else
            {
                cmd5.Parameters.AddWithValue("@p5", 0);
            }

            cmd5.Parameters.AddWithValue("@p6", MskIN.Text);
            cmd5.Parameters.AddWithValue("@p7", Txtid.Text);
            cmd5.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show("Your Update is complate");
        }

        private void BtnAnons_Click(object sender, EventArgs e)
        {
            FrmAnnoucements fra = new FrmAnnoucements();
            fra.Show();
        }
    }
}
