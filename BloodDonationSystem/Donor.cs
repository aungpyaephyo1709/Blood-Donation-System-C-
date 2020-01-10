using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BloodDonationSystem
{
    public partial class Donor : Form
    {
        SqlConnection con = null;
        int result = 0;
        string gender = "";
        string donorView = "select donor_id,blood.blood_type,name,dob,gender,phone from donor,blood where blood.blood_id=donor.blood_id";
        public Donor()
        {
            InitializeComponent();
        }

        private void Donor_Load(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Red;
            //MessageBox.Show("donor load");
           //  dataView("select * from donor");
         //   string query="CREATE TABLE DONATION(DONATION_ID int,DONOR_ID VARCHAR(10),DONATION_DATE DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,FOREIGN KEY(DONOR_ID) REFERENCES DONOR(DONOR_ID));";
            string query = "CREATE TABLE BLOOD_BANK(BANK_ID int,DONOR_ID VARCHAR(10),BLOOD_ID VARCHAR(10),FOREIGN KEY(BLOOD_ID) REFERENCES BLOOD(BLOOD_ID))";

              connection();
              dataView(donorView);
              connection();
                  SqlCommand cmd = new SqlCommand(query, con);
                 //  cmd.ExecuteNonQuery();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            connection();
           
        //    SqlCommand cmdTime = new SqlCommand("SELECT COUNT(*) FROM DONATION where DONOR_ID='" + txt_donor_id.Text + "'", con);
          //  int countTime = (int)cmdTime.ExecuteScalar();
            //MessageBox.Show("countTime=" + countTime);//show message
            
            string date = "";
            SqlCommand cmdResult = new SqlCommand("select donation_date from DONATION where DONOR_ID='" + txt_donor_id.Text + "' ", con);
            SqlDataReader idHas = cmdResult.ExecuteReader();
            if (idHas.Read())//donor has
            {
                idHas.Close();
                cmdResult = new SqlCommand("select endtime from time where DONOR_ID='" + txt_donor_id.Text + "'", con);
                SqlDataReader DATETIME = cmdResult.ExecuteReader();
                string endDate = "";
                if (DATETIME.Read())
                {
                    date = DATETIME[0].ToString();

                    char[] a = date.ToCharArray();

                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] == ' ')
                        {
                            break;
                        }
                        else
                        {
                            endDate += a[i];
                        }
                    }
                }
         //       MessageBox.Show("ENDdate=" + endDate);
                DATETIME.Close();
                  
               string today=DateTime.Now.ToString("M/dd/yyyy");

           //     MessageBox.Show("Current time" + today);

                DateTime d1 = DateTime.Parse(today);
                DateTime d2 = DateTime.Parse(endDate);
                string d3 =( d2 - d1).ToString();
             //   MessageBox.Show("diff day" + d3);
                char[] aa = d3.ToCharArray();
                string dif = "";
                for (int i = 0; i < aa.Length; i++)
                {
                    if (aa[i] == '.')
                    {
                        break;
                    }
                    else
                    {
                        dif += aa[i];
                    }
                }
               // MessageBox.Show("diff day" + dif);
                int difference = int.Parse(dif);
                if (difference>0)
                {
                    MessageBox.Show("sorry,you can donation at next "+difference+" days");
                   
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM DONATION", con);
                    int count = (int)cmd.ExecuteScalar() + 1;

                    cmd = new SqlCommand("insert into donation(DONATION_ID,DONOR_ID) values(" + count + ",'" + txt_donor_id.Text + "')", con);
                    cmd.ExecuteNonQuery();

                    cmdResult = new SqlCommand("update time set endTime='" + DateTime.Now.AddDays(180) + "' where donor_id='" + txt_donor_id.Text + "'", con);
                    cmdResult.ExecuteNonQuery();

                    cmd = new SqlCommand("SELECT COUNT(*) FROM BLOOD_BANK", con);
                    count = (int)cmd.ExecuteScalar() + 1;

                    cmd = new SqlCommand("insert into BLOOD_BANK VALUES(" + count + ",'" + txt_donor_id.Text + "','" + cbBlood.Text + "')", con);//"+txt_donor_id.Text+"','
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("donation");
                }
                dataView(donorView);

            }
            else//new donor
            {
                idHas.Close();
                Boolean flag = false;
                Boolean flag1 = false;
                Boolean flag2= false;

                if (txt_donor_id.Text.Equals(""))//check donor_id
                {
                    MessageBox.Show("donor id is empty");
                    flag = false;
                }
                else
                {
                    flag = true;

                    if (donor_name.Text.Equals(""))//check donor name
                    {
                        MessageBox.Show("donor name is empty"); flag1 = false;
                    }
                    else
                    {
                        flag1 = true;

                        if (dob.Text.Equals(""))//check dob
                        {
                            MessageBox.Show("DOB is empty");
                            flag2 = false;
                        }
                        else
                        {

                            flag2 = true;
                            try
                            {
                                DateTime t = DateTime.Parse(dob.Text);
                            }
                            catch
                            {
                                MessageBox.Show("dob is invalid format");
                                flag2 = false;
                            }
                        }
                    }
                }
                if (radMale.Checked)
                {
                    gender = "Male";
                }
                if (radFemale.Checked)
                {
                    gender = "Female";
                }
                if (flag && flag1 && flag2)
                {
                    cmdResult = new SqlCommand("INSERT INTO TIME VALUES('" + txt_donor_id.Text + "','" + DateTime.Now.AddDays(180) + "')", con);
                    cmdResult.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("insert into DONOR(DONOR_ID,BLOOD_ID,NAME,DOB,GENDER,PHONE) VALUES ('" + txt_donor_id.Text + "','" + getBlood() + "','" + donor_name.Text + "','" + dob.Text + "','" + gender + "','" + txtphone.Text + "')", con);
                    result = cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("SELECT COUNT(*) FROM DONATION", con);
                    int count = (int)cmd.ExecuteScalar() + 1;

                    cmd = new SqlCommand("insert into donation(DONATION_ID,DONOR_ID) values(" + count + ",'" + txt_donor_id.Text + "')", con);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("SELECT COUNT(*) FROM BLOOD_BANK", con);
                    count = (int)cmd.ExecuteScalar() + 1;

                    cmd = new SqlCommand("insert into BLOOD_BANK VALUES(" + count + ",'" + txt_donor_id.Text + "','" +cbBlood.Text + "')", con);//"+txt_donor_id.Text+"','
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("donation");
                    dataView(donorView);
                }
            }
        }
    
        public void connection()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lenovo\Documents\newProject.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
        }

        public void dataView(string query)
        {
            try
            {

                DataSet donorDS = new DataSet();
                SqlDataAdapter donorDA = new SqlDataAdapter(query, con);
                donorDA.Fill(donorDS, "DONOR");
                dataGridView1.DataSource = donorDS;
                dataGridView1.DataMember = "DONOR";
              //  dataGridView1.AutoResizeColumn(DataGridViewAutoSizeColumnMode.AllCellsExceptHeader);
            }
            finally
            {
                con.Close();
            }
        }

        public string getBlood()
        {
            string BLOOD = "";
            string query = "select BLOOD_ID FROM BLOOD WHERE BLOOD_TYPE='" + cbBlood.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader result = cmd.ExecuteReader();
            if (result.Read())
            {
                BLOOD = result[0].ToString();
            }
            result.Close();
            return BLOOD;

        }

        public string getBloodID(string bloodType)
        {
            string type = "";
            string query = "select BLOOD_ID FROM BLOOD WHERE BLOOD_TYPE='" + bloodType+ "'";
            
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader result = cmd.ExecuteReader();
            if (result.Read())
            {
                type = result[0].ToString();
            }
            result.Close();
           // MessageBox.Show(type+"  "+scbBlood);
            return type;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            connection();
             if (radMale.Checked)
                {
                    gender = "Male";
                }
                if (radFemale.Checked)
                {
                    gender = "Female";
                }
                SqlCommand cmd = new SqlCommand("update donor set blood_id='" + getBloodID(cbBlood.Text) + "',name='" + donor_name.Text + "',dob='" + dob.Text + "',gender='" + gender + "',phone='" + txtphone.Text + "' where donor_id='" + txt_donor_id.Text + "'", con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Update blood_bank set blood_id='" + getBloodID(cbBlood.Text) + "' where donor_id='" + txt_donor_id.Text + "'", con);
                cmd.ExecuteNonQuery();
                dataView(donorView);
        }
         
                                          

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            if (radioBloodS.Checked)
            {
                connection();
                dataView("(select * from DONOR where BLOOD_ID='" + getBloodID(scbBlood.Text) + "')");
            }
            if (radioIDS.Checked)
            {

                connection();
                dataView("select * from DONOR where DONOR_ID like'%" + sName.Text + "%'");
            }

            if (radioNameS.Checked)
            {

                connection();
                dataView("select * from DONOR where NAME like '%" + sName.Text + "%'");
            }
            con.Close();
                
        }

        private void radioNameS_CheckedChanged(object sender, EventArgs e)
        {
            sName.Show();
            scbBlood.Hide();

        }

        private void radioIDS_CheckedChanged(object sender, EventArgs e)
        {
            scbBlood.Hide();
            sName.Show();
        }

        private void radioBloodS_CheckedChanged(object sender, EventArgs e)
        {
            sName.Hide();
            scbBlood.Show();
        }

       
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hospital h = new Hospital();
            h.Show();
            this.Close();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();

           
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            History h = new History();
            h.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
               MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
    
        
        }

        private void getCurrentCellButton_Click(object sender, System.EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void scbBlood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBlood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void donor_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dob_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_donor_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
}
}