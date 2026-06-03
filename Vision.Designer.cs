namespace FinalProject
{
    partial class frmvision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvision));
            this.lblvision = new System.Windows.Forms.Label();
            this.lbldesvision = new System.Windows.Forms.Label();
            this.llblexit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblvision
            // 
            this.lblvision.AutoSize = true;
            this.lblvision.BackColor = System.Drawing.Color.Transparent;
            this.lblvision.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblvision.Location = new System.Drawing.Point(285, 41);
            this.lblvision.Name = "lblvision";
            this.lblvision.Size = new System.Drawing.Size(185, 58);
            this.lblvision.TabIndex = 0;
            this.lblvision.Text = "VISION";
            // 
            // lbldesvision
            // 
            this.lbldesvision.BackColor = System.Drawing.Color.Transparent;
            this.lbldesvision.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesvision.Location = new System.Drawing.Point(78, 135);
            this.lbldesvision.Name = "lbldesvision";
            this.lbldesvision.Size = new System.Drawing.Size(632, 269);
            this.lbldesvision.TabIndex = 1;
            this.lbldesvision.Text = resources.GetString("lbldesvision.Text");
            this.lbldesvision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbldesvision.Click += new System.EventHandler(this.lbldesvision_Click);
            // 
            // llblexit
            // 
            this.llblexit.AutoSize = true;
            this.llblexit.BackColor = System.Drawing.Color.Transparent;
            this.llblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblexit.Location = new System.Drawing.Point(727, 24);
            this.llblexit.Name = "llblexit";
            this.llblexit.Size = new System.Drawing.Size(44, 25);
            this.llblexit.TabIndex = 2;
            this.llblexit.TabStop = true;
            this.llblexit.Text = "Exit";
            this.llblexit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmvision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 489);
            this.Controls.Add(this.llblexit);
            this.Controls.Add(this.lbldesvision);
            this.Controls.Add(this.lblvision);
            this.Name = "frmvision";
            this.Text = "Vision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvision;
        private System.Windows.Forms.Label lbldesvision;
        private System.Windows.Forms.LinkLabel llblexit;
    }
}