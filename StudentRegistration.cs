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

namespace FinalProject
{
    public partial class frmstdregi : Form
    {
        public frmstdregi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection (@"Data Source=DESKTOP-D38E1L9;Initial Catalog=Student;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sqlDa = new SqlDataAdapter();

        private void frmsr_Load(object sender, EventArgs e)
        {
            con.Open();
            string selectque = "SELECT * FROM Registration";
            SqlCommand cmd = new SqlCommand(selectque, con);
            SqlDataReader row = cmd.ExecuteReader();
            while(row.Read())
            {
                cmbregno.Items.Add(row[0].ToString());
            }
            con.Close();
        }

        private void grpbstdregi_Enter(object sender, EventArgs e)
        {

        }

        private void grpbstdregi_Enter_1(object sender, EventArgs e)
        {

        }

        private void lblcno_Click(object sender, EventArgs e)
        {

        }

        private void txtcno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtaddress.Clear();
            txtcno.Clear();
            txtemail.Clear();
            txtfn.Clear();
            txthphone.Clear();
            txtln.Clear();
            txtmphone.Clear();
            txtnic.Clear();
            txtpname.Clear();
            rbmale.Checked = false;
            rbfemale.Checked = false;
            cmbregno.Text = "";
            dtpdob.Value = DateTime.Now;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string reg_no = cmbregno.Text;
            string first_name = txtfn.Text;
            string last_name = txtln.Text;
            dtpdob.Format = DateTimePickerFormat.Custom;
            dtpdob.CustomFormat = "yyyy/MM/dd";
            string gender_;
            if (rbmale.Checked)
            {
                gender_ = "Male";
            }
            else
            {
                gender_ = "Female";
            }
            string address_ = txtaddress.Text;
            string email_ = txtemail.Text;
            int mobile_phone = int.Parse(txtmphone.Text);
            int home_phone = int.Parse(txthphone.Text);
            string parent_name = txtpname.Text;
            string nic_ = txtnic.Text;
            int contact_number = int.Parse(txtcno.Text);

            string updateque = "UPDATE Registration SET firstName = '" + first_name + "', lastName = '" + last_name + "', dateOfBirth = '" + dtpdob.Text + "', gender = '" + gender_ + "', address = '" + address_ + "', email = '" + email_ + "', mobilePhone = '" + mobile_phone + "', homePhone = '" + home_phone + "', parentName = '" + parent_name + "', nic = '" + nic_ + "', contactNo = '" + contact_number + "' WHERE regNo = '" + reg_no + "'";

            con.Open();
            cmd = new SqlCommand(updateque, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Updated Successfully","Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtaddress.Clear();
            txtcno.Clear();
            txtemail.Clear();
            txtfn.Clear();
            txthphone.Clear();
            txtln.Clear();
            txtmphone.Clear();
            txtnic.Clear();
            txtpname.Clear();
            rbmale.Checked = false;
            rbfemale.Checked = false;
            cmbregno.Text = "";
            dtpdob.Value = DateTime.Now;

        }

        private void llbllogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmlogin loginpage = new frmlogin();
            loginpage.Show();
            this.Close();
        }

        private void llblexit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmhome homepage = new frmhome();
            homepage.Show();
            this.Hide();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string reg_no = cmbregno.Text;
            string first_name = txtfn.Text;
            string last_name = txtln.Text;
            dtpdob.Format = DateTimePickerFormat.Custom;
            dtpdob.CustomFormat = "yyyy/MM/dd";
            string gender_;
            if (rbmale.Checked)
            {
                gender_ = "Male";
            }
            else{
                gender_ = "Female";
            }
            string address_ = txtaddress.Text;
            string email_ = txtemail.Text;
            int mobile_phone = int.Parse(txtmphone.Text);
            int home_phone = int.Parse(txthphone.Text);
            string parent_name = txtpname.Text;
            string nic_ = txtnic.Text;
            int contact_number = int.Parse(txtcno.Text);

            string regique = "INSERT INTO Registration (regNo,firstName,lastName,dateOfBirth,gender,address,email,mobilePhone,homePhone,parentName,nic,contactNo) VALUES ('" + reg_no + "','" + first_name + "','" + last_name + "','" + dtpdob.Text + "','" + gender_ + "','" + address_ + "','" + email_ + "','" + mobile_phone + "','" + home_phone + "','" + parent_name + "','" + nic_ + "','" + contact_number + "')";

            con.Open();
            cmd = new SqlCommand (regique,con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Added Successfully","Register Student",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtaddress.Clear();
            txtcno.Clear();
            txtemail.Clear();
            txtfn.Clear();
            txthphone.Clear();
            txtln.Clear();
            txtmphone.Clear();
            txtnic.Clear();
            txtpname.Clear();
            rbmale.Checked = false;
            rbfemale.Checked = false;
            cmbregno.Text = "";
            dtpdob.Value = DateTime.Now;

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string reg_no = cmbregno.Text;

            string deleteque = "DELETE FROM Registration WHERE regNo = '" + reg_no + "'";

            con.Open();
            cmd = new SqlCommand(deleteque, con);
            cmd.ExecuteNonQuery();
            con.Close();

            var result = MessageBox.Show("Are you sure, Do you really want to delete this record....?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Record Deleted Successfully!", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtaddress.Clear();
            txtcno.Clear();
            txtemail.Clear();
            txtfn.Clear();
            txthphone.Clear();
            txtln.Clear();
            txtmphone.Clear();
            txtnic.Clear();
            txtpname.Clear();
            rbmale.Checked = false;
            rbfemale.Checked = false;
            cmbregno.Text = "";
            dtpdob.Value = DateTime.Now;
        }

        private void lblregno_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void cmbregno_SelectedIndexChanged(object sender, EventArgs e)
        {
            string reg_no = cmbregno.Text;
            
            con.Open();
            string selectque = "SELECT * FROM Registration WHERE regNo = '" + reg_no + "'";
            SqlCommand cmd = new SqlCommand(selectque, con);
            SqlDataReader row = cmd.ExecuteReader();
            while (row.Read())
            {
                  txtfn.Text = row[1].ToString();
                  txtln.Text = row[2].ToString();
                  dtpdob.Format = DateTimePickerFormat.Custom;
                  dtpdob.CustomFormat = "yyyy/MM/dd";
                  dtpdob.Text = row[3].ToString();
                  if (row[4].ToString() == "Male")
                  {
                      rbmale.Checked = true;
                      rbfemale.Checked = false;
                  }
                  else
                  {
                      rbmale.Checked = false;
                      rbfemale.Checked = true;
                  }
                  txtaddress.Text = row[5].ToString();
                  txtemail.Text = row[6].ToString();
                  txtmphone.Text = row[7].ToString();
                  txthphone.Text = row[8].ToString();
                  txtpname.Text = row[9].ToString();
                  txtnic.Text = row[10].ToString();
                  txtcno.Text = row[11].ToString();
            }
            con.Close();
        }

        private void lblskillsi_Click(object sender, EventArgs e)
        {

        }

        private void txtfn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtln_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpdob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnic_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
