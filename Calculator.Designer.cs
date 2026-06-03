namespace FinalProject
{
    partial class frmcalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcalculator));
            this.grpbreportcard = new System.Windows.Forms.GroupBox();
            this.lblavg = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtavg = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtenglish = new System.Windows.Forms.TextBox();
            this.txtscience = new System.Windows.Forms.TextBox();
            this.txtict = new System.Windows.Forms.TextBox();
            this.txtmaths = new System.Windows.Forms.TextBox();
            this.lblict = new System.Windows.Forms.Label();
            this.lblenglish = new System.Windows.Forms.Label();
            this.lblscience = new System.Windows.Forms.Label();
            this.lblmaths = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblstdreport = new System.Windows.Forms.Label();
            this.lblregno = new System.Windows.Forms.Label();
            this.cmbregno = new System.Windows.Forms.ComboBox();
            this.grpbreportcard.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbreportcard
            // 
            this.grpbreportcard.BackColor = System.Drawing.Color.Transparent;
            this.grpbreportcard.Controls.Add(this.lblavg);
            this.grpbreportcard.Controls.Add(this.txttotal);
            this.grpbreportcard.Controls.Add(this.txtavg);
            this.grpbreportcard.Controls.Add(this.lbltotal);
            this.grpbreportcard.Controls.Add(this.txtenglish);
            this.grpbreportcard.Controls.Add(this.txtscience);
            this.grpbreportcard.Controls.Add(this.txtict);
            this.grpbreportcard.Controls.Add(this.txtmaths);
            this.grpbreportcard.Controls.Add(this.lblict);
            this.grpbreportcard.Controls.Add(this.lblenglish);
            this.grpbreportcard.Controls.Add(this.lblscience);
            this.grpbreportcard.Controls.Add(this.lblmaths);
            this.grpbreportcard.Font = new System.Drawing.Font("Microsoft YaHei", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbreportcard.Location = new System.Drawing.Point(107, 219);
            this.grpbreportcard.Name = "grpbreportcard";
            this.grpbreportcard.Size = new System.Drawing.Size(380, 370);
            this.grpbreportcard.TabIndex = 1;
            this.grpbreportcard.TabStop = false;
            this.grpbreportcard.Text = "Marks Summary";
            this.grpbreportcard.Enter += new System.EventHandler(this.grpbreportcard_Enter);
            // 
            // lblavg
            // 
            this.lblavg.AutoSize = true;
            this.lblavg.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavg.Location = new System.Drawing.Point(33, 301);
            this.lblavg.Name = "lblavg";
            this.lblavg.Size = new System.Drawing.Size(96, 27);
            this.lblavg.TabIndex = 11;
            this.lblavg.Text = "Average";
            this.lblavg.Click += new System.EventHandler(this.label2_Click);
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(206, 252);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 37);
            this.txttotal.TabIndex = 10;
            // 
            // txtavg
            // 
            this.txtavg.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtavg.Location = new System.Drawing.Point(206, 295);
            this.txtavg.Name = "txtavg";
            this.txtavg.Size = new System.Drawing.Size(100, 37);
            this.txtavg.TabIndex = 9;
            this.txtavg.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.Black;
            this.lbltotal.Location = new System.Drawing.Point(33, 258);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(64, 27);
            this.lbltotal.TabIndex = 8;
            this.lbltotal.Text = "Total";
            // 
            // txtenglish
            // 
            this.txtenglish.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtenglish.Location = new System.Drawing.Point(206, 99);
            this.txtenglish.Name = "txtenglish";
            this.txtenglish.Size = new System.Drawing.Size(100, 37);
            this.txtenglish.TabIndex = 7;
            // 
            // txtscience
            // 
            this.txtscience.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscience.Location = new System.Drawing.Point(206, 144);
            this.txtscience.Name = "txtscience";
            this.txtscience.Size = new System.Drawing.Size(100, 37);
            this.txtscience.TabIndex = 6;
            // 
            // txtict
            // 
            this.txtict.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtict.Location = new System.Drawing.Point(206, 189);
            this.txtict.Name = "txtict";
            this.txtict.Size = new System.Drawing.Size(100, 37);
            this.txtict.TabIndex = 5;
            // 
            // txtmaths
            // 
            this.txtmaths.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaths.Location = new System.Drawing.Point(206, 54);
            this.txtmaths.Name = "txtmaths";
            this.txtmaths.Size = new System.Drawing.Size(100, 37);
            this.txtmaths.TabIndex = 4;
            // 
            // lblict
            // 
            this.lblict.AutoSize = true;
            this.lblict.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblict.Location = new System.Drawing.Point(33, 196);
            this.lblict.Name = "lblict";
            this.lblict.Size = new System.Drawing.Size(42, 27);
            this.lblict.TabIndex = 3;
            this.lblict.Text = "ICT";
            // 
            // lblenglish
            // 
            this.lblenglish.AutoSize = true;
            this.lblenglish.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenglish.Location = new System.Drawing.Point(33, 106);
            this.lblenglish.Name = "lblenglish";
            this.lblenglish.Size = new System.Drawing.Size(79, 27);
            this.lblenglish.TabIndex = 2;
            this.lblenglish.Text = "English";
            this.lblenglish.Click += new System.EventHandler(this.lblenglish_Click);
            // 
            // lblscience
            // 
            this.lblscience.AutoSize = true;
            this.lblscience.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscience.Location = new System.Drawing.Point(33, 151);
            this.lblscience.Name = "lblscience";
            this.lblscience.Size = new System.Drawing.Size(83, 27);
            this.lblscience.TabIndex = 1;
            this.lblscience.Text = "Science";
            // 
            // lblmaths
            // 
            this.lblmaths.AutoSize = true;
            this.lblmaths.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaths.Location = new System.Drawing.Point(33, 61);
            this.lblmaths.Name = "lblmaths";
            this.lblmaths.Size = new System.Drawing.Size(134, 27);
            this.lblmaths.TabIndex = 0;
            this.lblmaths.Text = "Mathematics";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.Control;
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnexit.Location = new System.Drawing.Point(12, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(92, 47);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnclear.Location = new System.Drawing.Point(133, 625);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(94, 44);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.ForeColor = System.Drawing.Color.DarkGreen;
            this.btncalculate.Location = new System.Drawing.Point(321, 625);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(144, 44);
            this.btncalculate.TabIndex = 16;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lblstdreport
            // 
            this.lblstdreport.AutoSize = true;
            this.lblstdreport.BackColor = System.Drawing.Color.Transparent;
            this.lblstdreport.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstdreport.ForeColor = System.Drawing.Color.Navy;
            this.lblstdreport.Location = new System.Drawing.Point(170, 49);
            this.lblstdreport.Name = "lblstdreport";
            this.lblstdreport.Size = new System.Drawing.Size(295, 46);
            this.lblstdreport.TabIndex = 17;
            this.lblstdreport.Text = "Student\'s Report";
            // 
            // lblregno
            // 
            this.lblregno.AutoSize = true;
            this.lblregno.BackColor = System.Drawing.Color.Transparent;
            this.lblregno.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregno.Location = new System.Drawing.Point(128, 147);
            this.lblregno.Name = "lblregno";
            this.lblregno.Size = new System.Drawing.Size(87, 27);
            this.lblregno.TabIndex = 18;
            this.lblregno.Text = "Reg No";
            // 
            // cmbregno
            // 
            this.cmbregno.FormattingEnabled = true;
            this.cmbregno.Location = new System.Drawing.Point(292, 146);
            this.cmbregno.Name = "cmbregno";
            this.cmbregno.Size = new System.Drawing.Size(184, 28);
            this.cmbregno.TabIndex = 19;
            // 
            // frmcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 701);
            this.Controls.Add(this.cmbregno);
            this.Controls.Add(this.lblregno);
            this.Controls.Add(this.lblstdreport);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.grpbreportcard);
            this.Name = "frmcalculator";
            this.Text = "Calculator";
            this.grpbreportcard.ResumeLayout(false);
            this.grpbreportcard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbreportcard;
        private System.Windows.Forms.Label lblmaths;
        private System.Windows.Forms.Label lblenglish;
        private System.Windows.Forms.Label lblscience;
        private System.Windows.Forms.Label lblict;
        private System.Windows.Forms.TextBox txtenglish;
        private System.Windows.Forms.TextBox txtscience;
        private System.Windows.Forms.TextBox txtict;
        private System.Windows.Forms.TextBox txtmaths;
        private System.Windows.Forms.Label lblavg;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtavg;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblstdreport;
        private System.Windows.Forms.Label lblregno;
        private System.Windows.Forms.ComboBox cmbregno;

    }
}