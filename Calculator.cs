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
    public partial class frmcalculator : Form
    {
        public frmcalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblenglish_Click(object sender, EventArgs e)
        {

        }

        private void grpbreportcard_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbregno.Text = "";
            txtmaths.Clear();
            txtscience.Clear();
            txtenglish.Clear();
            txtict.Clear();
            txttotal.Clear();
            txtavg.Clear();
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            int maths,eng,sci,ict,total;
            float avg;

            maths = int.Parse(txtmaths.Text);
            eng = int.Parse(txtenglish.Text);
            sci = int.Parse(txtscience.Text);
            ict = int.Parse(txtict.Text);

            total = maths + eng + sci + ict;
            avg = (float)total / 4;

            txttotal.Text = total.ToString();
            txtavg.Text = avg.ToString();
        }
    }
}
