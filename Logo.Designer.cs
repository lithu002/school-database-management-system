namespace FinalProject
{
    partial class frmlogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogo));
            this.llblexit = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // llblexit
            // 
            this.llblexit.AutoSize = true;
            this.llblexit.BackColor = System.Drawing.Color.Transparent;
            this.llblexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblexit.Location = new System.Drawing.Point(818, 59);
            this.llblexit.Name = "llblexit";
            this.llblexit.Size = new System.Drawing.Size(44, 25);
            this.llblexit.TabIndex = 4;
            this.llblexit.TabStop = true;
            this.llblexit.Text = "Exit";
            this.llblexit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblexit_LinkClicked);
            // 
            // frmlogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(913, 703);
            this.Controls.Add(this.llblexit);
            this.Name = "frmlogo";
            this.Text = "Logo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblexit;
    }
}