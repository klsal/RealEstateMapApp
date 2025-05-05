namespace RealEstateMapApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAffordable = new System.Windows.Forms.Label();
            this.lblMidRange = new System.Windows.Forms.Label();
            this.lblExpensive = new System.Windows.Forms.Label();
            this.pnlGreen = new System.Windows.Forms.Panel();
            this.pnlOrange = new System.Windows.Forms.Panel();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 60);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(884, 441);
            this.webBrowser.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 60);
            this.panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(433, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Real Estate Prices in Google Maps - Jeddah";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pnlRed);
            this.panel2.Controls.Add(this.pnlOrange);
            this.panel2.Controls.Add(this.pnlGreen);
            this.panel2.Controls.Add(this.lblExpensive);
            this.panel2.Controls.Add(this.lblMidRange);
            this.panel2.Controls.Add(this.lblAffordable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 44);
            this.panel2.TabIndex = 2;
            // 
            // lblAffordable
            // 
            this.lblAffordable.AutoSize = true;
            this.lblAffordable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffordable.Location = new System.Drawing.Point(38, 13);
            this.lblAffordable.Name = "lblAffordable";
            this.lblAffordable.Size = new System.Drawing.Size(132, 17);
            this.lblAffordable.TabIndex = 0;
            this.lblAffordable.Text = "Affordable (<700,000)";
            // 
            // lblMidRange
            // 
            this.lblMidRange.AutoSize = true;
            this.lblMidRange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidRange.Location = new System.Drawing.Point(234, 13);
            this.lblMidRange.Name = "lblMidRange";
            this.lblMidRange.Size = new System.Drawing.Size(188, 17);
            this.lblMidRange.TabIndex = 1;
            this.lblMidRange.Text = "Mid-Range (700,000-1,000,000)";
            // 
            // lblExpensive
            // 
            this.lblExpensive.AutoSize = true;
            this.lblExpensive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpensive.Location = new System.Drawing.Point(468, 13);
            this.lblExpensive.Name = "lblExpensive";
            this.lblExpensive.Size = new System.Drawing.Size(147, 17);
            this.lblExpensive.TabIndex = 2;
            this.lblExpensive.Text = "Expensive (>1,000,000)";
            // 
            // pnlGreen
            // 
            this.pnlGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.pnlGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGreen.Location = new System.Drawing.Point(15, 13);
            this.pnlGreen.Name = "pnlGreen";
            this.pnlGreen.Size = new System.Drawing.Size(17, 17);
            this.pnlGreen.TabIndex = 3;
            // 
            // pnlOrange
            // 
            this.pnlOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.pnlOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrange.Location = new System.Drawing.Point(211, 13);
            this.pnlOrange.Name = "pnlOrange";
            this.pnlOrange.Size = new System.Drawing.Size(17, 17);
            this.pnlOrange.TabIndex = 4;
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.pnlRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRed.Location = new System.Drawing.Point(445, 13);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(17, 17);
            this.pnlRed.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real Estate Prices in Google Maps - Jeddah";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Panel pnlOrange;
        private System.Windows.Forms.Panel pnlGreen;
        private System.Windows.Forms.Label lblExpensive;
        private System.Windows.Forms.Label lblMidRange;
        private System.Windows.Forms.Label lblAffordable;
    }
}

