﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Timers;
using System.Threading;
using WarGames.NuclearCountries;
using System.Diagnostics;
using System.Media;
using System.IO;

namespace WarGames
{

    public partial class Form1 : Form
    {
        //int X;
        //int Y;
        //coordinates cords;

        //public List<coordinates> coordinatessList = new List<coordinates>();
        
        CountryHandler countryHandler = new CountryHandler();
        List<Label> CountryLabelEnduranceList = new List<Label>();
        SoundPlayer SoundEffects;
        //SoundPlayer SoundEffects2;
        private string dirpath;

        HelperClass h = new HelperClass();

        public Form1()
        {
            // use countryHandler to acces the list and bombing events etc
            countryHandler.DeadCountry += CountryDiedUpdateLabel;
            //countryHandler.CountryNuked += UpdateLabels;
            countryHandler.CountryNuked += Repaint;

            //countryHandler.HitCountry += HitAnimation;


            //panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);

            InitializeComponent();
            ThreadStart playerThread = new ThreadStart(MissileSound);
            Thread PlayMissileSound = new Thread(playerThread);
            PlayMissileSound.Start();


            



            ThreadStart playerThread2 = new ThreadStart(AmbientSound);
            Thread PlayAmbientSound = new Thread(playerThread2);
            PlayAmbientSound.Start();

        }

        //public void DeathSound()
        //{
        //    dirpath = Directory.GetCurrentDirectory().ToString();
        //    Sound = new SoundPlayer(dirpath + "\\Snow_white.wav");
        //}


        //public  void PlayBGSound(string dirpath)
        //{
        //    axWindowsMediaPlayer1.URL = dirpath + "\\War.wav";
        //    axWindowsMediaPlayer1.Ctlcontrols.play();
        //    //axMediaPlay
        //    //MediaPlayer myPlayer = new MediaPlayer();
        //    //myPlayer.Open(this.dirpath + "\\War.wav");
        //    //myPlayer.Play();
        //}

        //Play(Application.StartupPath + "\\Track1.wav");
        //{
        //}
        //Play(Application.StartupPath + "\\Track2.wav");

        public void AmbientSound()
        {
            //new Thread(() => {
            axWindowsMediaPlayer1.URL = dirpath + "\\War.wav";
            axWindowsMediaPlayer1.Ctlcontrols.play();

            //dirpath = Directory.GetCurrentDirectory().ToString();
            //SoundEffects2 = new SoundPlayer(dirpath + "\\War.wav");
            //SoundEffects2.PlayLooping();
            // }).Start();

        }

        void MissileSound()
        {
            //new Thread(() => {
            //axWindowsMediaPlayer2.URL = dirpath + "\\Missle_Launch.wav";
            //axWindowsMediaPlayer2.Ctlcontrols.play();

            dirpath = Directory.GetCurrentDirectory().ToString();
            SoundEffects = new SoundPlayer(dirpath + "\\Missile Fire War.wav");
            SoundEffects.Play();
        //}).Start();

            //dirpath = Directory.GetCurrentDirectory().ToString();
            //SoundEffects2 = new SoundPlayer(dirpath + "\\Missile Fire War.wav");
            //SoundEffects2.Play();
        }


        public void WinnerSound()
        {
            axWindowsMediaPlayer2.URL = dirpath + "\\FF1XFanfare.wav";
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        //public void playpSoundEffects()
        //{
        //    ThreadPool.QueueUserWorkItem(o =>
        //    {
        //        SoundEffects.Play();
        //        Thread.Sleep(10000);
        //        SoundEffects.Stop();
        //    });
        //}
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

        private void SetLabelsStartUpText()
        {
            foreach (var i in CountryLabelEnduranceList)
            {
                i.Text = countryHandler.CurrentEndurance.ToString();
            }
        }

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
                    picBoxFront.Visible = false;
                    picY.Visible = false;
                    countryHandler.StartNewGame();
                    //h.playSound();
                    
                    AmbientSound();
                    tbxStart.Text = null;

                }
                else if (e.KeyCode == Keys.N)
                {
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

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            // Get mouse location in panel1
            lblXNY.Text = e.Location.X + ":" + e.Location.Y;
        }
                
