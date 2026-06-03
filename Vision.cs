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
    public partial class frmvision : Form
    {
        public frmvision()
        {
            InitializeComponent();
        }

        private void rtbvision_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmhome homepage = new frmhome();
            homepage.Show();
            this.Hide();
        }

        private void lbldesvision_Click(object sender, EventArgs e)
        {

        }
    }
}
