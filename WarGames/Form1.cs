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
            countryHandler.CountryNuked += Repaint;
            
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
            CountryLabelEnduranceList.Add(lblSwedenEndurance);
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
                    AttackTimer.Enabled = true;
                    panel1.Controls.Add(picBoxFront);
                    picBoxFront.Visible = false;
                    panel1.Controls.Add(picY);
                    picY.Visible = false;
                    countryHandler.StartNewGame();
                    AmbientSound();
                    tbxStart.Text = null;

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
            lblXNY.Visible = false;
            lblXNY.Text = e.Location.X + ":" + e.Location.Y;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void CountryUpdateLabel(object source, IntEventArgs e)
        {
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
                
                ShowDeath(e.CountryID);
                
                countryHandler.DeleteCountry(e.CountryID);

                if (countryHandler.CountryList.Count == 1)
                {
                    AttackTimer.Stop();
                    ShowEndWarText();
                    Winner();
                    EndOfGame();
                }
            }
        }

        public void ShowEndWarText()
        {
            Image warImage = Properties.Resources.warImage;
            Graphics g = panel1.CreateGraphics();
            g.DrawImage(warImage, 545, 230);
        }
        

        public void ShowDeath(int i)
        {
            Point nukedPoint;
            nukedPoint = new Point(countryHandler.CountryList[i].CordinateX - 45, countryHandler.CountryList[i].CordinateY -100);
            
            PictureBox picboxDeath = new PictureBox();
            picboxDeath.Location = nukedPoint;
            picboxDeath.Width = 50; picboxDeath.Height = 80;

            picboxDeath.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxDeath.BringToFront();

            picboxDeath.Image = Properties.Resources.Skull_smaller;
            panel1.Controls.Add(picboxDeath);

            //Image deathimage = Properties.Resources.Skull_smaller;
            
            //Graphics g = panel1.CreateGraphics();
            //g.DrawImage(deathimage, nukedPoint);
        }

        public void HitAnimation(int i)
        {
            Point HitPoint;
            HitPoint = new Point(countryHandler.CountryList[i].CordinateX - 45, countryHandler.CountryList[i].CordinateY - 25);

            PictureBox picboxHit = new PictureBox();
            picboxHit.Location = HitPoint;
            picboxHit.Width = 50; picboxHit.Height = 50;
            
            picboxHit.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxHit.SendToBack();

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

        public void Winner()
        {
            lblWinner.Text = ($"{countryHandler.CountryList[0].CountryName} Won the war!!");
            lblWinner.Left = (this.ClientSize.Width - lblWinner.Width) / 2;

            AmbientWarMediaPlayer.Ctlcontrols.stop();
            WinnerSound();            
        }

        public void Repaint(object source, EventArgs e)
        {
            //int i = countryHandler.CountryList.Count;
            //int labelL = CountryLabelEnduranceList.Count;
            var Attkcountry = countryHandler.CountryList[countryHandler.CurrentAttkCountry];
            var Deffcountry = countryHandler.CountryList[countryHandler.CurrentDeffCountry];

            //countryHandler.CountryList[countryHandler.CurrentDeffCountry]);

            //get coords from countryhandler
            Point attackingCountryCoordinates = new Point(Attkcountry.CordinateX, Attkcountry.CordinateY);
            Point defendingCountryCoordinates = new Point(Deffcountry.CordinateX, Deffcountry.CordinateY);
            // Gets the curvepoint from helperclass.
            Point curvepoint = h.DrawCurve(attackingCountryCoordinates, defendingCountryCoordinates);
            


            // Create points that defines the curve.
            Point[] curvePoints = { attackingCountryCoordinates, curvepoint, defendingCountryCoordinates };

            // Create pen tool
            float[] dashValues = { 4, 1 };
            Pen dashPen = new Pen(Color.Red, 3);

            dashPen.DashPattern = dashValues;
            Graphics g = panel1.CreateGraphics();

            // Draw dashed curve.
            //MissileSound();
            g.DrawCurve(dashPen, curvePoints);

            string WarStatus = (countryHandler.CountryList[countryHandler.CurrentAttkCountry].CountryName + " Attacks " + countryHandler.CountryList[countryHandler.CurrentDeffCountry].CountryName);

            lblOngoingWarStatus.Text = (WarStatus);
            lblOngoingWarStatus.Left = (this.ClientSize.Width - lblOngoingWarStatus.Width) / 2;
            

            Debug.WriteLine(countryHandler.CountryList[countryHandler.CurrentAttkCountry].CountryName +
            "Attacks" + countryHandler.CountryList[countryHandler.CurrentDeffCountry].CountryName);
        }

        private void AtackTimer_Tick(object sender, EventArgs e)
        {
            countryHandler.StartWar();
        }

        private void EndOfGame() // När kriget är slut
        {
            // Här ska skrivas vad som händer efter landet som vann.
            new ManualResetEvent(false).WaitOne(5000);
            Application.Exit();
        }
    }
}