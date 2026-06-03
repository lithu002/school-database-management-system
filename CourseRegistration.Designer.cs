namespace FinalProject
{
    partial class frmcourseregi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcourseregi));
            this.lblskillsi = new System.Windows.Forms.Label();
            this.grpbcourseregi = new System.Windows.Forms.GroupBox();
            this.btnupd = new System.Windows.Forms.Button();
            this.cmbcourseid = new System.Windows.Forms.ComboBox();
            this.btnclr = new System.Windows.Forms.Button();
            this.btnregi = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.lblcourseid = new System.Windows.Forms.Label();
            this.grpbbdetails = new System.Windows.Forms.GroupBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblcname = new System.Windows.Forms.Label();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.grpbcourseregi.SuspendLayout();
            this.grpbbdetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblskillsi
            // 
            this.lblskillsi.AutoSize = true;
            this.lblskillsi.BackColor = System.Drawing.Color.Transparent;
            this.lblskillsi.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblskillsi.ForeColor = System.Drawing.Color.Navy;
            this.lblskillsi.Location = new System.Drawing.Point(165, 33);
            this.lblskillsi.Name = "lblskillsi";
            this.lblskillsi.Size = new System.Drawing.Size(341, 46);
            this.lblskillsi.TabIndex = 2;
            this.lblskillsi.Text = "Skills International";
            // 
            // grpbcourseregi
            // 
            this.grpbcourseregi.BackColor = System.Drawing.Color.Transparent;
            this.grpbcourseregi.Controls.Add(this.btnupd);
            this.grpbcourseregi.Controls.Add(this.cmbcourseid);
            this.grpbcourseregi.Controls.Add(this.btnclr);
            this.grpbcourseregi.Controls.Add(this.btnregi);
            this.grpbcourseregi.Controls.Add(this.btndel);
            this.grpbcourseregi.Controls.Add(this.lblcourseid);
            this.grpbcourseregi.Controls.Add(this.grpbbdetails);
            this.grpbcourseregi.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbcourseregi.Location = new System.Drawing.Point(40, 119);
            this.grpbcourseregi.Name = "grpbcourseregi";
            this.grpbcourseregi.Size = new System.Drawing.Size(565, 400);
            this.grpbcourseregi.TabIndex = 11;
            this.grpbcourseregi.TabStop = false;
            this.grpbcourseregi.Text = "Course Registration";
            // 
            // btnupd
            // 
            this.btnupd.ForeColor = System.Drawing.Color.Indigo;
            this.btnupd.Location = new System.Drawing.Point(169, 332);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(110, 45);
            this.btnupd.TabIndex = 22;
            this.btnupd.Text = "Update";
            this.btnupd.UseVisualStyleBackColor = true;
            this.btnupd.Click += new System.EventHandler(this.btnupd_Click);
            // 
            // cmbcourseid
            // 
            this.cmbcourseid.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcourseid.FormattingEnabled = true;
            this.cmbcourseid.Location = new System.Drawing.Point(202, 50);
            this.cmbcourseid.Name = "cmbcourseid";
            this.cmbcourseid.Size = new System.Drawing.Size(184, 35);
            this.cmbcourseid.TabIndex = 21;
            // 
            // btnclr
            // 
            this.btnclr.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnclr.Location = new System.Drawing.Point(309, 333);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(94, 38);
            this.btnclr.TabIndex = 19;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // btnregi
            // 
            this.btnregi.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnregi.Location = new System.Drawing.Point(32, 328);
            this.btnregi.Name = "btnregi";
            this.btnregi.Size = new System.Drawing.Size(117, 49);
            this.btnregi.TabIndex = 20;
            this.btnregi.Text = "Register";
            this.btnregi.UseVisualStyleBackColor = true;
            this.btnregi.Click += new System.EventHandler(this.btnregi_Click);
            // 
            // btndel
            // 
            this.btndel.ForeColor = System.Drawing.Color.Crimson;
            this.btndel.Location = new System.Drawing.Point(431, 333);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(105, 38);
            this.btndel.TabIndex = 18;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // lblcourseid
            // 
            this.lblcourseid.AutoSize = true;
            this.lblcourseid.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourseid.Location = new System.Drawing.Point(44, 53);
            this.lblcourseid.Name = "lblcourseid";
            this.lblcourseid.Size = new System.Drawing.Size(105, 27);
            this.lblcourseid.TabIndex = 2;
            this.lblcourseid.Text = "Course ID";
            // 
            // grpbbdetails
            // 
            this.grpbbdetails.BackColor = System.Drawing.Color.Transparent;
            this.grpbbdetails.Controls.Add(this.txtdescription);
            this.grpbbdetails.Controls.Add(this.lbldescription);
            this.grpbbdetails.Controls.Add(this.lblcname);
            this.grpbbdetails.Controls.Add(this.txtcname);
            this.grpbbdetails.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbbdetails.Location = new System.Drawing.Point(29, 101);
            this.grpbbdetails.Name = "grpbbdetails";
            this.grpbbdetails.Size = new System.Drawing.Size(507, 208);
            this.grpbbdetails.TabIndex = 8;
            this.grpbbdetails.TabStop = false;
            this.grpbbdetails.Text = "Basic Details";
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(173, 99);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(319, 84);
            this.txtdescription.TabIndex = 7;
            this.txtdescription.TextChanged += new System.EventHandler(this.txtdescription_TextChanged);
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(15, 102);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(120, 27);
            this.lbldescription.TabIndex = 6;
            this.lbldescription.Text = "Description";
            // 
            // lblcname
            // 
            this.lblcname.AutoSize = true;
            this.lblcname.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcname.Location = new System.Drawing.Point(15, 50);
            this.lblcname.Name = "lblcname";
            this.lblcname.Size = new System.Drawing.Size(141, 27);
            this.lblcname.TabIndex = 4;
            this.lblcname.Text = "Course Name";
            // 
            // txtcname
            // 
            this.txtcname.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcname.Location = new System.Drawing.Point(173, 47);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(259, 34);
            this.txtcname.TabIndex = 5;
            this.txtcname.TextChanged += new System.EventHandler(this.txtcname_TextChanged);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.Control;
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnexit.Location = new System.Drawing.Point(483, 551);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(93, 46);
            this.btnexit.TabIndex = 21;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frmcourseregi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 637);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.grpbcourseregi);
            this.Controls.Add(this.lblskillsi);
            this.Name = "frmcourseregi";
            this.Text = "CourseRegistration";
            this.grpbcourseregi.ResumeLayout(false);
            this.grpbcourseregi.PerformLayout();
            this.grpbbdetails.ResumeLayout(false);
            this.grpbbdetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblskillsi;
        private System.Windows.Forms.GroupBox grpbcourseregi;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.Label lblcname;
        private System.Windows.Forms.Label lblcourseid;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btnregi;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.GroupBox grpbbdetails;
        private System.Windows.Forms.ComboBox cmbcourseid;
        private System.Windows.Forms.Button btnupd;
    }
}