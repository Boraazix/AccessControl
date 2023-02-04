namespace AccessControl
{
    partial class frmAbout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.ttLigaI = new System.Windows.Forms.ToolTip(this.components);
            this.lklblLigaI = new System.Windows.Forms.LinkLabel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pcbMain = new System.Windows.Forms.PictureBox();
            this.pcbGitHub = new System.Windows.Forms.PictureBox();
            this.pcbLinkedIn = new System.Windows.Forms.PictureBox();
            this.pcbTwitter = new System.Windows.Forms.PictureBox();
            this.pcbGmail = new System.Windows.Forms.PictureBox();
            this.lklblIFNMG = new System.Windows.Forms.LinkLabel();
            this.lklblInternews = new System.Windows.Forms.LinkLabel();
            this.lklblKumon = new System.Windows.Forms.LinkLabel();
            this.lblText = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLinkedIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGmail)).BeginInit();
            this.SuspendLayout();
            // 
            // ttLigaI
            // 
            this.ttLigaI.ToolTipTitle = "Liga I";
            // 
            // lklblLigaI
            // 
            this.lklblLigaI.ActiveLinkColor = System.Drawing.Color.Black;
            this.lklblLigaI.AutoSize = true;
            this.lklblLigaI.LinkColor = System.Drawing.Color.Black;
            this.lklblLigaI.Location = new System.Drawing.Point(102, 277);
            this.lklblLigaI.Name = "lklblLigaI";
            this.lklblLigaI.Size = new System.Drawing.Size(37, 13);
            this.lklblLigaI.TabIndex = 13;
            this.lklblLigaI.TabStop = true;
            this.lklblLigaI.Text = "\'Liga I\'";
            this.ttLigaI.SetToolTip(this.lklblLigaI, "Awards for those who reach subjects of the\r\nHigh School before the Middle School." +
        "");
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pcbMain);
            this.pnlMain.Controls.Add(this.pcbGitHub);
            this.pnlMain.Controls.Add(this.pcbLinkedIn);
            this.pnlMain.Controls.Add(this.pcbTwitter);
            this.pnlMain.Controls.Add(this.pcbGmail);
            this.pnlMain.Controls.Add(this.lklblLigaI);
            this.pnlMain.Controls.Add(this.lklblIFNMG);
            this.pnlMain.Controls.Add(this.lklblInternews);
            this.pnlMain.Controls.Add(this.lklblKumon);
            this.pnlMain.Controls.Add(this.lblText);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(468, 403);
            this.pnlMain.TabIndex = 2;
            // 
            // pcbMain
            // 
            this.pcbMain.ErrorImage = null;
            this.pcbMain.Image = ((System.Drawing.Image)(resources.GetObject("pcbMain.Image")));
            this.pcbMain.InitialImage = null;
            this.pcbMain.Location = new System.Drawing.Point(146, 12);
            this.pcbMain.Name = "pcbMain";
            this.pcbMain.Size = new System.Drawing.Size(193, 184);
            this.pcbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMain.TabIndex = 18;
            this.pcbMain.TabStop = false;
            // 
            // pcbGitHub
            // 
            this.pcbGitHub.Image = ((System.Drawing.Image)(resources.GetObject("pcbGitHub.Image")));
            this.pcbGitHub.Location = new System.Drawing.Point(343, 361);
            this.pcbGitHub.Name = "pcbGitHub";
            this.pcbGitHub.Size = new System.Drawing.Size(94, 30);
            this.pcbGitHub.TabIndex = 17;
            this.pcbGitHub.TabStop = false;
            this.pcbGitHub.Click += new System.EventHandler(this.pcbGitHub_Click);
            // 
            // pcbLinkedIn
            // 
            this.pcbLinkedIn.Image = ((System.Drawing.Image)(resources.GetObject("pcbLinkedIn.Image")));
            this.pcbLinkedIn.Location = new System.Drawing.Point(228, 361);
            this.pcbLinkedIn.Name = "pcbLinkedIn";
            this.pcbLinkedIn.Size = new System.Drawing.Size(109, 30);
            this.pcbLinkedIn.TabIndex = 16;
            this.pcbLinkedIn.TabStop = false;
            this.pcbLinkedIn.Click += new System.EventHandler(this.pcbLinkedIn_Click);
            // 
            // pcbTwitter
            // 
            this.pcbTwitter.Image = ((System.Drawing.Image)(resources.GetObject("pcbTwitter.Image")));
            this.pcbTwitter.Location = new System.Drawing.Point(120, 361);
            this.pcbTwitter.Name = "pcbTwitter";
            this.pcbTwitter.Size = new System.Drawing.Size(102, 30);
            this.pcbTwitter.TabIndex = 15;
            this.pcbTwitter.TabStop = false;
            this.pcbTwitter.Click += new System.EventHandler(this.pcbTwitter_Click);
            // 
            // pcbGmail
            // 
            this.pcbGmail.Image = ((System.Drawing.Image)(resources.GetObject("pcbGmail.Image")));
            this.pcbGmail.Location = new System.Drawing.Point(29, 361);
            this.pcbGmail.Name = "pcbGmail";
            this.pcbGmail.Size = new System.Drawing.Size(85, 30);
            this.pcbGmail.TabIndex = 14;
            this.pcbGmail.TabStop = false;
            this.pcbGmail.Click += new System.EventHandler(this.pcbGmail_Click);
            // 
            // lklblIFNMG
            // 
            this.lklblIFNMG.AutoSize = true;
            this.lklblIFNMG.Location = new System.Drawing.Point(102, 330);
            this.lklblIFNMG.Name = "lklblIFNMG";
            this.lklblIFNMG.Size = new System.Drawing.Size(41, 13);
            this.lklblIFNMG.TabIndex = 12;
            this.lklblIFNMG.TabStop = true;
            this.lklblIFNMG.Text = "IFNMG";
            this.lklblIFNMG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblIFNMG_LinkClicked);
            // 
            // lklblInternews
            // 
            this.lklblInternews.AutoSize = true;
            this.lklblInternews.Location = new System.Drawing.Point(186, 316);
            this.lklblInternews.Name = "lklblInternews";
            this.lklblInternews.Size = new System.Drawing.Size(53, 13);
            this.lklblInternews.TabIndex = 11;
            this.lklblInternews.TabStop = true;
            this.lklblInternews.Text = "Internews";
            this.lklblInternews.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblInternews_LinkClicked);
            // 
            // lklblKumon
            // 
            this.lklblKumon.AutoSize = true;
            this.lklblKumon.BackColor = System.Drawing.Color.Transparent;
            this.lklblKumon.Location = new System.Drawing.Point(88, 264);
            this.lklblKumon.Name = "lklblKumon";
            this.lklblKumon.Size = new System.Drawing.Size(40, 13);
            this.lklblKumon.TabIndex = 10;
            this.lklblKumon.TabStop = true;
            this.lklblKumon.Text = "Kumon";
            this.lklblKumon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblKumon_LinkCLicked);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 199);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(446, 156);
            this.lblText.TabIndex = 9;
            this.lblText.Text = resources.GetString("lblText.Text");
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 403);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(484, 442);
            this.MinimumSize = new System.Drawing.Size(484, 442);
            this.Name = "frmAbout";
            this.Text = "About";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLinkedIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ttLigaI;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pcbMain;
        private System.Windows.Forms.PictureBox pcbGitHub;
        private System.Windows.Forms.PictureBox pcbLinkedIn;
        private System.Windows.Forms.PictureBox pcbTwitter;
        private System.Windows.Forms.PictureBox pcbGmail;
        private System.Windows.Forms.LinkLabel lklblLigaI;
        private System.Windows.Forms.LinkLabel lklblIFNMG;
        private System.Windows.Forms.LinkLabel lklblInternews;
        private System.Windows.Forms.LinkLabel lklblKumon;
        private System.Windows.Forms.Label lblText;
    }
}