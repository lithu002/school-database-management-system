namespace FinalProject
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.lblskillsi = new System.Windows.Forms.Label();
            this.grpblogin = new System.Windows.Forms.GroupBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.txtun = new System.Windows.Forms.TextBox();
            this.lblpw = new System.Windows.Forms.Label();
            this.lblun = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.pbskillsinternational = new System.Windows.Forms.PictureBox();
            this.grpblogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbskillsinternational)).BeginInit();
            this.SuspendLayout();
            // 
            // lblskillsi
            // 
            this.lblskillsi.AutoSize = true;
            this.lblskillsi.BackColor = System.Drawing.Color.Transparent;
            this.lblskillsi.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblskillsi.ForeColor = System.Drawing.Color.Navy;
            this.lblskillsi.Location = new System.Drawing.Point(221, 309);
            this.lblskillsi.Name = "lblskillsi";
            this.lblskillsi.Size = new System.Drawing.Size(372, 51);
            this.lblskillsi.TabIndex = 1;
            this.lblskillsi.Text = "Skills International";
            // 
            // grpblogin
            // 
            this.grpblogin.BackColor = System.Drawing.Color.Transparent;
            this.grpblogin.Controls.Add(this.btnlogin);
            this.grpblogin.Controls.Add(this.txtpw);
            this.grpblogin.Controls.Add(this.txtun);
            this.grpblogin.Controls.Add(this.lblpw);
            this.grpblogin.Controls.Add(this.lblun);
            this.grpblogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpblogin.Location = new System.Drawing.Point(123, 363);
            this.grpblogin.Name = "grpblogin";
            this.grpblogin.Size = new System.Drawing.Size(547, 256);
            this.grpblogin.TabIndex = 2;
            this.grpblogin.TabStop = false;
            this.grpblogin.Text = "Login";
            this.grpblogin.Enter += new System.EventHandler(this.grpblogin_Enter);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnlogin.Location = new System.Drawing.Point(187, 184);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(100, 51);
            this.btnlogin.TabIndex = 8;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpw
            // 
            this.txtpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpw.Location = new System.Drawing.Point(230, 136);
            this.txtpw.Name = "txtpw";
            this.txtpw.PasswordChar = '*';
            this.txtpw.Size = new System.Drawing.Size(288, 30);
            this.txtpw.TabIndex = 6;
            this.txtpw.TextChanged += new System.EventHandler(this.txtpw_TextChanged);
            // 
            // txtun
            // 
            this.txtun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtun.Location = new System.Drawing.Point(230, 75);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(288, 30);
            this.txtun.TabIndex = 5;
            this.txtun.TextChanged += new System.EventHandler(this.txtun_TextChanged);
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpw.Location = new System.Drawing.Point(24, 136);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(120, 28);
            this.lblpw.TabIndex = 4;
            this.lblpw.Text = "Password";
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.Location = new System.Drawing.Point(24, 71);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(126, 28);
            this.lblun.TabIndex = 3;
            this.lblun.Text = "Username";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.Control;
            this.btnclear.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnclear.Location = new System.Drawing.Point(32, 635);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(126, 52);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.Control;
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnexit.Location = new System.Drawing.Point(639, 23);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(112, 56);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pbskillsinternational
            // 
            this.pbskillsinternational.Image = ((System.Drawing.Image)(resources.GetObject("pbskillsinternational.Image")));
            this.pbskillsinternational.Location = new System.Drawing.Point(301, 23);
            this.pbskillsinternational.Name = "pbskillsinternational";
            this.pbskillsinternational.Size = new System.Drawing.Size(238, 271);
            this.pbskillsinternational.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbskillsinternational.TabIndex = 9;
            this.pbskillsinternational.TabStop = false;
            this.pbskillsinternational.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 765);
            this.Controls.Add(this.pbskillsinternational);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.grpblogin);
            this.Controls.Add(this.lblskillsi);
            this.Name = "frmlogin";
            this.Text = "Login - Skills International";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpblogin.ResumeLayout(false);
            this.grpblogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbskillsinternational)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblskillsi;
        private System.Windows.Forms.GroupBox grpblogin;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox pbskillsinternational;

    }
}

