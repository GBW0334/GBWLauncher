using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Drawing;
using System.Windows;

namespace GBWLauncher
{
    partial class MainPage
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
            this.roundedUserControl3 = new GBWLauncher.RoundedUserControl();
            this.roundedUserControl2 = new GBWLauncher.RoundedUserControl();
            this.justPanel1 = new GBWLauncher.JustPanelD();
            this.roundedUserControl1 = new GBWLauncher.RoundedUserControl();
            this.SuspendLayout();
            // 
            // roundedUserControl3
            // 
            this.roundedUserControl3.BackColor = System.Drawing.Color.Transparent;
            this.roundedUserControl3.BackgroundImage = global::GBWLauncher.Properties.Resources._1486147202_social_media_circled_network10_79475;
            this.roundedUserControl3.BorderColor = System.Drawing.Color.Transparent;
            this.roundedUserControl3.BorderSize = 0;
            this.roundedUserControl3.ControlText = "";
            this.roundedUserControl3.FillColor = System.Drawing.Color.Transparent;
            this.roundedUserControl3.FistImage = global::GBWLauncher.Properties.Resources._1486147202_social_media_circled_network10_79475;
            this.roundedUserControl3.ForeColor = System.Drawing.Color.Transparent;
            this.roundedUserControl3.Location = new System.Drawing.Point(606, 391);
            this.roundedUserControl3.Margin = new System.Windows.Forms.Padding(0);
            this.roundedUserControl3.Name = "roundedUserControl3";
            this.roundedUserControl3.Radius = 82;
            this.roundedUserControl3.SecondImage = global::GBWLauncher.Properties.Resources._1486147202_social_media_circled_network10_79475;
            this.roundedUserControl3.Size = new System.Drawing.Size(99, 99);
            this.roundedUserControl3.TabIndex = 5;
            this.roundedUserControl3.Click += new System.EventHandler(this.roundedUserControl3_Click);
            // 
            // roundedUserControl2
            // 
            this.roundedUserControl2.BackColor = System.Drawing.Color.Transparent;
            this.roundedUserControl2.BackgroundImage = global::GBWLauncher.Properties.Resources.iconfinder_discord_4661587_122459;
            this.roundedUserControl2.BorderColor = System.Drawing.Color.Transparent;
            this.roundedUserControl2.BorderSize = 0;
            this.roundedUserControl2.ControlText = "";
            this.roundedUserControl2.FillColor = System.Drawing.Color.Transparent;
            this.roundedUserControl2.FistImage = global::GBWLauncher.Properties.Resources.iconfinder_discord_4661587_122459;
            this.roundedUserControl2.ForeColor = System.Drawing.Color.Transparent;
            this.roundedUserControl2.Location = new System.Drawing.Point(723, 393);
            this.roundedUserControl2.Margin = new System.Windows.Forms.Padding(0);
            this.roundedUserControl2.Name = "roundedUserControl2";
            this.roundedUserControl2.Radius = 82;
            this.roundedUserControl2.SecondImage = global::GBWLauncher.Properties.Resources.iconfinder_discord_4661587_122459;
            this.roundedUserControl2.Size = new System.Drawing.Size(96, 96);
            this.roundedUserControl2.TabIndex = 4;
            this.roundedUserControl2.Click += new System.EventHandler(this.roundedUserControl2_Click);
            // 
            // justPanel1
            // 
            this.justPanel1.BackColor = System.Drawing.Color.Transparent;
            this.justPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.justPanel1.BorderSize = 4;
            this.justPanel1.ControlText = "";
            this.justPanel1.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.justPanel1.Location = new System.Drawing.Point(583, 25);
            this.justPanel1.Name = "justPanel1";
            this.justPanel1.Radius = 10;
            this.justPanel1.Size = new System.Drawing.Size(390, 323);
            this.justPanel1.TabIndex = 0;
            // 
            // roundedUserControl1
            // 
            this.roundedUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.roundedUserControl1.BackgroundImage = global::GBWLauncher.Properties.Resources.knock;
            this.roundedUserControl1.BorderColor = System.Drawing.Color.Transparent;
            this.roundedUserControl1.BorderSize = 0;
            this.roundedUserControl1.ControlText = "";
            this.roundedUserControl1.FillColor = System.Drawing.Color.Transparent;
            this.roundedUserControl1.FistImage = global::GBWLauncher.Properties.Resources.bonk;
            this.roundedUserControl1.ForeColor = System.Drawing.Color.Transparent;
            this.roundedUserControl1.Location = new System.Drawing.Point(854, 383);
            this.roundedUserControl1.Margin = new System.Windows.Forms.Padding(0);
            this.roundedUserControl1.Name = "roundedUserControl1";
            this.roundedUserControl1.Radius = 109;
            this.roundedUserControl1.SecondImage = global::GBWLauncher.Properties.Resources.knock;
            this.roundedUserControl1.Size = new System.Drawing.Size(110, 110);
            this.roundedUserControl1.TabIndex = 3;
            this.roundedUserControl1.Click += new System.EventHandler(this.roundedUserControl1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::GBWLauncher.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(999, 537);
            this.Controls.Add(this.roundedUserControl3);
            this.Controls.Add(this.roundedUserControl2);
            this.Controls.Add(this.justPanel1);
            this.Controls.Add(this.roundedUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GBWLauncher";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedUserControl roundedUserControl1;
        private JustPanelD justPanel1;
        private RoundedUserControl roundedUserControl2;
        private RoundedUserControl roundedUserControl3;
    }
}