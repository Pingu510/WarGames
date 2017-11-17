using System;
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
        
        
        //firstThread.Start();


        CountryHandler countryHandler = new CountryHandler();
        List<Label> CountryLabelEnduranceList = new List<Label>();
        SoundPlayer SoundEffects;
      

        private string dirpath;

        HelperClass h = new HelperClass();

        public Form1()
        {
            // use countryHandler to acces the list and bombing events etc
            countryHandler.DeadCountry += CountryDiedUpdateLabel;
            //countryHandler.CountryNuked += UpdateLabels;
            countryHandler.CountryNuked += Repaint;

            //panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);

            InitializeComponent();
            //dirpath = Directory.GetCurrentDirectory().ToString();
            //SoundEffects = new SoundPlayer(dirpath + "\\War.wav");
            //SoundEffects.SoundLocation = "War.wav";

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
                //SoundEffects = new SoundPlayer(dirpath + "\\War.wav");
                //SoundEffects.PlayLooping();
           // }).Start();
        }

        void MissileSound()
        {
            //new Thread(() => {
            //    axWindowsMediaPlayer1.URL = dirpath + "\\Missle_Launch.wav";
            //    axWindowsMediaPlayer1.Ctlcontrols.play();



            dirpath = Directory.GetCurrentDirectory().ToString();
            SoundEffects = new SoundPlayer(dirpath + "\\Missile Fire War.wav");
            SoundEffects.Play();
        //}).Start();



            //dirpath = Directory.GetCurrentDirectory().ToString();
            //SoundEffects2 = new SoundPlayer(dirpath + "\\Missile Fire War.wav");
            //SoundEffects2.Play();
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

        
        //public void UpdateLabels(object source, EventArgs e)
        //{
        //    for (int i = 0; i < countryHandler.CountryList.Count; i++)
        //    {                
        //        if (countryHandler.CountryList.Count == 1)
        //        {
        //            CountryLabelEnduranceList[0].Text = "Winner";
        //        }
        //        else
        //        {
        //            CountryLabelEnduranceList[i].Text = countryHandler.CountryList[i].CountryEndurance.ToString();
        //        }
        //    }
        //}

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
                    }
                }
            }
            else
            {
                CountryLabelEnduranceList[e.CountryID].Text = "Ded";
                
                CountryLabelEnduranceList.RemoveAt(e.CountryID);
                ShowDeath(e.CountryID);
                //DeathSound();
                countryHandler.DeleteCountry(e.CountryID);

                if (countryHandler.CountryList.Count == 1)
                {
                    MessageBox.Show($"{countryHandler.CountryList[0].CountryName} Won the war!!");
                }
            }
        }

        public void ShowDeath(int i)
        {
            Point nukedPoint;
            //deathLabel = countryHandler.CountryList.CountryName.ToString();
            nukedPoint = new Point( countryHandler.CountryList[i].CordinateX, countryHandler.CountryList[i].CordinateY );
            //picBoxFront p = new picBoxFront();
            
            Image deathimage = Properties.Resources.Skull_smaller;
            Graphics g = panel1.CreateGraphics();
            g.DrawImage(deathimage, nukedPoint);

            
            //InitializePictureBox();
            //picBoxFront.Location = poo;
            //picBoxFront.Visible = true;
        }

        

        

        //private void InitializePictureBox()
        //{
        //    PictureBox p;
        //    p = new PictureBox();

        //    // Set the location and size of the PictureBox control.
        //    p.Location = new System.Drawing.Point(70, 120);
        //    p.Size = new System.Drawing.Size(140, 140);
        //    p.TabStop = false;

        //    // Set the SizeMode property to the StretchImage value.  This
        //    // will shrink or enlarge the image as needed to fit into
        //    // the PictureBox.
        //    p.SizeMode = PictureBoxSizeMode.StretchImage;

        //    // Set the border style to a three-dimensional border.
        //    p.BorderStyle = BorderStyle.Fixed3D;

        //    // Add the PictureBox to the form.
        //    this.Controls.Add(p);

        //}


        public void Repaint(object source, EventArgs e)
        {
            int i = countryHandler.CountryList.Count;
            int labelL = CountryLabelEnduranceList.Count;
            var Attkcountry = countryHandler.CountryList[countryHandler.CurrentAttkCountry];
            var Deffcountry = countryHandler.CountryList[countryHandler.CurrentDeffCountry];


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
            MissileSound();
            g.DrawCurve(dashPen, curvePoints);

            Debug.WriteLine(countryHandler.CountryList[countryHandler.CurrentAttkCountry].CountryName +
            "Attacks" + countryHandler.CountryList[countryHandler.CurrentDeffCountry].CountryName);

        }

        private void AtackTimer_Tick(object sender, EventArgs e)
        {
            countryHandler.StartWar();
          
        }
        
    }

}