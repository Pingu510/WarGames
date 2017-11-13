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
            this.lblXNY = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picN)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.picY.Location = new System.Drawing.Point(697, 273);
            this.picY.Name = "picY";
            this.picY.Size = new System.Drawing.Size(23, 36);
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
            this.panel1.Controls.Add(this.lblXNY);
            this.panel1.Controls.Add(this.lblY);
            this.panel1.Controls.Add(this.lblX);
            this.panel1.Controls.Add(this.picY);
            this.panel1.Controls.Add(this.tbxStart);
            this.panel1.Controls.Add(this.picN);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 577);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
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
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(0, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(18, 20);
            this.lblY.TabIndex = 8;
            this.lblY.Text = "0";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(0, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 20);
            this.lblX.TabIndex = 7;
            this.lblX.Text = "0";
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxFront;
        private System.Windows.Forms.Timer hitTime;
        private System.Windows.Forms.TextBox tbxStart;
        private System.Windows.Forms.PictureBox picY;
        private System.Windows.Forms.PictureBox picN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblXNY;
    }
}

