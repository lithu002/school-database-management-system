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
    public partial class frmcourseregi : Form
    {
        public frmcourseregi()
        {
            InitializeComponent();
        }

        private void txtdescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcname_TextChanged(object sender, EventArgs e)
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

        private void btnregi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record Added Successfully", "Register Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbcourseid.Text = "";
            txtcname.Clear();
            txtdescription.Clear();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to delete this record....?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Record Deleted Successfully!", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbcourseid.Text = "";
            }
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record Updated Successfully", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbcourseid.Text = "";
            txtcname.Clear();
            txtdescription.Clear();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            cmbcourseid.Text = "";
            txtcname.Clear();
            txtdescription.Clear();
        }
    }
}
