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
    public partial class History : Form
    {
        string view = "donor";
        Boolean id, name, date, blood = false;
        SqlConnection con = null;

        public History()
        {
            InitializeComponent();
            delCb.Hide();
        }
        public void connection()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Lenovo\Documents\newProject.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hospital h = new Hospital();
            h.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Donor d = new Donor();
            d.Show();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioNOB.Hide();
            if (radioButton1.Checked)
            {
                view = "donor";
               
            }
            history();
        }

        private void RH_CheckedChanged(object sender, EventArgs e)
        {
            radioNOB.Show();
            if (RH.Checked)
            {
                view = "hospital";
               
            }
            history();
        }

        private void History_Load(object sender, EventArgs e)
        {
            linkLabel6.LinkColor = Color.Red; 
            history();
             
        }

        public void history()
        {

            if (view.Equals("donor"))
            {
                dataView("select d.donor_id,b.blood_type,d.name,d.dob,d.gender,d.phone,do.donation_date from donor d,Blood b,donation do where d.blood_id=b.blood_id and d.donor_id=do.donor_id order by d.donor_id");
            }
            if(view.Equals("hospital"))
                dataView("select h.h_id,h.name,h.address,h.phone,b.blood_type,bug.nob,bug.bug_date from hospital h,blood b,bug where h.h_id=bug.h_id and b.blood_id=bug.blood_id order by h.h_id");
           
        }

        public void dataView(string query)
        {
            try
            {
           
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


        private void orderByBtn_Click(object sender, EventArgs e)
        {
            string order = "";
            if (view.Equals("donor"))
            {

                if (radioName.Checked)
                {
                    order = "select d.donor_id,b.blood_type,d.name,d.dob,d.gender,d.phone,do.donation_date from donor d,Blood b,donation do where d.blood_id=b.blood_id and d.donor_id=do.donor_id order by d.name";
                }
                else if (radioId.Checked)
                {
                    order = "select d.donor_id,b.blood_type,d.name,d.dob,d.gender,d.phone,do.donation_date from donor d,Blood b,donation do where d.blood_id=b.blood_id and d.donor_id=do.donor_id order by d.donor_id";
                }
                else if (radioBlood.Checked)
                {
                    order = "select d.donor_id,b.blood_type,d.name,d.dob,d.gender,d.phone,do.donation_date from donor d,Blood b,donation do where d.blood_id=b.blood_id and d.donor_id=do.donor_id order by b.blood_type";
                }
                else
                {
                    order = "select d.donor_id,b.blood_type,d.name,d.dob,d.gender,d.phone,do.donation_date from donor d,Blood b,donation do where d.blood_id=b.blood_id and d.donor_id=do.donor_id order by do.donation_date";
                }
        
                dataView(order);
            }
            else
            {

                if (radioName.Checked)
                {
                    order = "select h.h_id,h.name,h.address,h.phone,b.blood_type,bug.nob,bug.bug_date from hospital h,blood b,bug where h.h_id=bug.h_id and b.blood_id=bug.blood_id order by h.name";
                }
                else if (radioId.Checked)
                {
                    order = "select h.h_id,h.name,h.address,h.phone,b.blood_type,bug.nob,bug.bug_date from hospital h,blood b,bug where h.h_id=bug.h_id and b.blood_id=bug.blood_id order by h.h_id";
                }
                else if(radioBlood.Checked)
                {
                    order = "select h.h_id,h.name,h.address,h.phone,b.blood_type,bug.nob,bug.bug_date from hospital h,blood b,bug where h.h_id=bug.h_id and b.blood_id=bug.blood_id order by b.blood_type";
                }
                else if (radioDate.Checked)
                {
                    order = "select h.h_id,h.name,h.address,h.phone,b.blood_type,bug.nob,bug.bug_date from hospital h,blood b,bug where h.h_id=bug.h_id and b.blood_id=bug.blood_id order by bug.bug_date";
                }
                else
                {
                    order = "select h.h_id,h.name,h.address,h.phone,b.blood_type,bug.nob,bug.bug_date from hospital h,blood b,bug where h.h_id=bug.h_id and b.blood_id=bug.blood_id order by bug.nob";

                }
                dataView(order);

            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
           
            if (view.Equals("donor"))
            {

                if (radioBloodS.Checked)
                {
                    connection();
                    dataView("(select d.donor_id,b.blood_type,d.name,d.dob,d.gender,d.phone,do.donation_date from donor d,Blood b,donation do where d.blood_id=b.blood_id and d.donor_id=do.donor_id and b.BLOOD_ID='" + getBloodID(scbBlood.Text) + "')");
                }
                if (radioIDS.Checked)
                {

                    connection();
                    dataView("select d.donor_id,b.blood_type,d.name,d.dob,d.gender,d.phone,do.donation_date from donor d,Blood b,donation do where d.blood_id=b.blood_id and d.donor_id=do.donor_id and d.DONOR_ID like'%" + sName.Text + "%'");
                }

                if (radioNameS.Checked)
                {

                    connection();
                    dataView("select d.donor_id,b.blood_type,d.name,d.dob,d.gender,d.phone,do.donation_date from donor d,Blood b,donation do where d.blood_id=b.blood_id and d.donor_id=do.donor_id and d.NAME like '%" + sName.Text + "%'");
                }
                con.Close();
            
            }
            else
            {
                if (radioBloodS.Checked)
                {
                    connection();
                    dataView("select h.h_id,h.name,h.address,h.phone,b.blood_type,bug.nob,bug.bug_date from hospital h,blood b,bug where h.h_id=bug.h_id and b.blood_id=bug.blood_id and b.BLOOD_ID='" + getBloodID(scbBlood.Text) + "'");
                }
                if (radioIDS.Checked)
                {

                    connection();
                    dataView("select h.h_id,h.name,h.address,h.phone,b.blood_type,bug.nob,bug.bug_date from hospital h,blood b,bug where h.h_id=bug.h_id and b.blood_id=bug.blood_id and h.h_id like'%" + sName.Text + "%'");
                }

                if (radioNameS.Checked)
                {

                    connection();
                    dataView("select h.h_id,h.name,h.address,h.phone,b.blood_type,bug.nob,bug.bug_date from hospital h,blood b,bug where h.h_id=bug.h_id and b.blood_id=bug.blood_id and h.NAME like '%" + sName.Text + "%'");
                }
                con.Close();

            }
        }



        public string getBloodID(string bloodType)
        {
            string type = "";
            string query = "select BLOOD_ID FROM BLOOD WHERE BLOOD_TYPE='" + bloodType + "'";

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

        private void radioNameS_CheckedChanged(object sender, EventArgs e)
        {
            sName.Show();
            scbBlood.Hide();
        }

        private void radioIDS_CheckedChanged(object sender, EventArgs e)
        {
            sName.Show();
            scbBlood.Hide();
        }

        private void radioBloodS_CheckedChanged(object sender, EventArgs e)
        {
            sName.Hide();
            scbBlood.Show(); 
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            //aa
            if (checkBox1.Checked)
                id = true;
            if (checkBox2.Checked)
                name = true;
            if (checkBox3.Checked)
                blood = true;
            if (checkBox4.Checked)
                date = true;



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtIdDel.Show();
            txtIdDel.Text = "id";
           

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
          
               
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
            delCb.Show();
           

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void delCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIdDel_TextChanged(object sender, EventArgs e)
        {

        }

        private void scbBlood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }  
    
    }

}