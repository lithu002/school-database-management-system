namespace FinalProject
{
    partial class frmstdregi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstdregi));
            this.llbllogout = new System.Windows.Forms.LinkLabel();
            this.lblskillsi = new System.Windows.Forms.Label();
            this.grpbstdregi = new System.Windows.Forms.GroupBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.grpbpdetails = new System.Windows.Forms.GroupBox();
            this.txtcno = new System.Windows.Forms.TextBox();
            this.lblcno = new System.Windows.Forms.Label();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.lblnic = new System.Windows.Forms.Label();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.lblpname = new System.Windows.Forms.Label();
            this.grpbcdetails = new System.Windows.Forms.GroupBox();
            this.txthphone = new System.Windows.Forms.TextBox();
            this.lblhphone = new System.Windows.Forms.Label();
            this.txtmphone = new System.Windows.Forms.TextBox();
            this.lblmphone = new System.Windows.Forms.Label();
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
            this.txtln = new System.Windows.Forms.TextBox();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.lblln = new System.Windows.Forms.Label();
            this.lblfn = new System.Windows.Forms.Label();
            this.cmbregno = new System.Windows.Forms.ComboBox();
            this.lblregno = new System.Windows.Forms.Label();
            this.llblexit = new System.Windows.Forms.LinkLabel();
            this.grpbstdregi.SuspendLayout();
            this.grpbpdetails.SuspendLayout();
            this.grpbcdetails.SuspendLayout();
            this.grpbbdetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // llbllogout
            // 
            this.llbllogout.AutoSize = true;
            this.llbllogout.BackColor = System.Drawing.Color.Transparent;
            this.llbllogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbllogout.Location = new System.Drawing.Point(12, 9);
            this.llbllogout.Name = "llbllogout";
            this.llbllogout.Size = new System.Drawing.Size(72, 25);
            this.llbllogout.TabIndex = 0;
            this.llbllogout.TabStop = true;
            this.llbllogout.Text = "Logout";
            this.llbllogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbllogout_LinkClicked);
            // 
            // lblskillsi
            // 
            this.lblskillsi.AutoSize = true;
            this.lblskillsi.BackColor = System.Drawing.Color.Transparent;
            this.lblskillsi.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblskillsi.ForeColor = System.Drawing.Color.Navy;
            this.lblskillsi.Location = new System.Drawing.Point(281, 20);
            this.lblskillsi.Name = "lblskillsi";
            this.lblskillsi.Size = new System.Drawing.Size(372, 51);
            this.lblskillsi.TabIndex = 1;
            this.lblskillsi.Text = "Skills International";
            this.lblskillsi.Click += new System.EventHandler(this.lblskillsi_Click);
            // 
            // grpbstdregi
            // 
            this.grpbstdregi.BackColor = System.Drawing.Color.Transparent;
            this.grpbstdregi.Controls.Add(this.btnclear);
            this.grpbstdregi.Controls.Add(this.btndelete);
            this.grpbstdregi.Controls.Add(this.btnupdate);
            this.grpbstdregi.Controls.Add(this.btnregister);
            this.grpbstdregi.Controls.Add(this.grpbpdetails);
            this.grpbstdregi.Controls.Add(this.grpbcdetails);
            this.grpbstdregi.Controls.Add(this.grpbbdetails);
            this.grpbstdregi.Controls.Add(this.cmbregno);
            this.grpbstdregi.Controls.Add(this.lblregno);
            this.grpbstdregi.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbstdregi.Location = new System.Drawing.Point(45, 74);
            this.grpbstdregi.Name = "grpbstdregi";
            this.grpbstdregi.Size = new System.Drawing.Size(824, 844);
            this.grpbstdregi.TabIndex = 2;
            this.grpbstdregi.TabStop = false;
            this.grpbstdregi.Text = "Student Registration";
            this.grpbstdregi.Enter += new System.EventHandler(this.grpbstdregi_Enter_1);
            // 
            // btnclear
            // 
            this.btnclear.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnclear.Location = new System.Drawing.Point(497, 784);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(94, 43);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.ForeColor = System.Drawing.Color.Crimson;
            this.btndelete.Location = new System.Drawing.Point(661, 786);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 45);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.ForeColor = System.Drawing.Color.Indigo;
            this.btnupdate.Location = new System.Drawing.Point(217, 784);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(110, 47);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnregister
            // 
            this.btnregister.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnregister.Location = new System.Drawing.Point(48, 784);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(117, 43);
            this.btnregister.TabIndex = 8;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // grpbpdetails
            // 
            this.grpbpdetails.Controls.Add(this.txtcno);
            this.grpbpdetails.Controls.Add(this.lblcno);
            this.grpbpdetails.Controls.Add(this.txtnic);
            this.grpbpdetails.Controls.Add(this.lblnic);
            this.grpbpdetails.Controls.Add(this.txtpname);
            this.grpbpdetails.Controls.Add(this.lblpname);
            this.grpbpdetails.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbpdetails.Location = new System.Drawing.Point(31, 596);
            this.grpbpdetails.Name = "grpbpdetails";
            this.grpbpdetails.Size = new System.Drawing.Size(754, 182);
            this.grpbpdetails.TabIndex = 10;
            this.grpbpdetails.TabStop = false;
            this.grpbpdetails.Text = "Parent Details";
            // 
            // txtcno
            // 
            this.txtcno.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcno.Location = new System.Drawing.Point(211, 123);
            this.txtcno.Name = "txtcno";
            this.txtcno.Size = new System.Drawing.Size(184, 34);
            this.txtcno.TabIndex = 7;
            this.txtcno.TextChanged += new System.EventHandler(this.txtcno_TextChanged);
            // 
            // lblcno
            // 
            this.lblcno.AutoSize = true;
            this.lblcno.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcno.Location = new System.Drawing.Point(35, 130);
            this.lblcno.Name = "lblcno";
            this.lblcno.Size = new System.Drawing.Size(170, 27);
            this.lblcno.TabIndex = 6;
            this.lblcno.Text = "Contact Number";
            this.lblcno.Click += new System.EventHandler(this.lblcno_Click);
            // 
            // txtnic
            // 
            this.txtnic.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnic.Location = new System.Drawing.Point(211, 76);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(184, 34);
            this.txtnic.TabIndex = 5;
            this.txtnic.TextChanged += new System.EventHandler(this.txtnic_TextChanged);
            // 
            // lblnic
            // 
            this.lblnic.AutoSize = true;
            this.lblnic.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnic.Location = new System.Drawing.Point(35, 83);
            this.lblnic.Name = "lblnic";
            this.lblnic.Size = new System.Drawing.Size(47, 27);
            this.lblnic.TabIndex = 4;
            this.lblnic.Text = "NIC";
            // 
            // txtpname
            // 
            this.txtpname.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpname.Location = new System.Drawing.Point(211, 28);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(524, 34);
            this.txtpname.TabIndex = 3;
            this.txtpname.TextChanged += new System.EventHandler(this.txtpname_TextChanged);
            // 
            // lblpname
            // 
            this.lblpname.AutoSize = true;
            this.lblpname.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpname.Location = new System.Drawing.Point(35, 35);
            this.lblpname.Name = "lblpname";
            this.lblpname.Size = new System.Drawing.Size(136, 27);
            this.lblpname.TabIndex = 2;
            this.lblpname.Text = "Parent Name";
            // 
            // grpbcdetails
            // 
            this.grpbcdetails.Controls.Add(this.txthphone);
            this.grpbcdetails.Controls.Add(this.lblhphone);
            this.grpbcdetails.Controls.Add(this.txtmphone);
            this.grpbcdetails.Controls.Add(this.lblmphone);
            this.grpbcdetails.Controls.Add(this.txtemail);
            this.grpbcdetails.Controls.Add(this.lblemail);
            this.grpbcdetails.Controls.Add(this.txtaddress);
            this.grpbcdetails.Controls.Add(this.lbladdress);
            this.grpbcdetails.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbcdetails.Location = new System.Drawing.Point(31, 353);
            this.grpbcdetails.Name = "grpbcdetails";
            this.grpbcdetails.Size = new System.Drawing.Size(754, 237);
            this.grpbcdetails.TabIndex = 9;
            this.grpbcdetails.TabStop = false;
            this.grpbcdetails.Text = "Contact Details";
            // 
            // txthphone
            // 
            this.txthphone.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthphone.Location = new System.Drawing.Point(564, 188);
            this.txthphone.Name = "txthphone";
            this.txthphone.Size = new System.Drawing.Size(171, 34);
            this.txthphone.TabIndex = 9;
            this.txthphone.TextChanged += new System.EventHandler(this.txthphone_TextChanged);
            // 
            // lblhphone
            // 
            this.lblhphone.AutoSize = true;
            this.lblhphone.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhphone.Location = new System.Drawing.Point(424, 188);
            this.lblhphone.Name = "lblhphone";
            this.lblhphone.Size = new System.Drawing.Size(136, 27);
            this.lblhphone.TabIndex = 8;
            this.lblhphone.Text = "Home Phone";
            // 
            // txtmphone
            // 
            this.txtmphone.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmphone.Location = new System.Drawing.Point(186, 183);
            this.txtmphone.Name = "txtmphone";
            this.txtmphone.Size = new System.Drawing.Size(184, 34);
            this.txtmphone.TabIndex = 7;
            this.txtmphone.TextChanged += new System.EventHandler(this.txtmphone_TextChanged);
            // 
            // lblmphone
            // 
            this.lblmphone.AutoSize = true;
            this.lblmphone.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmphone.Location = new System.Drawing.Point(35, 183);
            this.lblmphone.Name = "lblmphone";
            this.lblmphone.Size = new System.Drawing.Size(145, 27);
            this.lblmphone.TabIndex = 6;
            this.lblmphone.Text = "Mobile Phone";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(186, 133);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(549, 34);
            this.txtemail.TabIndex = 5;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
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
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
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
            this.grpbbdetails.Controls.Add(this.txtln);
            this.grpbbdetails.Controls.Add(this.txtfn);
            this.grpbbdetails.Controls.Add(this.lblln);
            this.grpbbdetails.Controls.Add(this.lblfn);
            this.grpbbdetails.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbbdetails.Location = new System.Drawing.Point(31, 88);
            this.grpbbdetails.Name = "grpbbdetails";
            this.grpbbdetails.Size = new System.Drawing.Size(754, 259);
            this.grpbbdetails.TabIndex = 2;
            this.grpbbdetails.TabStop = false;
            this.grpbbdetails.Text = "Basic Details";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfemale.Location = new System.Drawing.Point(311, 218);
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
            this.rbmale.Location = new System.Drawing.Point(186, 218);
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
            this.lblgen.Location = new System.Drawing.Point(35, 218);
            this.lblgen.Name = "lblgen";
            this.lblgen.Size = new System.Drawing.Size(82, 27);
            this.lblgen.TabIndex = 6;
            this.lblgen.Text = "Gender";
            // 
            // dtpdob
            // 
            this.dtpdob.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdob.Location = new System.Drawing.Point(186, 161);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(301, 34);
            this.dtpdob.TabIndex = 5;
            this.dtpdob.ValueChanged += new System.EventHandler(this.dtpdob_ValueChanged);
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(35, 161);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(133, 27);
            this.lbldob.TabIndex = 4;
            this.lbldob.Text = "Date of Birth";
            // 
            // txtln
            // 
            this.txtln.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtln.Location = new System.Drawing.Point(186, 104);
            this.txtln.Name = "txtln";
            this.txtln.Size = new System.Drawing.Size(549, 34);
            this.txtln.TabIndex = 3;
            this.txtln.TextChanged += new System.EventHandler(this.txtln_TextChanged);
            // 
            // txtfn
            // 
            this.txtfn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfn.Location = new System.Drawing.Point(186, 59);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(549, 34);
            this.txtfn.TabIndex = 2;
            this.txtfn.TextChanged += new System.EventHandler(this.txtfn_TextChanged);
            // 
            // lblln
            // 
            this.lblln.AutoSize = true;
            this.lblln.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblln.Location = new System.Drawing.Point(35, 109);
            this.lblln.Name = "lblln";
            this.lblln.Size = new System.Drawing.Size(112, 27);
            this.lblln.TabIndex = 1;
            this.lblln.Text = "Last Name";
            // 
            // lblfn
            // 
            this.lblfn.AutoSize = true;
            this.lblfn.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfn.Location = new System.Drawing.Point(35, 62);
            this.lblfn.Name = "lblfn";
            this.lblfn.Size = new System.Drawing.Size(115, 27);
            this.lblfn.TabIndex = 0;
            this.lblfn.Text = "First Name";
            // 
            // cmbregno
            // 
            this.cmbregno.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbregno.FormattingEnabled = true;
            this.cmbregno.Location = new System.Drawing.Point(217, 44);
            this.cmbregno.Name = "cmbregno";
            this.cmbregno.Size = new System.Drawing.Size(184, 38);
            this.cmbregno.TabIndex = 1;
            this.cmbregno.SelectedIndexChanged += new System.EventHandler(this.cmbregno_SelectedIndexChanged);
            // 
            // lblregno
            // 
            this.lblregno.AutoSize = true;
            this.lblregno.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregno.Location = new System.Drawing.Point(66, 44);
            this.lblregno.Name = "lblregno";
            this.lblregno.Size = new System.Drawing.Size(84, 27);
            this.lblregno.TabIndex = 0;
            this.lblregno.Text = "Reg No";
            this.lblregno.Click += new System.EventHandler(this.lblregno_Click);
            // 
            // llblexit
            // 
            this.llblexit.AutoSize = true;
            this.llblexit.BackColor = System.Drawing.Color.Transparent;
            this.llblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblexit.Location = new System.Drawing.Point(808, 933);
            this.llblexit.Name = "llblexit";
            this.llblexit.Size = new System.Drawing.Size(44, 25);
            this.llblexit.TabIndex = 3;
            this.llblexit.TabStop = true;
            this.llblexit.Text = "Exit";
            this.llblexit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblexit_LinkClicked);
            // 
            // frmstdregi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 977);
            this.Controls.Add(this.llblexit);
            this.Controls.Add(this.grpbstdregi);
            this.Controls.Add(this.lblskillsi);
            this.Controls.Add(this.llbllogout);
            this.Name = "frmstdregi";
            this.Text = "Student Registration - Skills International";
            this.Load += new System.EventHandler(this.frmsr_Load);
            this.grpbstdregi.ResumeLayout(false);
            this.grpbstdregi.PerformLayout();
            this.grpbpdetails.ResumeLayout(false);
            this.grpbpdetails.PerformLayout();
            this.grpbcdetails.ResumeLayout(false);
            this.grpbcdetails.PerformLayout();
            this.grpbbdetails.ResumeLayout(false);
            this.grpbbdetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbllogout;
        private System.Windows.Forms.Label lblskillsi;
        private System.Windows.Forms.GroupBox grpbstdregi;
        private System.Windows.Forms.GroupBox grpbcdetails;
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
        private System.Windows.Forms.TextBox txtln;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.Label lblln;
        private System.Windows.Forms.Label lblfn;
        private System.Windows.Forms.ComboBox cmbregno;
        private System.Windows.Forms.Label lblregno;
        private System.Windows.Forms.GroupBox grpbpdetails;
        private System.Windows.Forms.TextBox txtcno;
        private System.Windows.Forms.Label lblcno;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.Label lblnic;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.Label lblpname;
        private System.Windows.Forms.TextBox txthphone;
        private System.Windows.Forms.Label lblhphone;
        private System.Windows.Forms.TextBox txtmphone;
        private System.Windows.Forms.Label lblmphone;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.LinkLabel llblexit;

    }
}