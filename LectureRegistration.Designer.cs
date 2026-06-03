namespace FinalProject
{
    partial class frmlecregi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlecregi));
            this.lblskillsi = new System.Windows.Forms.Label();
            this.grpblecregi = new System.Windows.Forms.GroupBox();
            this.btnupd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.btnregi = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.grpbcdetails = new System.Windows.Forms.GroupBox();
            this.txtcno = new System.Windows.Forms.TextBox();
            this.lblcno = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.grpbbdetails = new System.Windows.Forms.GroupBox();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.lblgen = new System.Windows.Forms.Label();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.lbldob = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.cmblecid = new System.Windows.Forms.ComboBox();
            this.lbllecid = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.grpblecregi.SuspendLayout();
            this.grpbcdetails.SuspendLayout();
            this.grpbbdetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblskillsi
            // 
            this.lblskillsi.AutoSize = true;
            this.lblskillsi.BackColor = System.Drawing.Color.Transparent;
            this.lblskillsi.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblskillsi.ForeColor = System.Drawing.Color.Navy;
            this.lblskillsi.Location = new System.Drawing.Point(277, 39);
            this.lblskillsi.Name = "lblskillsi";
            this.lblskillsi.Size = new System.Drawing.Size(372, 51);
            this.lblskillsi.TabIndex = 2;
            this.lblskillsi.Text = "Skills International";
            // 
            // grpblecregi
            // 
            this.grpblecregi.BackColor = System.Drawing.Color.Transparent;
            this.grpblecregi.Controls.Add(this.btnupd);
            this.grpblecregi.Controls.Add(this.btndel);
            this.grpblecregi.Controls.Add(this.btnclr);
            this.grpblecregi.Controls.Add(this.btnregi);
            this.grpblecregi.Controls.Add(this.btnclear);
            this.grpblecregi.Controls.Add(this.btndelete);
            this.grpblecregi.Controls.Add(this.btnupdate);
            this.grpblecregi.Controls.Add(this.btnregister);
            this.grpblecregi.Controls.Add(this.grpbcdetails);
            this.grpblecregi.Controls.Add(this.grpbbdetails);
            this.grpblecregi.Controls.Add(this.cmblecid);
            this.grpblecregi.Controls.Add(this.lbllecid);
            this.grpblecregi.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpblecregi.Location = new System.Drawing.Point(29, 111);
            this.grpblecregi.Name = "grpblecregi";
            this.grpblecregi.Size = new System.Drawing.Size(821, 712);
            this.grpblecregi.TabIndex = 3;
            this.grpblecregi.TabStop = false;
            this.grpblecregi.Text = "Lecturer Registration";
            // 
            // btnupd
            // 
            this.btnupd.ForeColor = System.Drawing.Color.Indigo;
            this.btnupd.Location = new System.Drawing.Point(204, 630);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(110, 45);
            this.btnupd.TabIndex = 18;
            this.btnupd.Text = "Update";
            this.btnupd.UseVisualStyleBackColor = true;
            this.btnupd.Click += new System.EventHandler(this.btnupd_Click_2);
            // 
            // btndel
            // 
            this.btndel.ForeColor = System.Drawing.Color.Crimson;
            this.btndel.Location = new System.Drawing.Point(661, 624);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(105, 51);
            this.btndel.TabIndex = 17;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnclr
            // 
            this.btnclr.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnclr.Location = new System.Drawing.Point(511, 624);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(94, 49);
            this.btnclr.TabIndex = 16;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // btnregi
            // 
            this.btnregi.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnregi.Location = new System.Drawing.Point(48, 625);
            this.btnregi.Name = "btnregi";
            this.btnregi.Size = new System.Drawing.Size(117, 50);
            this.btnregi.TabIndex = 14;
            this.btnregi.Text = "Register";
            this.btnregi.UseVisualStyleBackColor = true;
            this.btnregi.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnclear
            // 
            this.btnclear.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnclear.Location = new System.Drawing.Point(497, 817);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(94, 37);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.ForeColor = System.Drawing.Color.Crimson;
            this.btndelete.Location = new System.Drawing.Point(661, 815);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 39);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.ForeColor = System.Drawing.Color.Indigo;
            this.btnupdate.Location = new System.Drawing.Point(217, 815);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(110, 39);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnregister
            // 
            this.btnregister.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnregister.Location = new System.Drawing.Point(38, 815);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(117, 39);
            this.btnregister.TabIndex = 8;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            // 
            // grpbcdetails
            // 
            this.grpbcdetails.Controls.Add(this.txtcno);
            this.grpbcdetails.Controls.Add(this.lblcno);
            this.grpbcdetails.Controls.Add(this.txtemail);
            this.grpbcdetails.Controls.Add(this.lblemail);
            this.grpbcdetails.Controls.Add(this.txtaddress);
            this.grpbcdetails.Controls.Add(this.lbladdress);
            this.grpbcdetails.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbcdetails.Location = new System.Drawing.Point(31, 364);
            this.grpbcdetails.Name = "grpbcdetails";
            this.grpbcdetails.Size = new System.Drawing.Size(754, 237);
            this.grpbcdetails.TabIndex = 9;
            this.grpbcdetails.TabStop = false;
            this.grpbcdetails.Text = "Contact Details";
            // 
            // txtcno
            // 
            this.txtcno.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcno.Location = new System.Drawing.Point(186, 180);
            this.txtcno.Name = "txtcno";
            this.txtcno.Size = new System.Drawing.Size(209, 34);
            this.txtcno.TabIndex = 7;
            this.txtcno.TextChanged += new System.EventHandler(this.txtcno_TextChanged);
            // 
            // lblcno
            // 
            this.lblcno.AutoSize = true;
            this.lblcno.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcno.Location = new System.Drawing.Point(35, 183);
            this.lblcno.Name = "lblcno";
            this.lblcno.Size = new System.Drawing.Size(120, 27);
            this.lblcno.TabIndex = 6;
            this.lblcno.Text = "Contact No";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(186, 133);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(549, 34);
            this.txtemail.TabIndex = 5;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(35, 133);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(63, 27);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "Email";
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(186, 47);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(549, 68);
            this.txtaddress.TabIndex = 3;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(35, 47);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(89, 27);
            this.lbladdress.TabIndex = 2;
            this.lbladdress.Text = "Address";
            // 
            // grpbbdetails
            // 
            this.grpbbdetails.Controls.Add(this.rbfemale);
            this.grpbbdetails.Controls.Add(this.rbmale);
            this.grpbbdetails.Controls.Add(this.lblgen);
            this.grpbbdetails.Controls.Add(this.dtpdob);
            this.grpbbdetails.Controls.Add(this.lbldob);
            this.grpbbdetails.Controls.Add(this.txtname);
            this.grpbbdetails.Controls.Add(this.lblname);
            this.grpbbdetails.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbbdetails.Location = new System.Drawing.Point(31, 120);
            this.grpbbdetails.Name = "grpbbdetails";
            this.grpbbdetails.Size = new System.Drawing.Size(754, 208);
            this.grpbbdetails.TabIndex = 2;
            this.grpbbdetails.TabStop = false;
            this.grpbbdetails.Text = "Basic Details";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfemale.Location = new System.Drawing.Point(316, 157);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(105, 31);
            this.rbfemale.TabIndex = 8;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmale.Location = new System.Drawing.Point(186, 157);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(84, 31);
            this.rbmale.TabIndex = 7;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // lblgen
            // 
            this.lblgen.AutoSize = true;
            this.lblgen.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgen.Location = new System.Drawing.Point(35, 159);
            this.lblgen.Name = "lblgen";
            this.lblgen.Size = new System.Drawing.Size(82, 27);
            this.lblgen.TabIndex = 6;
            this.lblgen.Text = "Gender";
            // 
            // dtpdob
            // 
            this.dtpdob.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdob.Location = new System.Drawing.Point(186, 106);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(301, 34);
            this.dtpdob.TabIndex = 5;
            this.dtpdob.ValueChanged += new System.EventHandler(this.dtpdob_ValueChanged);
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(35, 112);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(133, 27);
            this.lbldob.TabIndex = 4;
            this.lbldob.Text = "Date of Birth";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(186, 57);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(549, 34);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(35, 62);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(75, 27);
            this.lblname.TabIndex = 0;
            this.lblname.Text = " Name";
            // 
            // cmblecid
            // 
            this.cmblecid.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmblecid.FormattingEnabled = true;
            this.cmblecid.Location = new System.Drawing.Point(217, 44);
            this.cmblecid.Name = "cmblecid";
            this.cmblecid.Size = new System.Drawing.Size(184, 38);
            this.cmblecid.TabIndex = 1;
            this.cmblecid.SelectedIndexChanged += new System.EventHandler(this.cmblecid_SelectedIndexChanged);
            // 
            // lbllecid
            // 
            this.lbllecid.AutoSize = true;
            this.lbllecid.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllecid.Location = new System.Drawing.Point(66, 44);
            this.lbllecid.Name = "lbllecid";
            this.lbllecid.Size = new System.Drawing.Size(70, 27);
            this.lbllecid.TabIndex = 0;
            this.lbllecid.Text = "Lec ID";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.Control;
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnexit.Location = new System.Drawing.Point(721, 850);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(93, 46);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frmlecregi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 924);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.grpblecregi);
            this.Controls.Add(this.lblskillsi);
            this.Name = "frmlecregi";
            this.Text = "LecturerRegistration";
            this.grpblecregi.ResumeLayout(false);
            this.grpblecregi.PerformLayout();
            this.grpbcdetails.ResumeLayout(false);
            this.grpbcdetails.PerformLayout();
            this.grpbbdetails.ResumeLayout(false);
            this.grpbbdetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblskillsi;
        private System.Windows.Forms.GroupBox grpblecregi;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.GroupBox grpbcdetails;
        private System.Windows.Forms.TextBox txtcno;
        private System.Windows.Forms.Label lblcno;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.GroupBox grpbbdetails;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.Label lblgen;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ComboBox cmblecid;
        private System.Windows.Forms.Label lbllecid;
        private System.Windows.Forms.Button btnregi;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnupd;
    }
}