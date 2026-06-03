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
    public partial class frmlecregi : Form
    {
        public frmlecregi()
        {
            InitializeComponent();
        }

        private void dtpdob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Record Added Successfully", "Register Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            txtaddress.Clear();
            txtemail.Clear();
            txtname.Clear();
            txtcno.Clear();
            rbmale.Checked = false;
            rbfemale.Checked = false;
            cmblecid.Text = "";
            dtpdob.Value = DateTime.Now;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to delete this record....?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Record Deleted Successfully!", "Delete Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cmblecid.Text = "";
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmhome homepage = new frmhome();
                homepage.Show();
                this.Hide();
            }
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtaddress.Clear();
            txtemail.Clear();
            txtname.Clear();
            txtcno.Clear();
            rbmale.Checked = false;
            rbfemale.Checked = false;
            cmblecid.Text = "";
            dtpdob.Value = DateTime.Now;
        }

        private void btnupd_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Record Updated Successfully", "Update Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtaddress.Clear();
            txtemail.Clear();
            txtname.Clear();
            txtcno.Clear();
            rbmale.Checked = false;
            rbfemale.Checked = false;
            cmblecid.Text = "";
            dtpdob.Value = DateTime.Now;
        }

        private void cmblecid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
