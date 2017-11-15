namespace WarGames
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
            this.hitTime = new System.Windows.Forms.Timer(this.components);
            this.tbxStart = new System.Windows.Forms.TextBox();
            this.picY = new System.Windows.Forms.PictureBox();
            this.picBoxFront = new System.Windows.Forms.PictureBox();
            this.picN = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpBoxStats = new System.Windows.Forms.GroupBox();
            this.lblUnitedStatesScore = new System.Windows.Forms.Label();
            this.lblUnitedKingdomScore = new System.Windows.Forms.Label();
            this.lblSwedenScore = new System.Windows.Forms.Label();
            this.lblRussiaScore = new System.Windows.Forms.Label();
            this.lblPakistanScore = new System.Windows.Forms.Label();
            this.lblNorthKoreaScore = new System.Windows.Forms.Label();
            this.lblIsraelScore = new System.Windows.Forms.Label();
            this.lblIndiaScore = new System.Windows.Forms.Label();
            this.lblFranceScore = new System.Windows.Forms.Label();
            this.lblChinaScore = new System.Windows.Forms.Label();
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
            this.grpBoxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxStart
            // 
            this.tbxStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(28)))));
            this.tbxStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStart.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbxStart.Location = new System.Drawing.Point(697, 287);
            this.tbxStart.Name = "tbxStart";
            this.tbxStart.Size = new System.Drawing.Size(14, 22);
            this.tbxStart.TabIndex = 4;
            this.tbxStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxStart_KeyDown);
            this.tbxStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxStart_KeyPress);
            // 
            // picY
            // 
            this.picY.BackColor = System.Drawing.Color.Transparent;
            this.picY.ErrorImage = null;
            this.picY.Image = global::WarGames.Properties.Resources.Y;
            this.picY.InitialImage = null;
            this.picY.Location = new System.Drawing.Point(697, 274);
            this.picY.Name = "picY";
            this.picY.Size = new System.Drawing.Size(22, 36);
            this.picY.TabIndex = 5;
            this.picY.TabStop = false;
            this.picY.Visible = false;
            // 
            // picBoxFront
            // 
            this.picBoxFront.BackColor = System.Drawing.Color.Transparent;
            this.picBoxFront.Image = global::WarGames.Properties.Resources.gameText;
            this.picBoxFront.Location = new System.Drawing.Point(236, 259);
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
            this.picN.Location = new System.Drawing.Point(699, 273);
            this.picN.Name = "picN";
            this.picN.Size = new System.Drawing.Size(21, 36);
            this.picN.TabIndex = 6;
            this.picN.TabStop = false;
            this.picN.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WarGames.Properties.Resources.MapNight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picY);
            this.panel1.Controls.Add(this.grpBoxStats);
            this.panel1.Controls.Add(this.lblXNY);
            this.panel1.Controls.Add(this.tbxStart);
            this.panel1.Controls.Add(this.picN);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 577);
            this.panel1.TabIndex = 7;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // grpBoxStats
            // 
            this.grpBoxStats.Controls.Add(this.lblUnitedStatesScore);
            this.grpBoxStats.Controls.Add(this.lblUnitedKingdomScore);
            this.grpBoxStats.Controls.Add(this.lblSwedenScore);
            this.grpBoxStats.Controls.Add(this.lblRussiaScore);
            this.grpBoxStats.Controls.Add(this.lblPakistanScore);
            this.grpBoxStats.Controls.Add(this.lblNorthKoreaScore);
            this.grpBoxStats.Controls.Add(this.lblIsraelScore);
            this.grpBoxStats.Controls.Add(this.lblIndiaScore);
            this.grpBoxStats.Controls.Add(this.lblFranceScore);
            this.grpBoxStats.Controls.Add(this.lblChinaScore);
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
            // lblUnitedStatesScore
            // 
            this.lblUnitedStatesScore.AutoSize = true;
            this.lblUnitedStatesScore.Location = new System.Drawing.Point(161, 280);
            this.lblUnitedStatesScore.Name = "lblUnitedStatesScore";
            this.lblUnitedStatesScore.Size = new System.Drawing.Size(18, 20);
            this.lblUnitedStatesScore.TabIndex = 19;
            this.lblUnitedStatesScore.Text = "0";
            // 
            // lblUnitedKingdomScore
            // 
            this.lblUnitedKingdomScore.AutoSize = true;
            this.lblUnitedKingdomScore.Location = new System.Drawing.Point(161, 252);
            this.lblUnitedKingdomScore.Name = "lblUnitedKingdomScore";
            this.lblUnitedKingdomScore.Size = new System.Drawing.Size(18, 20);
            this.lblUnitedKingdomScore.TabIndex = 18;
            this.lblUnitedKingdomScore.Text = "0";
            // 
            // lblSwedenScore
            // 
            this.lblSwedenScore.AutoSize = true;
            this.lblSwedenScore.Location = new System.Drawing.Point(161, 224);
            this.lblSwedenScore.Name = "lblSwedenScore";
            this.lblSwedenScore.Size = new System.Drawing.Size(18, 20);
            this.lblSwedenScore.TabIndex = 17;
            this.lblSwedenScore.Text = "0";
            // 
            // lblRussiaScore
            // 
            this.lblRussiaScore.AutoSize = true;
            this.lblRussiaScore.Location = new System.Drawing.Point(161, 196);
            this.lblRussiaScore.Name = "lblRussiaScore";
            this.lblRussiaScore.Size = new System.Drawing.Size(18, 20);
            this.lblRussiaScore.TabIndex = 16;
            this.lblRussiaScore.Text = "0";
            // 
            // lblPakistanScore
            // 
            this.lblPakistanScore.AutoSize = true;
            this.lblPakistanScore.Location = new System.Drawing.Point(161, 168);
            this.lblPakistanScore.Name = "lblPakistanScore";
            this.lblPakistanScore.Size = new System.Drawing.Size(18, 20);
            this.lblPakistanScore.TabIndex = 15;
            this.lblPakistanScore.Text = "0";
            // 
            // lblNorthKoreaScore
            // 
            this.lblNorthKoreaScore.AutoSize = true;
            this.lblNorthKoreaScore.Location = new System.Drawing.Point(161, 140);
            this.lblNorthKoreaScore.Name = "lblNorthKoreaScore";
            this.lblNorthKoreaScore.Size = new System.Drawing.Size(18, 20);
            this.lblNorthKoreaScore.TabIndex = 14;
            this.lblNorthKoreaScore.Text = "0";
            // 
            // lblIsraelScore
            // 
            this.lblIsraelScore.AutoSize = true;
            this.lblIsraelScore.Location = new System.Drawing.Point(161, 112);
            this.lblIsraelScore.Name = "lblIsraelScore";
            this.lblIsraelScore.Size = new System.Drawing.Size(18, 20);
            this.lblIsraelScore.TabIndex = 13;
            this.lblIsraelScore.Text = "0";
            // 
            // lblIndiaScore
            // 
            this.lblIndiaScore.AutoSize = true;
            this.lblIndiaScore.Location = new System.Drawing.Point(161, 84);
            this.lblIndiaScore.Name = "lblIndiaScore";
            this.lblIndiaScore.Size = new System.Drawing.Size(18, 20);
            this.lblIndiaScore.TabIndex = 12;
            this.lblIndiaScore.Text = "0";
            // 
            // lblFranceScore
            // 
            this.lblFranceScore.AutoSize = true;
            this.lblFranceScore.Location = new System.Drawing.Point(161, 56);
            this.lblFranceScore.Name = "lblFranceScore";
            this.lblFranceScore.Size = new System.Drawing.Size(18, 20);
            this.lblFranceScore.TabIndex = 11;
            this.lblFranceScore.Text = "0";
            // 
            // lblChinaScore
            // 
            this.lblChinaScore.AutoSize = true;
            this.lblChinaScore.Location = new System.Drawing.Point(161, 31);
            this.lblChinaScore.Name = "lblChinaScore";
            this.lblChinaScore.Size = new System.Drawing.Size(18, 20);
            this.lblChinaScore.TabIndex = 10;
            this.lblChinaScore.Text = "0";
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
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1130, 576);
            this.Controls.Add(this.picBoxFront);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.picY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBoxStats.ResumeLayout(false);
            this.grpBoxStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxFront;
        private System.Windows.Forms.Timer hitTime;
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
        private System.Windows.Forms.Label lblUnitedStatesScore;
        private System.Windows.Forms.Label lblUnitedKingdomScore;
        private System.Windows.Forms.Label lblSwedenScore;
        private System.Windows.Forms.Label lblRussiaScore;
        private System.Windows.Forms.Label lblPakistanScore;
        private System.Windows.Forms.Label lblNorthKoreaScore;
        private System.Windows.Forms.Label lblIsraelScore;
        private System.Windows.Forms.Label lblIndiaScore;
        private System.Windows.Forms.Label lblFranceScore;
        private System.Windows.Forms.Label lblChinaScore;
    }
}

