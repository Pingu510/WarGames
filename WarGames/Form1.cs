using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace WarGames
{
    public partial class Form1 : Form
    {        
        CountryHandler countryHandler = new CountryHandler();
        HelperClass h = new HelperClass();

        List<Label> CountryLabelEnduranceList = new List<Label>();

        private string _ambDirpath;
        private string _winnerDirpath;
        private string _missileDirpath;
        
        public Form1()
        {
            // Subscribers to events
            countryHandler.DeadCountry += CountryUpdateLabel;
            countryHandler.CountryNuked += DrawCurves;
            
            InitializeComponent();            
        }
        
        /// <summary>
        /// Background sound
        /// </summary>
        public void AmbientSound()
        {
            _ambDirpath = Directory.GetCurrentDirectory().ToString();
            AmbientWarMediaPlayer.URL = _ambDirpath + "\\War.wav";
            AmbientWarMediaPlayer.settings.volume = 60;
            AmbientWarMediaPlayer.Ctlcontrols.play();            
        }

        /// <summary>
        /// Attackmissile sound
        /// </summary>
        void MissileSound()
        {
            _missileDirpath = Directory.GetCurrentDirectory().ToString();
            MissileMediaPlayer.URL = _missileDirpath + "\\Missle_Launch.wav";
            MissileMediaPlayer.Ctlcontrols.play();            
        }

        /// <summary>
        /// Winning sound
        /// </summary>
        public void WinnerSound()
        {
            _winnerDirpath = Directory.GetCurrentDirectory().ToString();
            WinnerMediaPlayer.URL = _winnerDirpath + "\\FFIXFanfare.wav";
            WinnerMediaPlayer.Ctlcontrols.play();
            
        }

        /// <summary>
        /// Adds the countrylabels to countryendurancelist
        /// </summary>
        private void AddLabelsToList()
        {
            CountryLabelEnduranceList.Add(lblChinaEndurance);
            CountryLabelEnduranceList.Add(lblFranceEndurance);
            CountryLabelEnduranceList.Add(lblIndiaEndurance);
            CountryLabelEnduranceList.Add(lblIsraelEndurance);
            CountryLabelEnduranceList.Add(lblNorthKoreaEndurance);
            CountryLabelEnduranceList.Add(lblPakistanEndurance);
            CountryLabelEnduranceList.Add(lblRussiaEndurance);
            CountryLabelEnduranceList.Add(lblSouthAfricaEndurance);
            CountryLabelEnduranceList.Add(lblUnitedKingdomEndurance);
            CountryLabelEnduranceList.Add(lblUnitedStatesEndurance);
        }

        /// <summary>
        /// Sets startup values on countrylabels to startup endurance 
        /// </summary>
        private void SetLabelsStartUpText()
        {
            foreach (var i in CountryLabelEnduranceList)
            {
                i.Text = countryHandler.CurrentEndurance.ToString();
            }
        }

        /// <summary>
        /// Method starts the game
        /// </summary>
        private void tbxStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y || e.KeyCode == Keys.N)
            {
                if (e.KeyCode == Keys.Y)
                {
                    tbxStart.Visible = false;
                    picY.Visible = true;
                    new ManualResetEvent(false).WaitOne(1500);

                    AddLabelsToList();
                    panel1.Controls.Add(picBoxFront);
                    picBoxFront.Visible = false;
                    panel1.Controls.Add(picY);
                    picY.Visible = false;
                    countryHandler.StartNewGame();
                    AmbientSound();
                    tbxStart.Text = null;
                    AttackTimer.Enabled = true;

                }
                else if (e.KeyCode == Keys.N)
                {
                    panel1.Controls.Add(picN);
                    picN.Visible = true;
                    tbxStart.Visible = false;
                    new ManualResetEvent(false).WaitOne(1500);
                    Application.Exit();
                }
            }
            else if (e.KeyCode == Keys.Back)
            {
                tbxStart.Clear();
                return;
            }
            else
            {
                MessageBox.Show("Only Y or N! Press backspace to retry");
                return;
            }
        }

        /// <summary>
        /// Obsolete, gets mouse coordinates in panel1.
        /// </summary>
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            lblXNY.Text = e.Location.X + ":" + e.Location.Y;
        }
        
        /// <summary>
        /// Updates the countryendurancelabels and what happens upon endurance changes
        /// </summary>
        public void CountryUpdateLabel(object source, IntEventArgs e)
        {
            AttackerText(); // Displays who the current attacker is

            if (countryHandler.CountryList[e.CountryID].CountryEndurance != 0)
            {
                for (int i = 0; i < countryHandler.CountryList.Count; i++)
                {
                    CountryLabelEnduranceList[i].Text = countryHandler.CountryList[i].CountryEndurance.ToString();
                    MissileSound();
                    HitAnimation(e.CountryID);
                }
            }
            else
            {
                CountryLabelEnduranceList[e.CountryID].Text = "Lost";
                
                CountryLabelEnduranceList.RemoveAt(e.CountryID);
                
                ShowCountryDeath(e.CountryID);
                
                countryHandler.DeleteCountry(e.CountryID);

                // If theres only one country left in the list, game over
                if (countryHandler.CountryList.Count == 1)
                {                    
                    EndOfGame();
                }
            }
        }
        

        /// <summary>
        /// Prints who attacks who to a label
        /// </summary>
        private void AttackerText()
        {
            string WarStatus = (countryHandler.CountryList[countryHandler.CurrentAttkCountry].CountryName
                + " Attacks " + countryHandler.CountryList[countryHandler.CurrentDeffCountry].CountryName);
            Debug.WriteLine(countryHandler.CountryList[countryHandler.CurrentAttkCountry].CountryName
                + " Attacks " + countryHandler.CountryList[countryHandler.CurrentDeffCountry].CountryName);

            lblOngoingWarStatus.Text = (WarStatus);
            lblOngoingWarStatus.Left = (this.ClientSize.Width - lblOngoingWarStatus.Width) / 2;
        }

        /// <summary>
        /// Displays when country dies
        /// </summary>
        public void ShowCountryDeath(int i)
        {
            Point nukedPoint;
            nukedPoint = new Point(countryHandler.CountryList[i].CordinateX - 30, countryHandler.CountryList[i].CordinateY -80);
            
            PictureBox picboxDeath = new PictureBox();
            picboxDeath.Location = nukedPoint;
            picboxDeath.Width = 40; picboxDeath.Height = 50;

            picboxDeath.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxDeath.BringToFront();

            picboxDeath.Image = Properties.Resources.Skull_smaller;
            panel1.Controls.Add(picboxDeath);            
        }

        /// <summary>
        /// Animation to show when a country has been hit
        /// </summary>
        public void HitAnimation(int i)
        {
            Point HitPoint;
            HitPoint = new Point(countryHandler.CountryList[i].CordinateX - 25, countryHandler.CountryList[i].CordinateY - 25);

            PictureBox picboxHit = new PictureBox();
            picboxHit.Location = HitPoint;
            picboxHit.Width = 30; picboxHit.Height = 30;
            
            picboxHit.SizeMode = PictureBoxSizeMode.StretchImage;

            if (countryHandler.CountryList[i].CountryEndurance > 1)
            {
                picboxHit.Image = Properties.Resources.explosion;
                panel1.Controls.Add(picboxHit);
            }
            else if (countryHandler.CountryList[i].CountryEndurance == 0)
            {
                panel1.Controls.Remove(picboxHit);
            }
        }


        /// <summary>
        /// Gets coordinates and drawes curves between them
        /// </summary>
        public void DrawCurves(object source, EventArgs e)
        {
            var Attkcountry = countryHandler.CountryList[countryHandler.CurrentAttkCountry];
            var Deffcountry = countryHandler.CountryList[countryHandler.CurrentDeffCountry];
            
            //get coords from countryhandler
            Point attackingCountryCoordinates = new Point(Attkcountry.CordinateX, Attkcountry.CordinateY);
            Point defendingCountryCoordinates = new Point(Deffcountry.CordinateX, Deffcountry.CordinateY);

            // Gets the curvepoint from helperclass.
            Point curvepoint = h.DrawCurve(attackingCountryCoordinates, defendingCountryCoordinates);
            
            // Create points that defines the curve.
            Point[] curvePoints = { attackingCountryCoordinates, curvepoint, defendingCountryCoordinates };

            // Creates a dashed pen tool
            float[] dashValues = { 4, 1 };
            Pen dashPen = new Pen(Color.Red, 3);
            dashPen.DashPattern = dashValues;
            Graphics g = panel1.CreateGraphics();

            // Draw dashed curve.
            g.DrawCurve(dashPen, curvePoints); 
        }

        /// <summary>
        /// Timer that controlls the interval and sends the attacks
        /// </summary>
        private void AtackTimer_Tick(object sender, EventArgs e)
        {
            countryHandler.StartWar();
        }

        /// <summary>
        /// Display end image
        /// </summary>
        public void ShowEndWarTextImage()
        {
            Image warImage = Properties.Resources.warImage;
            Graphics g = panel1.CreateGraphics();
            g.DrawImage(warImage, 545, 230);
        }

        /// <summary>
        /// Text that announces winner
        /// </summary>
        public void WinnerAnnouncement()
        {
            lblWinner.Text = ($"{countryHandler.CountryList[0].CountryName} Won the war!!");
            lblWinner.Left = (panel1.ClientSize.Width - lblWinner.Width) / 2;

            AmbientWarMediaPlayer.Ctlcontrols.stop();

        }

        /// <summary>
        /// Manages what happens when the game is done
        /// </summary>
        private void EndOfGame() 
        {
            AttackTimer.Stop();
            ShowEndWarTextImage();
            WinnerAnnouncement();
            WinnerSound();
            //new ManualResetEvent(false).WaitOne(5000);
            //Application.Exit();
        }
    }
}