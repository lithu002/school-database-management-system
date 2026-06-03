namespace FinalProject
{
    partial class frmhome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msabout = new System.Windows.Forms.ToolStripMenuItem();
            this.msvision = new System.Windows.Forms.ToolStripMenuItem();
            this.mslogo = new System.Windows.Forms.ToolStripMenuItem();
            this.msstd = new System.Windows.Forms.ToolStripMenuItem();
            this.msstdregi = new System.Windows.Forms.ToolStripMenuItem();
            this.msstdreport = new System.Windows.Forms.ToolStripMenuItem();
            this.mslec = new System.Windows.Forms.ToolStripMenuItem();
            this.mslecregi = new System.Windows.Forms.ToolStripMenuItem();
            this.mscourse = new System.Windows.Forms.ToolStripMenuItem();
            this.mscourseregi = new System.Windows.Forms.ToolStripMenuItem();
            this.lblwelcometo = new System.Windows.Forms.Label();
            this.lblskillsi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msabout,
            this.msstd,
            this.mslec,
            this.mscourse});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msabout
            // 
            this.msabout.BackColor = System.Drawing.Color.White;
            this.msabout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msvision,
            this.mslogo});
            this.msabout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msabout.Name = "msabout";
            this.msabout.Size = new System.Drawing.Size(74, 29);
            this.msabout.Text = "About";
            // 
            // msvision
            // 
            this.msvision.Name = "msvision";
            this.msvision.Size = new System.Drawing.Size(144, 30);
            this.msvision.Text = "Vision";
            this.msvision.Click += new System.EventHandler(this.msvision_Click);
            // 
            // mslogo
            // 
            this.mslogo.Name = "mslogo";
            this.mslogo.Size = new System.Drawing.Size(144, 30);
            this.mslogo.Text = "Logo";
            this.mslogo.Click += new System.EventHandler(this.mslogo_Click);
            // 
            // msstd
            // 
            this.msstd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msstdregi,
            this.msstdreport});
            this.msstd.Name = "msstd";
            this.msstd.Size = new System.Drawing.Size(85, 29);
            this.msstd.Text = "Student";
            this.msstd.Click += new System.EventHandler(this.msstd_Click);
            // 
            // msstdregi
            // 
            this.msstdregi.Name = "msstdregi";
            this.msstdregi.Size = new System.Drawing.Size(256, 30);
            this.msstdregi.Text = "Student Registration";
            this.msstdregi.Click += new System.EventHandler(this.msstdregi_Click);
            // 
            // msstdreport
            // 
            this.msstdreport.Name = "msstdreport";
            this.msstdreport.Size = new System.Drawing.Size(256, 30);
            this.msstdreport.Text = "Student\'s Report";
            this.msstdreport.Click += new System.EventHandler(this.msstdreport_Click);
            // 
            // mslec
            // 
            this.mslec.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mslecregi});
            this.mslec.Name = "mslec";
            this.mslec.Size = new System.Drawing.Size(86, 29);
            this.mslec.Text = "Lecturer";
            this.mslec.Click += new System.EventHandler(this.mslec_Click);
            // 
            // mslecregi
            // 
            this.mslecregi.Name = "mslecregi";
            this.mslecregi.Size = new System.Drawing.Size(251, 30);
            this.mslecregi.Text = "Lecture Registration";
            this.mslecregi.Click += new System.EventHandler(this.mslecregi_Click);
            // 
            // mscourse
            // 
            this.mscourse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mscourseregi});
            this.mscourse.Name = "mscourse";
            this.mscourse.Size = new System.Drawing.Size(79, 29);
            this.mscourse.Text = "Course";
            this.mscourse.Click += new System.EventHandler(this.mscourse_Click);
            // 
            // mscourseregi
            // 
            this.mscourseregi.Name = "mscourseregi";
            this.mscourseregi.Size = new System.Drawing.Size(250, 30);
            this.mscourseregi.Text = "Course Registration";
            this.mscourseregi.Click += new System.EventHandler(this.mscourseregi_Click);
            // 
            // lblwelcometo
            // 
            this.lblwelcometo.AutoSize = true;
            this.lblwelcometo.BackColor = System.Drawing.Color.Transparent;
            this.lblwelcometo.Font = new System.Drawing.Font("Baskerville Old Face", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcometo.ForeColor = System.Drawing.Color.Navy;
            this.lblwelcometo.Location = new System.Drawing.Point(305, 56);
            this.lblwelcometo.Name = "lblwelcometo";
            this.lblwelcometo.Size = new System.Drawing.Size(280, 41);
            this.lblwelcometo.TabIndex = 1;
            this.lblwelcometo.Text = "WELCOME TO";
            this.lblwelcometo.Click += new System.EventHandler(this.lblwelcometo_Click);
            // 
            // lblskillsi
            // 
            this.lblskillsi.AutoSize = true;
            this.lblskillsi.BackColor = System.Drawing.Color.Transparent;
            this.lblskillsi.Font = new System.Drawing.Font("Baskerville Old Face", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblskillsi.ForeColor = System.Drawing.Color.Navy;
            this.lblskillsi.Location = new System.Drawing.Point(205, 132);
            this.lblskillsi.Name = "lblskillsi";
            this.lblskillsi.Size = new System.Drawing.Size(470, 41);
            this.lblskillsi.TabIndex = 2;
            this.lblskillsi.Text = "SKILLS INTERNATIONAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.DarkRed;
            this.btnlogout.Location = new System.Drawing.Point(41, 512);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(147, 51);
            this.btnlogout.TabIndex = 9;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 591);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblskillsi);
            this.Controls.Add(this.lblwelcometo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmhome";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msabout;
        private System.Windows.Forms.ToolStripMenuItem msstd;
        private System.Windows.Forms.ToolStripMenuItem msstdregi;
        private System.Windows.Forms.ToolStripMenuItem mslec;
        private System.Windows.Forms.ToolStripMenuItem msstdreport;
        private System.Windows.Forms.Label lblwelcometo;
        private System.Windows.Forms.Label lblskillsi;
        private System.Windows.Forms.ToolStripMenuItem mslecregi;
        private System.Windows.Forms.ToolStripMenuItem mscourse;
        private System.Windows.Forms.ToolStripMenuItem mscourseregi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.ToolStripMenuItem msvision;
        private System.Windows.Forms.ToolStripMenuItem mslogo;
    }
}