        public void CountryDiedUpdateLabel(object source, IntEventArgs e)
        {
            if (countryHandler.CountryList[e.CountryID].CountryEndurance != 0)
            {
                for (int i = 0; i < countryHandler.CountryList.Count; i++)
                {
                    if (countryHandler.CountryList.Count == 1)
                    {
                        CountryLabelEnduranceList[0].Text = "Winner";
                    }
                    else
                    {
                        CountryLabelEnduranceList[i].Text = countryHandler.CountryList[i].CountryEndurance.ToString();
                        HitAnimation(e.CountryID);
                    }
                }
            }
            else
            {
                CountryLabelEnduranceList[e.CountryID].Text = "Ded";
                
                CountryLabelEnduranceList.RemoveAt(e.CountryID);
                ShowDeath(e.CountryID);
                
                MissileSound();
                //DeathSound();
                countryHandler.DeleteCountry(e.CountryID);

                if (countryHandler.CountryList.Count == 1)
                {
                    ShowWarText();
                    lblWinner.Text = ($"{countryHandler.CountryList[0].CountryName} Won the war!!");
                    lblWinner.Left = (this.ClientSize.Width - lblWinner.Width) / 2;
                    lblWinner.Top = (this.ClientSize.Height - lblWinner.Height - 160 ) ;
                    WinnerSound();
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    new ManualResetEvent(false).WaitOne(5000);
                    EndOfGame();
                }
            }
        }

        public void ShowWarText()
        {
            Image warImage = Properties.Resources.warImage;
            Graphics g = panel1.CreateGraphics();
            g.DrawImage(warImage, 425, 150);
        }


        public void ShowDeath(int i)
        {
            Point nukedPoint;
            nukedPoint = new Point(countryHandler.CountryList[i].CordinateX - 45, countryHandler.CountryList[i].CordinateY - 25);

            Image deathimage = Properties.Resources.Skull_smaller;
            
            Graphics g = panel1.CreateGraphics();
            g.DrawImage(deathimage, nukedPoint);
        }

        public void HitAnimation(int i)
        {
            Point HitPoint;
            HitPoint = new Point(countryHandler.CountryList[i].CordinateX - 45, countryHandler.CountryList[i].CordinateY - 25);

            PictureBox picboxHit = new PictureBox();
            picboxHit.Location = HitPoint;
            picboxHit.Width =60; picboxHit.Height = 60;
            
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

            //Graphics g = panel1.CreateGraphics();

            //Bitmap MyImage = new Bitmap(Properties.Resources.explosion);
            //MyImage = new Bitmap(Properties.Resources.explosion);

            //Graphics g = Graphics.FromImage(MyImage);
            //picboxHit.Image = MyImage;

            //g.DrawImage(MyImage, HitPoint);
            //Graphics g = panel1.CreateGraphics();
            //g.DrawImage(deathimage, HitPoint);
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

            Debug.WriteLine(countryHandler.CountryList[countryHandler.CurrentAttkCountry].CountryName +
            "Attacks" + countryHandler.CountryList[countryHandler.CurrentDeffCountry].CountryName);
        }

        public Bitmap MyImage; // test bild

        //public void HitAnimation(object source, PointEventArgs e)
        //{
            
        //    var Deffcountry = countryHandler.CountryList[countryHandler.CurrentDeffCountry];
        //    Point HitPoint = new Point(Deffcountry.CordinateX, Deffcountry.CordinateY);

        //    //countryHandler.AttackPoint.Add(HitPoint);

        //    //PictureBox picboxHit = new PictureBox();
        //    //picboxHit.Visible = true;
        //    //picboxHit.BringToFront();
        //    //picboxHit.Location = HitPoint;
        //    //picboxHit.Width = 30;
        //    //picboxHit.Height = 30;

        //    Image HitImage = Properties.Resources.explosion;

        //    Graphics g = panel1.CreateGraphics();
        //    //MyImage = new Bitmap(Properties.Resources.explosion);
        //    picboxHit.Image = (Image)MyImage;
        //    g.DrawImage(HitImage, HitPoint);
        //}







        private void AtackTimer_Tick(object sender, EventArgs e)
        {
            countryHandler.StartWar();
          
        }

        private void EndOfGame() // När kriget är slut
        {
            // Här ska skrivas vad som händer efter landet som vann.
            Application.Exit();
        }
        
    }

}