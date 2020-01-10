namespace BloodDonationSystem
{
    partial class Donor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.scbBlood = new System.Windows.Forms.ComboBox();
            this.sName = new System.Windows.Forms.TextBox();
            this.radioBloodS = new System.Windows.Forms.RadioButton();
            this.radioNameS = new System.Windows.Forms.RadioButton();
            this.radioIDS = new System.Windows.Forms.RadioButton();
            this.cbBlood = new System.Windows.Forms.ComboBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.donor_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.TextBox();
            this.txt_donor_id = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.scbBlood);
            this.panel1.Controls.Add(this.sName);
            this.panel1.Controls.Add(this.radioBloodS);
            this.panel1.Controls.Add(this.radioNameS);
            this.panel1.Controls.Add(this.radioIDS);
            this.panel1.Location = new System.Drawing.Point(597, 177);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 188);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(260, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Search By";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.BackgroundImage")));
            this.SearchBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchBtn.Location = new System.Drawing.Point(264, 148);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(92, 34);
            this.SearchBtn.TabIndex = 7;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // scbBlood
            // 
            this.scbBlood.AllowDrop = true;
            this.scbBlood.FormattingEnabled = true;
            this.scbBlood.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "AB-",
            "O-"});
            this.scbBlood.Location = new System.Drawing.Point(132, 106);
            this.scbBlood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scbBlood.Name = "scbBlood";
            this.scbBlood.Size = new System.Drawing.Size(354, 23);
            this.scbBlood.TabIndex = 8;
            this.scbBlood.Text = "A";
            this.scbBlood.SelectedIndexChanged += new System.EventHandler(this.scbBlood_SelectedIndexChanged);
            // 
            // sName
            // 
            this.sName.Location = new System.Drawing.Point(132, 108);
            this.sName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(354, 21);
            this.sName.TabIndex = 3;
            this.sName.TextChanged += new System.EventHandler(this.sName_TextChanged);
            // 
            // radioBloodS
            // 
            this.radioBloodS.AutoSize = true;
            this.radioBloodS.BackColor = System.Drawing.Color.Transparent;
            this.radioBloodS.Checked = true;
            this.radioBloodS.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBloodS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBloodS.Location = new System.Drawing.Point(421, 67);
            this.radioBloodS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBloodS.Name = "radioBloodS";
            this.radioBloodS.Size = new System.Drawing.Size(117, 25);
            this.radioBloodS.TabIndex = 4;
            this.radioBloodS.TabStop = true;
            this.radioBloodS.Text = "Blood Type";
            this.radioBloodS.UseVisualStyleBackColor = false;
            this.radioBloodS.CheckedChanged += new System.EventHandler(this.radioBloodS_CheckedChanged);
            // 
            // radioNameS
            // 
            this.radioNameS.AutoSize = true;
            this.radioNameS.BackColor = System.Drawing.Color.Transparent;
            this.radioNameS.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNameS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioNameS.Location = new System.Drawing.Point(124, 67);
            this.radioNameS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioNameS.Name = "radioNameS";
            this.radioNameS.Size = new System.Drawing.Size(71, 25);
            this.radioNameS.TabIndex = 4;
            this.radioNameS.Text = "Name";
            this.radioNameS.UseVisualStyleBackColor = false;
            this.radioNameS.CheckedChanged += new System.EventHandler(this.radioNameS_CheckedChanged);
            // 
            // radioIDS
            // 
            this.radioIDS.AutoSize = true;
            this.radioIDS.BackColor = System.Drawing.Color.Transparent;
            this.radioIDS.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIDS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioIDS.Location = new System.Drawing.Point(267, 67);
            this.radioIDS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioIDS.Name = "radioIDS";
            this.radioIDS.Size = new System.Drawing.Size(100, 25);
            this.radioIDS.TabIndex = 4;
            this.radioIDS.Text = "Donor_id";
            this.radioIDS.UseVisualStyleBackColor = false;
            this.radioIDS.CheckedChanged += new System.EventHandler(this.radioIDS_CheckedChanged);
            // 
            // cbBlood
            // 
            this.cbBlood.AllowDrop = true;
            this.cbBlood.FormattingEnabled = true;
            this.cbBlood.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "AB-",
            "O-"});
            this.cbBlood.Location = new System.Drawing.Point(347, 296);
            this.cbBlood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBlood.Name = "cbBlood";
            this.cbBlood.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbBlood.Size = new System.Drawing.Size(220, 23);
            this.cbBlood.TabIndex = 27;
            this.cbBlood.Text = "A+";
            this.cbBlood.SelectedIndexChanged += new System.EventHandler(this.cbBlood_SelectedIndexChanged);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpdateBtn.Location = new System.Drawing.Point(338, 521);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(99, 35);
            this.UpdateBtn.TabIndex = 25;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveBtn.Location = new System.Drawing.Point(163, 521);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(98, 35);
            this.SaveBtn.TabIndex = 24;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.BackColor = System.Drawing.Color.Transparent;
            this.radFemale.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radFemale.Location = new System.Drawing.Point(458, 401);
            this.radFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(81, 25);
            this.radFemale.TabIndex = 23;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = false;
            this.radFemale.CheckedChanged += new System.EventHandler(this.radFemale_CheckedChanged);
            // 
            // donor_name
            // 
            this.donor_name.Location = new System.Drawing.Point(347, 242);
            this.donor_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.donor_name.Name = "donor_name";
            this.donor_name.Size = new System.Drawing.Size(220, 21);
            this.donor_name.TabIndex = 20;
            this.donor_name.TextChanged += new System.EventHandler(this.donor_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(540, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "New Donor Entry";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(597, 378);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 197);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.BackColor = System.Drawing.Color.Transparent;
            this.radMale.Checked = true;
            this.radMale.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radMale.Location = new System.Drawing.Point(360, 401);
            this.radMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(64, 25);
            this.radMale.TabIndex = 22;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = false;
            this.radMale.CheckedChanged += new System.EventHandler(this.radMale_CheckedChanged);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(347, 452);
            this.txtphone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(220, 21);
            this.txtphone.TabIndex = 18;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(347, 354);
            this.dob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(220, 21);
            this.dob.TabIndex = 21;
            this.dob.TextChanged += new System.EventHandler(this.dob_TextChanged);
            // 
            // txt_donor_id
            // 
            this.txt_donor_id.Location = new System.Drawing.Point(347, 188);
            this.txt_donor_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_donor_id.Name = "txt_donor_id";
            this.txt_donor_id.Size = new System.Drawing.Size(216, 21);
            this.txt_donor_id.TabIndex = 19;
            this.txt_donor_id.TextChanged += new System.EventHandler(this.txt_donor_id_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(191, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Donor";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(455, 8);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(52, 15);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Hospital";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(743, 8);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(47, 15);
            this.linkLabel3.TabIndex = 0;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "History";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.Location = new System.Drawing.Point(1026, 8);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(46, 15);
            this.linkLabel4.TabIndex = 0;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Logout";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel4);
            this.panel2.Controls.Add(this.linkLabel3);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 40);
            this.panel2.TabIndex = 31;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(80, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(80, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gender";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(80, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Blood Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(80, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "DOB(MM/DD/YYYY)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(80, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(83, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Donor_id";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Donor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BloodDonationSystem.Properties.Resources.red_blood_cells;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBlood);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.donor_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.txt_donor_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Donor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Donor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.ComboBox scbBlood;
        private System.Windows.Forms.TextBox sName;
        private System.Windows.Forms.RadioButton radioBloodS;
        private System.Windows.Forms.RadioButton radioNameS;
        private System.Windows.Forms.RadioButton radioIDS;
        private System.Windows.Forms.ComboBox cbBlood;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.TextBox donor_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox dob;
        private System.Windows.Forms.TextBox txt_donor_id;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}