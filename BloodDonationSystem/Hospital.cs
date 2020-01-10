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
    public partial class Hospital : Form
    {
        SqlConnection con = null;
        string gridBlood = "select blood_id,count(blood_id) as NumberOfBlood from blood_bank group by blood_id";
        string hospitalData = "select * from hospital";
        public Hospital()
        {
            InitializeComponent();
        }

      

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            connection();
            
            Boolean flag = false;
            Boolean flag1 = false;
            Boolean flag2 = false;
            Boolean flag3 = false;
            string bloodID = cbBlood.Text;
            string getTotalBlood = "select count(blood_id) as NumberOfBlood from blood_bank where blood_bank.blood_id='"+getBloodID(bloodID)+"' group by blood_id";
            int bloodNumber = (int)cbBNumber.Value;
            SqlCommand cmd = new SqlCommand(getTotalBlood, con);
            int totalBlood = 0;
            try
            {
                totalBlood = (int)cmd.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("blood is empty");
            }
            if (bloodNumber <= totalBlood && bloodNumber>0)
            {

                if (txtHid.Text.Equals(""))
                {
                    MessageBox.Show("id is empty");
                    flag = false;
                }
                else
                    flag = true;
                if(txtName.Text.Equals("")){
                    MessageBox.Show("name is empty");
                        flag1 = false;
                }
                else
                    flag1 = true;
                if(txtAddress.Text.Equals("")){
                    MessageBox.Show("address is empty");
                    flag2 = false;
                }
                else
                    flag2 = true;

                if(txtPhone.Text.Equals("")){
                    MessageBox.Show("phone no is empty");
                        flag3 = false;
                }
                else
                    flag3 = true;


                
                if (flag &&  flag1&& flag2&&flag3)
                {

                    string query = "select * from hospital where h_id='" + txtHid.Text + "'";

                    cmd = new SqlCommand(query, con);
                    SqlDataReader has = cmd.ExecuteReader();
                    if (has.Read())//hospital has
                    {
                        MessageBox.Show("hospital has");//show message

                        cmd = new SqlCommand("select * from blood_bank where blood_id='" + getBloodID(cbBlood.Text) + "'", con);
                        SqlDataReader deleteBlood = cmd.ExecuteReader();
                        string[] idarr = new string[bloodNumber];
                        string[] donorarr = new string[bloodNumber];
                        string[] bidarr = new string[bloodNumber];
                        for (int i = 0; i < bloodNumber; i++)
                        {
                            deleteBlood.Read();
                            idarr[i] = deleteBlood[0].ToString(); donorarr[i] = deleteBlood[1].ToString(); bidarr[i] = deleteBlood[2].ToString();

                        }
                        deleteBlood.Close();
                        for (int i = 0; i < bloodNumber; i++)
                        {
                            cmd = new SqlCommand("delete from blood_bank where bank_id='" + idarr[i] + "' and donor_id='" + donorarr[i] + "' and blood_id='" + bidarr[i] + "'", con);
                            cmd.ExecuteNonQuery();
                        }
                        BloodData(gridBlood);

                        cmd = new SqlCommand("insert into bug values ('B" + txtHid.Text + "','" + txtHid.Text + "','" + getBloodID(cbBlood.Text) + "','" + cbBNumber.Value + "','" + DateTime.Now + "')", con);
                        cmd.ExecuteNonQuery();
                        has.Close();
                    }
                    else//new hospital
                    {
                        has.Close();
                        query = "insert into hospital values('" + txtHid.Text + "','" + txtName.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "')";
                        cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into bug values ('B" + txtHid.Text + "','" + txtHid.Text + "','" + getBloodID(cbBlood.Text) + "','" + cbBNumber.Value + "','" + DateTime.Now + "')", con);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("select * from blood_bank where blood_id='" + getBloodID(cbBlood.Text) + "'", con);
                        SqlDataReader deleteBlood = cmd.ExecuteReader();
                        string[] idarr = new string[bloodNumber];
                        string[] donorarr = new string[bloodNumber];
                        string[] bidarr = new string[bloodNumber];
                        for (int i = 0; i < bloodNumber; i++)
                        {
                            deleteBlood.Read();
                            idarr[i] = deleteBlood[0].ToString(); donorarr[i] = deleteBlood[1].ToString(); bidarr[i] = deleteBlood[2].ToString();

                        }
                        deleteBlood.Close();
                        for (int i = 0; i < bloodNumber; i++)
                        {
                            cmd = new SqlCommand("delete from blood_bank where bank_id='" + idarr[i] + "' and donor_id='" + donorarr[i] + "' and blood_id='" + bidarr[i] + "'", con);
                            cmd.ExecuteNonQuery();
                        }
                        BloodData(gridBlood);
                        dataView("select * from hospital");
                    }
                }
            }//ok blood
            else//
            {
                if (bloodNumber == 0)
                    MessageBox.Show("blood number is 0");
                else
                    MessageBox.Show("blood numbers are not enough");
            }
        }

       

        private void Search_Click(object sender, EventArgs e)
        {
            if (radioBloodS.Checked)
            {
                connection();
                BloodData("select blood_id,count(blood_id) as NumberOfBlood from blood_bank where blood_id='"+getBloodID(scbBlood.Text)+"' group by blood_id");
            }
            if (radioIDS.Checked)
            {

                connection();
                dataView("select * from hospital where DONOR_ID like'%" + sName.Text + "%'");
            }

            if (radioNameS.Checked)
            {

                connection();
                dataView("select * from hospital where NAME like '%" + sName.Text + "%'");
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
                con.Close();
                connection();
                DataSet donorDS = new DataSet();
                SqlDataAdapter donorDA = new SqlDataAdapter(query, con);
                donorDA.Fill(donorDS, "HOSPITAL");
                dataGridView1.DataSource = donorDS;
                dataGridView1.DataMember = "HOSPITAL";
            }
            finally
            {
                con.Close();
            }
        }

        public string getBloodID(string blood)
        {
            connection();
            string type = "";
            string query = "select BLOOD_ID FROM BLOOD WHERE BLOOD_TYPE='" + blood + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader result = cmd.ExecuteReader();
            if (result.Read())
            {
                type = result[0].ToString();
            }
            result.Close();
            return type;
        }

        private void radioNameS_CheckedChanged(object sender, EventArgs e)
        {
            scbBlood.Hide();
            sName.Show();
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

        public void BloodData(string query)
        {
            try
            {
                connection();
                DataSet bloodDS = new DataSet();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Blood Type");
                dt.Columns.Add("No: of Blood");
                while (rdr.Read())
                {
                    DataRow row = dt.NewRow();
                    row["Blood Type"] = rdr[0];
                    row["No: of Blood"] = rdr[1];
                    dt.Rows.Add(row);
                }
                BloodGrid.DataSource = dt;
                rdr.Close();
            }
            finally
            {
                con.Close();
            }
        }

        private void Hospital_Load(object sender, EventArgs e)
        {
            linkLabel2.LinkColor = Color.Red;
            connection();
            SqlCommand cmd = new SqlCommand("CREATE TABLE BLOOD_BANK(BANK_ID int,BLOOD_ID VARCHAR(10),FOREIGN KEY(BLOOD_ID) REFERENCES BLOOD(BLOOD_ID));", con);
         //  cmd.ExecuteNonQuery();

            dataView(hospitalData);
            BloodData(gridBlood);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            connection();
            Boolean flag = false;
            Boolean flag1 = false;
            Boolean flag2= false;
            Boolean flag3 = false;

                if (txtHid.Text.Equals(""))
                {
                    MessageBox.Show("id is empty");
                    flag = false;
                }
                else
                    flag = true;
                if(txtName.Text.Equals("")){
                    MessageBox.Show("name is empty");
                        flag1 = false;
                }
                else
                    flag1 = true;
                if(txtAddress.Text.Equals("")){
                    MessageBox.Show("address is empty");
                    flag2 = false;
                }
                else
                    flag2 = true;

                if(txtPhone.Text.Equals("")){
                    MessageBox.Show("phone no is empty");
                        flag3 = false;
                }
                else
                    flag3 = true;



                if (flag && flag1 && flag2 && flag3)
                {

                    SqlCommand cmd = new SqlCommand("update hospital set name='" + txtName.Text + "',address='" + txtAddress.Text + "',phone='" + txtPhone.Text + "' where h_id='" + txtHid.Text + "'", con);
                    cmd.ExecuteNonQuery();

                    dataView(hospitalData);
                }
        }

       

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            History h = new History();
            h.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Donor d = new Donor();
            d.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
