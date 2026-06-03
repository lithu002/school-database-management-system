using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtun.Clear();
            txtpw.Clear();
            txtun.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string un, pw;
            un = txtun.Text;
            pw = txtpw.Text;

            if (un == "Admin" && pw == "Skills@123")
            {
                MessageBox.Show("Login Successful!", "Login",MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmhome welcomepage = new frmhome();
                welcomepage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials, please check Username and Password and try again", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtun.Clear();
                txtpw.Clear();
            }
        }

        private void txtpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtun_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpblogin_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
