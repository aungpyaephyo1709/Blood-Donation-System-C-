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
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lenovo\Documents\newProject.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            
            /*  string createTable = "CREATE TABLE BLOOD(BLOOD_ID VARCHAR(10),BLOOD_TYPE VARCHAR(5),PRIMARY KEY(BLOOD_ID));CREATE TABLE DONOR(DONOR_ID VARCHAR(10),BLOOD_ID VARCHAR(10),NAME VARCHAR(100),DOB DATE,GENDER VARCHAR(6),PHONE VARCHAR(40),PRIMARY KEY(DONOR_ID),FOREIGN KEY(BLOOD_ID) REFERENCES BLOOD(BLOOD_ID));"+
                "CREATE TABLE HOSPITAL(H_ID VARCHAR(10),NAME VARCHAR(100),ADDRESS VARCHAR(225),PHONE VARCHAR(40),PRIMARY KEY(H_ID));CREATE TABLE DONATION(DONATION_ID VARCHAR(10),DONOR_ID VARCHAR(10),DONATION_DATE DATE,PRIMARY KEY(DONATION_ID),FOREIGN KEY(DONOR_ID) REFERENCES DONOR(DONOR_ID));"+
                "CREATE TABLE BLOOD_BANK(BANK_ID VARCHAR(10),DONATION_ID VARCHAR(10),H_ID VARCHAR(10),PRIMARY KEY(BANK_ID),FOREIGN KEY(DONATION_ID) REFERENCES DONATION(DONATION_ID),FOREIGN KEY(H_ID) REFERENCES HOSPITAL(H_ID));";
            */

            //string insertBloodTable = "INSERT INTO BLOOD VALUES('B1','A');INSERT INTO BLOOD VALUES('B2','B');INSERT INTO BLOOD VALUES('B3','AB');INSERT INTO BLOOD VALUES('B4','O');";
            try
            {
                con.Open();
                string query = "select * from Login where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    MessageBox.Show("Login success");
                    Donor donor = new Donor();
                    donor.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Username/Password incorrect");
                }
            }
            catch {
               // MessageBox.Show("database error");
                con.Close();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
           /* try { con.Open(); }
            catch { }
            SqlCommand cmd = new SqlCommand("delete from donation;delete from donor;delete from blood_bank;delete from hospital;delete from bug;delete from time;", con);

            //SqlCommand cmd = new SqlCommand("delete from hospital where h_id='" + txtHid.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close(); */
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            FormWindowState a = FormWindowState.Maximized;
        }

       
    }
}
