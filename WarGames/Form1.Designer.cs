﻿namespace WarGames
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AttackTimer = new System.Windows.Forms.Timer(this.components);
            this.tbxStart = new System.Windows.Forms.TextBox();
            this.picY = new System.Windows.Forms.PictureBox();
            this.picBoxFront = new System.Windows.Forms.PictureBox();
            this.picN = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxHit = new System.Windows.Forms.PictureBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.grpBoxStats = new System.Windows.Forms.GroupBox();
            this.lblUnitedStatesEndurance = new System.Windows.Forms.Label();
            this.lblUnitedKingdomEndurance = new System.Windows.Forms.Label();
            this.lblSwedenEndurance = new System.Windows.Forms.Label();
            this.lblRussiaEndurance = new System.Windows.Forms.Label();
            this.lblPakistanEndurance = new System.Windows.Forms.Label();
            this.lblNorthKoreaEndurance = new System.Windows.Forms.Label();
            this.lblIsraelEndurance = new System.Windows.Forms.Label();
            this.lblIndiaEndurance = new System.Windows.Forms.Label();
            this.lblFranceEndurance = new System.Windows.Forms.Label();
            this.lblChinaEndurance = new System.Windows.Forms.Label();
            this.lblUnitedStates = new System.Windows.Forms.Label();
            this.lblUnitedKingdom = new System.Windows.Forms.Label();
            this.lblSweden = new System.Windows.Forms.Label();
            this.lblRussia = new System.Windows.Forms.Label();
            this.lblPakistan = new System.Windows.Forms.Label();
            this.lblNorthKorea = new System.Windows.Forms.Label();
            this.lblIsrael = new System.Windows.Forms.Label();
            this.lblIndia = new System.Windows.Forms.Label();
            this.lblFrance = new System.Windows.Forms.Label();
            this.lblChina = new System.Windows.Forms.Label();
            this.lblXNY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picN)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.grpBoxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // AttackTimer
            // 
            this.AttackTimer.Interval = 800;
            this.AttackTimer.Tick += new System.EventHandler(this.AtackTimer_Tick);
            // 
            // tbxStart
            // 
            this.tbxStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(28)))));
            this.tbxStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStart.ForeColor = System.Drawing.Color.Transparent;
            this.tbxStart.Location = new System.Drawing.Point(781, 290);
            this.tbxStart.Name = "tbxStart";
            this.tbxStart.Size = new System.Drawing.Size(32, 22);
            this.tbxStart.TabIndex = 4;
            this.tbxStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxStart_KeyDown);
            // 
            // picY
            // 
            this.picY.BackColor = System.Drawing.Color.Transparent;
            this.picY.ErrorImage = null;
            this.picY.Image = global::WarGames.Properties.Resources.Y;
            this.picY.InitialImage = null;
            this.picY.Location = new System.Drawing.Point(781, 274);
            this.picY.Name = "picY";
            this.picY.Size = new System.Drawing.Size(32, 36);
            this.picY.TabIndex = 5;
            this.picY.TabStop = false;
            this.picY.Visible = false;
            // 
            // picBoxFront
            // 
            this.picBoxFront.BackColor = System.Drawing.Color.Transparent;
            this.picBoxFront.Image = global::WarGames.Properties.Resources.gameText;
            this.picBoxFront.Location = new System.Drawing.Point(308, 259);
            this.picBoxFront.Name = "picBoxFront";
            this.picBoxFront.Size = new System.Drawing.Size(458, 61);
            this.picBoxFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxFront.TabIndex = 2;
            this.picBoxFront.TabStop = false;
            // 
            // picN
            // 
            this.picN.BackColor = System.Drawing.Color.Transparent;
            this.picN.Image = global::WarGames.Properties.Resources.N;
            this.picN.Location = new System.Drawing.Point(781, 274);
            this.picN.Name = "picN";
            this.picN.Size = new System.Drawing.Size(32, 36);
            this.picN.TabIndex = 6;
            this.picN.TabStop = false;
            this.picN.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WarGames.Properties.Resources.MapNight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picboxHit);
            this.panel1.Controls.Add(this.picBoxFront);
            this.panel1.Controls.Add(this.lblWinner);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Controls.Add(this.picY);
            this.panel1.Controls.Add(this.grpBoxStats);
            this.panel1.Controls.Add(this.lblXNY);
            this.panel1.Controls.Add(this.tbxStart);
            this.panel1.Controls.Add(this.picN);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 576);
            this.panel1.TabIndex = 7;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // picboxHit
            // 
            this.picboxHit.Image = global::WarGames.Properties.Resources.explosion;
            this.picboxHit.Location = new System.Drawing.Point(525, 399);
            this.picboxHit.Name = "picboxHit";
            this.picboxHit.Size = new System.Drawing.Size(76, 67);
            this.picboxHit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxHit.TabIndex = 12;
            this.picboxHit.TabStop = false;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Stencil", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.White;
            this.lblWinner.Location = new System.Drawing.Point(300, 337);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(0, 64);
            this.lblWinner.TabIndex = 11;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(909, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(179, 115);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // grpBoxStats
            // 
            this.grpBoxStats.Controls.Add(this.lblUnitedStatesEndurance);
            this.grpBoxStats.Controls.Add(this.lblUnitedKingdomEndurance);
            this.grpBoxStats.Controls.Add(this.lblSwedenEndurance);
            this.grpBoxStats.Controls.Add(this.lblRussiaEndurance);
            this.grpBoxStats.Controls.Add(this.lblPakistanEndurance);
            this.grpBoxStats.Controls.Add(this.lblNorthKoreaEndurance);
            this.grpBoxStats.Controls.Add(this.lblIsraelEndurance);
            this.grpBoxStats.Controls.Add(this.lblIndiaEndurance);
            this.grpBoxStats.Controls.Add(this.lblFranceEndurance);
            this.grpBoxStats.Controls.Add(this.lblChinaEndurance);
            this.grpBoxStats.Controls.Add(this.lblUnitedStates);
            this.grpBoxStats.Controls.Add(this.lblUnitedKingdom);
            this.grpBoxStats.Controls.Add(this.lblSweden);
            this.grpBoxStats.Controls.Add(this.lblRussia);
            this.grpBoxStats.Controls.Add(this.lblPakistan);
            this.grpBoxStats.Controls.Add(this.lblNorthKorea);
            this.grpBoxStats.Controls.Add(this.lblIsrael);
            this.grpBoxStats.Controls.Add(this.lblIndia);
            this.grpBoxStats.Controls.Add(this.lblFrance);
            this.grpBoxStats.Controls.Add(this.lblChina);
            this.grpBoxStats.ForeColor = System.Drawing.Color.White;
            this.grpBoxStats.Location = new System.Drawing.Point(13, 259);
            this.grpBoxStats.Name = "grpBoxStats";
            this.grpBoxStats.Size = new System.Drawing.Size(200, 315);
            this.grpBoxStats.TabIndex = 10;
            this.grpBoxStats.TabStop = false;
            this.grpBoxStats.Text = "Stats";
            // 
            // lblUnitedStatesEndurance
            // 
            this.lblUnitedStatesEndurance.AutoSize = true;
            this.lblUnitedStatesEndurance.Location = new System.Drawing.Point(161, 280);
            this.lblUnitedStatesEndurance.Name = "lblUnitedStatesEndurance";
            this.lblUnitedStatesEndurance.Size = new System.Drawing.Size(18, 20);
            this.lblUnitedStatesEndurance.TabIndex = 19;
            this.lblUnitedStatesEndurance.Text = "0";
            // 
            // lblUnitedKingdomEndurance
            // 
            this.lblUnitedKingdomEndurance.AutoSize = true;
            this.lblUnitedKingdomEndurance.Location = new System.Drawing.Point(161, 252);
            this.lblUnitedKingdomEndurance.Name = "lblUnitedKingdomEndurance";
            this.lblUnitedKingdomEndurance.Size = new System.Drawing.Size(18, 20);
            this.lblUnitedKingdomEndurance.TabIndex = 18;
            this.lblUnitedKingdomEndurance.Text = "0";
            // 
            // lblSwedenEndurance
            // 
            this.lblSwedenEndurance.AutoSize = true;
            this.lblSwedenEndurance.Location = new System.Drawing.Point(161, 224);
            this.lblSwedenEndurance.Name = "lblSwedenEndurance";
            this.lblSwedenEndurance.Size = new System.Drawing.Size(18, 20);
            this.lblSwedenEndurance.TabIndex = 17;
            this.lblSwedenEndurance.Text = "0";
            // 
            // lblRussiaEndurance
            // 
            this.lblRussiaEndurance.AutoSize = true;
            this.lblRussiaEndurance.Location = new System.Drawing.Point(161, 196);
            this.lblRussiaEndurance.Name = "lblRussiaEndurance";
            this.lblRussiaEndurance.Size = new System.Drawing.Size(18, 20);
            this.lblRussiaEndurance.TabIndex = 16;
            this.lblRussiaEndurance.Text = "0";
            // 
            // lblPakistanEndurance
            // 
            this.lblPakistanEndurance.AutoSize = true;
            this.lblPakistanEndurance.Location = new System.Drawing.Point(161, 168);
            this.lblPakistanEndurance.Name = "lblPakistanEndurance";
            this.lblPakistanEndurance.Size = new System.Drawing.Size(18, 20);
            this.lblPakistanEndurance.TabIndex = 15;
            this.lblPakistanEndurance.Text = "0";
            // 
            // lblNorthKoreaEndurance
            // 
            this.lblNorthKoreaEndurance.AutoSize = true;
            this.lblNorthKoreaEndurance.Location = new System.Drawing.Point(161, 140);
            this.lblNorthKoreaEndurance.Name = "lblNorthKoreaEndurance";
            this.lblNorthKoreaEndurance.Size = new System.Drawing.Size(18, 20);
            this.lblNorthKoreaEndurance.TabIndex = 14;
            this.lblNorthKoreaEndurance.Text = "0";
            // 
            // lblIsraelEndurance
            // 
            this.lblIsraelEndurance.AutoSize = true;
            this.lblIsraelEndurance.Location = new System.Drawing.Point(161, 112);
            this.lblIsraelEndurance.Name = "lblIsraelEndurance";
            this.lblIsraelEndurance.Size = new System.Drawing.Size(18, 20);
            this.lblIsraelEndurance.TabIndex = 13;
            this.lblIsraelEndurance.Text = "0";
            // 
            // lblIndiaEndurance
            // 
            this.lblIndiaEndurance.AutoSize = true;
            this.lblIndiaEndurance.Location = new System.Drawing.Point(161, 84);
            this.lblIndiaEndurance.Name = "lblIndiaEndurance";
            this.lblIndiaEndurance.Size = new System.Drawing.Size(18, 20);
            this.lblIndiaEndurance.TabIndex = 12;
            this.lblIndiaEndurance.Text = "0";
            // 
            // lblFranceEndurance
            // 
            this.lblFranceEndurance.AutoSize = true;
            this.lblFranceEndurance.Location = new System.Drawing.Point(161, 56);
            this.lblFranceEndurance.Name = "lblFranceEndurance";
            this.lblFranceEndurance.Size = new System.Drawing.Size(18, 20);
            this.lblFranceEndurance.TabIndex = 11;
            this.lblFranceEndurance.Text = "0";
            // 
            // lblChinaEndurance
            // 
            this.lblChinaEndurance.AutoSize = true;
            this.lblChinaEndurance.Location = new System.Drawing.Point(161, 31);
            this.lblChinaEndurance.Name = "lblChinaEndurance";
            this.lblChinaEndurance.Size = new System.Drawing.Size(18, 20);
            this.lblChinaEndurance.TabIndex = 10;
            this.lblChinaEndurance.Text = "0";
            // 
            // lblUnitedStates
            // 
            this.lblUnitedStates.AutoSize = true;
            this.lblUnitedStates.Location = new System.Drawing.Point(7, 280);
            this.lblUnitedStates.Name = "lblUnitedStates";
            this.lblUnitedStates.Size = new System.Drawing.Size(111, 20);
            this.lblUnitedStates.TabIndex = 9;
            this.lblUnitedStates.Text = "UnitedStates :";
            // 
            // lblUnitedKingdom
            // 
            this.lblUnitedKingdom.AutoSize = true;
            this.lblUnitedKingdom.Location = new System.Drawing.Point(7, 252);
            this.lblUnitedKingdom.Name = "lblUnitedKingdom";
            this.lblUnitedKingdom.Size = new System.Drawing.Size(126, 20);
            this.lblUnitedKingdom.TabIndex = 8;
            this.lblUnitedKingdom.Text = "UnitedKingdom :";
            // 
            // lblSweden
            // 
            this.lblSweden.AutoSize = true;
            this.lblSweden.Location = new System.Drawing.Point(7, 224);
            this.lblSweden.Name = "lblSweden";
            this.lblSweden.Size = new System.Drawing.Size(75, 20);
            this.lblSweden.TabIndex = 7;
            this.lblSweden.Text = "Sweden :";
            // 
            // lblRussia
            // 
            this.lblRussia.AutoSize = true;
            this.lblRussia.Location = new System.Drawing.Point(7, 196);
            this.lblRussia.Name = "lblRussia";
            this.lblRussia.Size = new System.Drawing.Size(66, 20);
            this.lblRussia.TabIndex = 6;
            this.lblRussia.Text = "Russia :";
            // 
            // lblPakistan
            // 
            this.lblPakistan.AutoSize = true;
            this.lblPakistan.Location = new System.Drawing.Point(7, 168);
            this.lblPakistan.Name = "lblPakistan";
            this.lblPakistan.Size = new System.Drawing.Size(78, 20);
            this.lblPakistan.TabIndex = 5;
            this.lblPakistan.Text = "Pakistan :";
            // 
            // lblNorthKorea
            // 
            this.lblNorthKorea.AutoSize = true;
            this.lblNorthKorea.Location = new System.Drawing.Point(7, 140);
            this.lblNorthKorea.Name = "lblNorthKorea";
            this.lblNorthKorea.Size = new System.Drawing.Size(98, 20);
            this.lblNorthKorea.TabIndex = 4;
            this.lblNorthKorea.Text = "NorthKorea :";
            // 
            // lblIsrael
            // 
            this.lblIsrael.AutoSize = true;
            this.lblIsrael.Location = new System.Drawing.Point(7, 112);
            this.lblIsrael.Name = "lblIsrael";
            this.lblIsrael.Size = new System.Drawing.Size(56, 20);
            this.lblIsrael.TabIndex = 3;
            this.lblIsrael.Text = "Israel :";
            // 
            // lblIndia
            // 
            this.lblIndia.AutoSize = true;
            this.lblIndia.Location = new System.Drawing.Point(7, 84);
            this.lblIndia.Name = "lblIndia";
            this.lblIndia.Size = new System.Drawing.Size(52, 20);
            this.lblIndia.TabIndex = 2;
            this.lblIndia.Text = "India :";
            // 
            // lblFrance
            // 
            this.lblFrance.AutoSize = true;
            this.lblFrance.Location = new System.Drawing.Point(7, 56);
            this.lblFrance.Name = "lblFrance";
            this.lblFrance.Size = new System.Drawing.Size(67, 20);
            this.lblFrance.TabIndex = 1;
            this.lblFrance.Text = "France :";
            // 
            // lblChina
            // 
            this.lblChina.AutoSize = true;
            this.lblChina.Location = new System.Drawing.Point(7, 28);
            this.lblChina.Name = "lblChina";
            this.lblChina.Size = new System.Drawing.Size(58, 20);
            this.lblChina.TabIndex = 0;
            this.lblChina.Text = "China :";
            // 
            // lblXNY
            // 
            this.lblXNY.AutoSize = true;
            this.lblXNY.BackColor = System.Drawing.Color.White;
            this.lblXNY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXNY.Location = new System.Drawing.Point(436, 33);
            this.lblXNY.Name = "lblXNY";
            this.lblXNY.Size = new System.Drawing.Size(70, 31);
            this.lblXNY.TabIndex = 9;
            this.lblXNY.Text = "///////";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::WarGames.Properties.Resources.MapNight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 576);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.picY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.grpBoxStats.ResumeLayout(false);
            this.grpBoxStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxFront;
        private System.Windows.Forms.Timer AttackTimer;
        private System.Windows.Forms.TextBox tbxStart;
        private System.Windows.Forms.PictureBox picY;
        private System.Windows.Forms.PictureBox picN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblXNY;
        private System.Windows.Forms.GroupBox grpBoxStats;
        private System.Windows.Forms.Label lblUnitedStates;
        private System.Windows.Forms.Label lblUnitedKingdom;
        private System.Windows.Forms.Label lblSweden;
        private System.Windows.Forms.Label lblRussia;
        private System.Windows.Forms.Label lblPakistan;
        private System.Windows.Forms.Label lblNorthKorea;
        private System.Windows.Forms.Label lblIsrael;
        private System.Windows.Forms.Label lblIndia;
        private System.Windows.Forms.Label lblFrance;
        private System.Windows.Forms.Label lblChina;
        private System.Windows.Forms.Label lblUnitedStatesEndurance;
        private System.Windows.Forms.Label lblUnitedKingdomEndurance;
        private System.Windows.Forms.Label lblSwedenEndurance;
        private System.Windows.Forms.Label lblRussiaEndurance;
        private System.Windows.Forms.Label lblPakistanEndurance;
        private System.Windows.Forms.Label lblNorthKoreaEndurance;
        private System.Windows.Forms.Label lblIsraelEndurance;
        private System.Windows.Forms.Label lblIndiaEndurance;
        private System.Windows.Forms.Label lblFranceEndurance;
        private System.Windows.Forms.Label lblChinaEndurance;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox picboxHit;
    }
}

