namespace Project_Hospital
{
    partial class FrmSecretaryDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretaryDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblIN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RTxtAnnoucement = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ChkSituation = new System.Windows.Forms.CheckBox();
            this.MskIN = new System.Windows.Forms.MaskedTextBox();
            this.CmbDr = new System.Windows.Forms.ComboBox();
            this.CmbSpecialty = new System.Windows.Forms.ComboBox();
            this.MskTime = new System.Windows.Forms.MaskedTextBox();
            this.MskDate = new System.Windows.Forms.MaskedTextBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnAppointmentList = new System.Windows.Forms.Button();
            this.BtnSpecialtyPanel = new System.Windows.Forms.Button();
            this.BtnDrPanel = new System.Windows.Forms.Button();
            this.BtnAnons = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNameSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblIN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secretary Information";
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Location = new System.Drawing.Point(148, 73);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(76, 23);
            this.LblNameSurname.TabIndex = 5;
            this.LblNameSurname.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name Surname:";
            // 
            // LblIN
            // 
            this.LblIN.AutoSize = true;
            this.LblIN.Location = new System.Drawing.Point(148, 36);
            this.LblIN.Name = "LblIN";
            this.LblIN.Size = new System.Drawing.Size(120, 23);
            this.LblIN.TabIndex = 1;
            this.LblIN.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "IN:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.RTxtAnnoucement);
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 325);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Annoucement";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(404, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RTxtAnnoucement
            // 
            this.RTxtAnnoucement.Location = new System.Drawing.Point(6, 30);
            this.RTxtAnnoucement.Name = "RTxtAnnoucement";
            this.RTxtAnnoucement.Size = new System.Drawing.Size(408, 238);
            this.RTxtAnnoucement.TabIndex = 0;
            this.RTxtAnnoucement.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnUpdate);
            this.groupBox3.Controls.Add(this.BtnSave);
            this.groupBox3.Controls.Add(this.ChkSituation);
            this.groupBox3.Controls.Add(this.MskIN);
            this.groupBox3.Controls.Add(this.CmbDr);
            this.groupBox3.Controls.Add(this.CmbSpecialty);
            this.groupBox3.Controls.Add(this.MskTime);
            this.groupBox3.Controls.Add(this.MskDate);
            this.groupBox3.Controls.Add(this.Txtid);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(439, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 467);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment Panel";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(97, 338);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(195, 44);
            this.BtnUpdate.TabIndex = 19;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(97, 288);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(195, 44);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ChkSituation
            // 
            this.ChkSituation.AutoSize = true;
            this.ChkSituation.Location = new System.Drawing.Point(97, 255);
            this.ChkSituation.Name = "ChkSituation";
            this.ChkSituation.Size = new System.Drawing.Size(100, 27);
            this.ChkSituation.TabIndex = 18;
            this.ChkSituation.Text = "Situation";
            this.ChkSituation.UseVisualStyleBackColor = true;
            this.ChkSituation.CheckedChanged += new System.EventHandler(this.ChkSituation_CheckedChanged);
            // 
            // MskIN
            // 
            this.MskIN.Location = new System.Drawing.Point(97, 218);
            this.MskIN.Mask = "00000000000";
            this.MskIN.Name = "MskIN";
            this.MskIN.Size = new System.Drawing.Size(195, 31);
            this.MskIN.TabIndex = 17;
            this.MskIN.ValidatingType = typeof(int);
            // 
            // CmbDr
            // 
            this.CmbDr.FormattingEnabled = true;
            this.CmbDr.Location = new System.Drawing.Point(97, 181);
            this.CmbDr.Name = "CmbDr";
            this.CmbDr.Size = new System.Drawing.Size(195, 31);
            this.CmbDr.TabIndex = 16;
            // 
            // CmbSpecialty
            // 
            this.CmbSpecialty.FormattingEnabled = true;
            this.CmbSpecialty.Location = new System.Drawing.Point(97, 144);
            this.CmbSpecialty.Name = "CmbSpecialty";
            this.CmbSpecialty.Size = new System.Drawing.Size(195, 31);
            this.CmbSpecialty.TabIndex = 15;
            this.CmbSpecialty.SelectedIndexChanged += new System.EventHandler(this.CmbSpecialty_SelectedIndexChanged);
            // 
            // MskTime
            // 
            this.MskTime.Location = new System.Drawing.Point(97, 107);
            this.MskTime.Mask = "00:00";
            this.MskTime.Name = "MskTime";
            this.MskTime.Size = new System.Drawing.Size(195, 31);
            this.MskTime.TabIndex = 14;
            this.MskTime.ValidatingType = typeof(System.DateTime);
            // 
            // MskDate
            // 
            this.MskDate.Location = new System.Drawing.Point(97, 70);
            this.MskDate.Mask = "00/00/0000";
            this.MskDate.Name = "MskDate";
            this.MskDate.Size = new System.Drawing.Size(195, 31);
            this.MskDate.TabIndex = 13;
            this.MskDate.ValidatingType = typeof(System.DateTime);
            this.MskDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(97, 33);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(195, 31);
            this.Txtid.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "IN:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Doctor:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Specialty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(743, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(524, 246);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Specialties";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(743, 262);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(524, 314);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doctors";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(518, 284);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnAnons);
            this.groupBox6.Controls.Add(this.BtnAppointmentList);
            this.groupBox6.Controls.Add(this.BtnSpecialtyPanel);
            this.groupBox6.Controls.Add(this.BtnDrPanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 486);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(725, 90);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // BtnAppointmentList
            // 
            this.BtnAppointmentList.Location = new System.Drawing.Point(363, 30);
            this.BtnAppointmentList.Name = "BtnAppointmentList";
            this.BtnAppointmentList.Size = new System.Drawing.Size(167, 44);
            this.BtnAppointmentList.TabIndex = 4;
            this.BtnAppointmentList.Text = "Appointment List";
            this.BtnAppointmentList.UseVisualStyleBackColor = true;
            this.BtnAppointmentList.Click += new System.EventHandler(this.BtnAppointmentList_Click);
            // 
            // BtnSpecialtyPanel
            // 
            this.BtnSpecialtyPanel.Location = new System.Drawing.Point(174, 30);
            this.BtnSpecialtyPanel.Name = "BtnSpecialtyPanel";
            this.BtnSpecialtyPanel.Size = new System.Drawing.Size(183, 44);
            this.BtnSpecialtyPanel.TabIndex = 3;
            this.BtnSpecialtyPanel.Text = "Specialties Panel";
            this.BtnSpecialtyPanel.UseVisualStyleBackColor = true;
            this.BtnSpecialtyPanel.Click += new System.EventHandler(this.BtnSpecialtyPanel_Click);
            // 
            // BtnDrPanel
            // 
            this.BtnDrPanel.Location = new System.Drawing.Point(21, 30);
            this.BtnDrPanel.Name = "BtnDrPanel";
            this.BtnDrPanel.Size = new System.Drawing.Size(147, 44);
            this.BtnDrPanel.TabIndex = 2;
            this.BtnDrPanel.Text = "Doctors Panel";
            this.BtnDrPanel.UseVisualStyleBackColor = true;
            this.BtnDrPanel.Click += new System.EventHandler(this.BtnDrPanel_Click);
            // 
            // BtnAnons
            // 
            this.BtnAnons.Location = new System.Drawing.Point(536, 30);
            this.BtnAnons.Name = "BtnAnons";
            this.BtnAnons.Size = new System.Drawing.Size(183, 44);
            this.BtnAnons.TabIndex = 5;
            this.BtnAnons.Text = "Annoucement Panel";
            this.BtnAnons.UseVisualStyleBackColor = true;
            this.BtnAnons.Click += new System.EventHandler(this.BtnAnons_Click);
            // 
            // FrmSecretaryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1302, 586);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "FrmSecretaryDetail";
            this.Text = "Secretary Detail";
            this.Load += new System.EventHandler(this.FrmSecretaryDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox RTxtAnnoucement;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ChkSituation;
        private System.Windows.Forms.MaskedTextBox MskIN;
        private System.Windows.Forms.ComboBox CmbDr;
        private System.Windows.Forms.ComboBox CmbSpecialty;
        private System.Windows.Forms.MaskedTextBox MskTime;
        private System.Windows.Forms.MaskedTextBox MskDate;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnAppointmentList;
        private System.Windows.Forms.Button BtnSpecialtyPanel;
        private System.Windows.Forms.Button BtnDrPanel;
        private System.Windows.Forms.Button BtnAnons;
    }
}