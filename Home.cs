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
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }

        private void msstdreport_Click(object sender, EventArgs e)
        {
            frmcalculator calculatorpage = new frmcalculator();
            calculatorpage.Show();
            this.Close();
        }

        private void msstdregi_Click(object sender, EventArgs e)
        {
            frmstdregi stdregipage = new frmstdregi();
            stdregipage.Show();
            this.Close();
        }

        private void mslecregi_Click(object sender, EventArgs e)
        {
            frmlecregi lecregipage = new frmlecregi();
            lecregipage.Show();
            this.Hide();
        }

        private void mscourseregi_Click(object sender, EventArgs e)
        {
            frmcourseregi courseregipage = new frmcourseregi();
            courseregipage.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to Log Out...?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmlogin loginpage = new frmlogin();
                loginpage.Show();
                this.Hide();
            }
            
        }

        private void mslogo_Click(object sender, EventArgs e)
        {
            frmlogo logopage = new frmlogo();
            logopage.Show();
            this.Hide();
        }

        private void msstd_Click(object sender, EventArgs e)
        {

        }

        private void msvision_Click(object sender, EventArgs e)
        {
            frmvision visionpage = new frmvision();
            visionpage.Show();
            this.Hide();
        }

        private void mslec_Click(object sender, EventArgs e)
        {

        }

        private void mscourse_Click(object sender, EventArgs e)
        {

        }

        private void lblwelcometo_Click(object sender, EventArgs e)
        {

        }
    }
}
