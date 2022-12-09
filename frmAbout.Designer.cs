﻿namespace AccessControl
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pcbMain = new System.Windows.Forms.PictureBox();
            this.lklblLigaI = new System.Windows.Forms.LinkLabel();
            this.lklblIFNMG = new System.Windows.Forms.LinkLabel();
            this.lklblInternews = new System.Windows.Forms.LinkLabel();
            this.lklblKumon = new System.Windows.Forms.LinkLabel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pcbMain);
            this.pnlMain.Controls.Add(this.lklblLigaI);
            this.pnlMain.Controls.Add(this.lklblIFNMG);
            this.pnlMain.Controls.Add(this.lklblInternews);
            this.pnlMain.Controls.Add(this.lklblKumon);
            this.pnlMain.Controls.Add(this.lblTexto);
            this.pnlMain.Location = new System.Drawing.Point(-1, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(489, 377);
            this.pnlMain.TabIndex = 1;
            // 
            // pcbMain
            // 
            this.pcbMain.ErrorImage = null;
            this.pcbMain.Image = ((System.Drawing.Image)(resources.GetObject("pcbMain.Image")));
            this.pcbMain.InitialImage = null;
            this.pcbMain.Location = new System.Drawing.Point(148, 13);
            this.pcbMain.Name = "pcbMain";
            this.pcbMain.Size = new System.Drawing.Size(193, 184);
            this.pcbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMain.TabIndex = 7;
            this.pcbMain.TabStop = false;
            // 
            // lklblLigaI
            // 
            this.lklblLigaI.ActiveLinkColor = System.Drawing.Color.Black;
            this.lklblLigaI.AutoSize = true;
            this.lklblLigaI.LinkColor = System.Drawing.Color.Black;
            this.lklblLigaI.Location = new System.Drawing.Point(122, 289);
            this.lklblLigaI.Name = "lklblLigaI";
            this.lklblLigaI.Size = new System.Drawing.Size(40, 13);
            this.lklblLigaI.TabIndex = 6;
            this.lklblLigaI.TabStop = true;
            this.lklblLigaI.Text = "\'Liga I\'.";
            this.toolTip1.SetToolTip(this.lklblLigaI, "Premiação para aqueles que alcançam matérias do \r\nEnsino Médio antes de completar" +
        " o 6º ano. ");
            // 
            // lklblIFNMG
            // 
            this.lklblIFNMG.AutoSize = true;
            this.lklblIFNMG.Location = new System.Drawing.Point(71, 341);
            this.lklblIFNMG.Name = "lklblIFNMG";
            this.lklblIFNMG.Size = new System.Drawing.Size(41, 13);
            this.lklblIFNMG.TabIndex = 5;
            this.lklblIFNMG.TabStop = true;
            this.lklblIFNMG.Text = "IFNMG";
            this.lklblIFNMG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblIFNMG_LinkClicked);
            // 
            // lklblInternews
            // 
            this.lklblInternews.AutoSize = true;
            this.lklblInternews.Location = new System.Drawing.Point(186, 328);
            this.lklblInternews.Name = "lklblInternews";
            this.lklblInternews.Size = new System.Drawing.Size(53, 13);
            this.lklblInternews.TabIndex = 4;
            this.lklblInternews.TabStop = true;
            this.lklblInternews.Text = "Internews";
            this.lklblInternews.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklblInternews_LinkClicked);
            // 
            // lklblKumon
            // 
            this.lklblKumon.AutoSize = true;
            this.lklblKumon.BackColor = System.Drawing.Color.Transparent;
            this.lklblKumon.Location = new System.Drawing.Point(27, 276);
            this.lklblKumon.Name = "lklblKumon";
            this.lklblKumon.Size = new System.Drawing.Size(40, 13);
            this.lklblKumon.TabIndex = 3;
            this.lklblKumon.TabStop = true;
            this.lklblKumon.Text = "Kumon";
            this.lklblKumon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Liga I";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 376);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.Name = "About";
            this.Text = "Sobre";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.LinkLabel lklblKumon;
        private System.Windows.Forms.LinkLabel lklblInternews;
        private System.Windows.Forms.LinkLabel lklblIFNMG;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel lklblLigaI;
        private System.Windows.Forms.PictureBox pcbMain;
    }
}