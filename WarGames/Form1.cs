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

namespace WarGames
{
    public partial class Form1 : Form
    {
        //int X;
        //int Y;
        //coordinates cords;

        //public List<coordinates> coordinatessList = new List<coordinates>();
        
        CountryHandler countryHandler = new CountryHandler();
        public List<Label> CountryLabelScore = new List<Label>();


        HelperClass h = new HelperClass();

        public Form1()
        {

            InitializeComponent();
            // use countryHandler to acces the list and bombing events etc
            //countryHandler.CountryNuked += Repaint;
            

            CountryLabelScore.Add(lblChinaScore);
            CountryLabelScore.Add(lblFranceScore);
            CountryLabelScore.Add(lblIndiaScore);
            CountryLabelScore.Add(lblIsraelScore);
            CountryLabelScore.Add(lblNorthKoreaScore);
            CountryLabelScore.Add(lblPakistanScore);
            CountryLabelScore.Add(lblRussiaScore);
            CountryLabelScore.Add(lblSwedenScore);
            CountryLabelScore.Add(lblUnitedKingdomScore);
            CountryLabelScore.Add(lblUnitedStatesScore);

            //this.picBoxBack.Image = Properties.Resources.MapNight;
            ////this.pnl.BackgroundImage = Properties.Resources.MapNight;
            //this.picBoxFront.Image = Properties.Resources.Logo;
            //this.picBoxFront.Size = this.picBoxFront.Image.Size;



            ////Bitmap bmpB = (Bitmap)picBoxBack.Image;
            //Bitmap bmp1 = (Bitmap)picBoxFront.Image;
            //Graphics g = Graphics.FromImage(bmpB);
            //g.DrawImage(bmpB, 0, 0, bmp1.Size.Width, bmp1.Size.Height);
            //g.Dispose();
            //picBoxBack.Image = bmp0;

            // HelperClass.BlendPictures(this.picBoxBack, this.picBoxFront);
            //var src = new Bitmap(Properties.Resources.Logo) ;
            //var src = new Bitmap(@"WarGames\assets.Logo.png");
            //var bmp = new Bitmap(100, 100, PixelFormat.Format32bppPArgb);
            //var gr = Graphics.FromImage(bmp);
            //{
            //    gr.Clear(Color.Blue);
            //    gr.DrawImage(src, new Rectangle(0, 0, bmp.Width, bmp.Height));
            //    bmp.Save("c:/temp/result.png", ImageFormat.Png);

            //}
        }


        private void tbxStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y || e.KeyCode == Keys.N)
            {
                if (e.KeyCode == Keys.Y)
                {
                    tbxStart.Visible = false;
                    picY.Visible = true;
                    //System.Threading.Thread.Sleep(500);
                    countryHandler.StartGame();
                    
                }
                else if (e.KeyCode == Keys.N)
                {
                    picN.Visible = true;
                    tbxStart.Visible = false;
                }
            }
            else
                return;
            //System.Threading.Thread.Sleep(5000);
            //Application.Exit();

        }

        private void tbxStart_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    tbxStart.Text.ToUpper();
        //    e.Handled = !(char.IsLetter(e.KeyChar)
        //    || e.KeyChar == (char)Keys.Y
        //    || e.KeyChar == (char)Keys.N);

        //    if (e.KeyChar == (char)Keys.Y)
        //    {
        //        tbxStart.Visible = false;
        //        picY.Visible = true;
        //        System.Threading.Thread.Sleep(500);
        //        countryHandler.StartGame();
        //    }
        //    else if (e.KeyChar == (char)Keys.N)
        //    {
        //        picN.Visible = true;
        //        tbxStart.Visible = false;
        //    }
        //    else return; // Need some code here to handle what happends on all other keys Or rather prevent using the wrong keys AKA not Y/N

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            // Get mouse location in panel1
            lblXNY.Text = e.Location.X + ":" + e.Location.Y;
            
            //int.TryParse(e.X.ToString(), out X);
            //int.TryParse(e.Y.ToString(), out Y);

            //cords = new coordinates(X, Y);

            //coordinatessList.Add(cords);

        }

        public void UpdateLabels ()
        {
            int i = countryHandler.CurrentDeffCountry;

            CountryLabelScore[i].Text = countryHandler.CountryList[i].CountryName +
                            " " + countryHandler.CountryList[i].CountryEndurance.ToString();
            //switch (countryHandler.CurrentDeffCountry)
            //{
            //    case 0:
            //        {
            //            CountryLabelScore[0].Text = countryHandler.CountryList[0].CountryName +
            //                " " + countryHandler.CountryList[0].CountryEndurance.ToString();
            //        }
            //        break;
            //    case 1:
            //        {
            //            CountryLabelScore[1].Text = countryHandler.CountryList[1].CountryName +
            //                " " + countryHandler.CountryList[1].CountryEndurance.ToString();
            //        }
            //        break;
            //    case 2:
            //        {
            //            CountryLabelScore[2].Text = countryHandler.CountryList[2].CountryName +
            //                " " + countryHandler.CountryList[2].CountryEndurance.ToString();
            //        }
            //        break;
            //    case 3:
            //        {
            //            CountryLabelScore[3].Text = countryHandler.CountryList[3].CountryName +
            //                " " + countryHandler.CountryList[3].CountryEndurance.ToString();
            //        }
            //        break;
            //    case 4:
            //        {
            //            CountryLabelScore[4].Text = countryHandler.CountryList[4].CountryName +
            //                " " + countryHandler.CountryList[4].CountryEndurance.ToString();
            //        }
            //        break;
            //    case 5:
            //        {
            //            CountryLabelScore[5].Text = countryHandler.CountryList[5].CountryName +
            //                " " + countryHandler.CountryList[5].CountryEndurance.ToString();
            //        }
            //        break;
            //    case 6:
            //        {
            //            CountryLabelScore[6].Text = countryHandler.CountryList[6].CountryName +
            //                " " + countryHandler.CountryList[6].CountryEndurance.ToString();
            //        }
            //        break;
            //    case 7:
            //        {
            //            CountryLabelScore[7].Text = countryHandler.CountryList[7].CountryName +
            //                " " + countryHandler.CountryList[7].CountryEndurance.ToString();
            //        }
            //        break;
            //    case 8:
            //        {
            //            CountryLabelScore[8].Text = countryHandler.CountryList[8].CountryName +
            //                " " + countryHandler.CountryList[8].CountryEndurance.ToString();
            //        }
            //        break;
            //    case 9:
            //        {
            //            CountryLabelScore[9].Text = countryHandler.CountryList[9].CountryName +
            //                " " + countryHandler.CountryList[9].CountryEndurance.ToString();
            //        }
            //        break;
            //    case 10:
            //        {
            //            CountryLabelScore[10].Text = countryHandler.CountryList[10].CountryName +
            //                " " + countryHandler.CountryList[10].CountryEndurance.ToString();
            //        }
            //        break;
            //}
        }

        public void Repaint(object source, EventArgs e)
        {
            //get coords from countryhandler
            List<Point> points = h.DrawCurve(new Point(910,210), new Point(200,256));
            //int xfrom = countryHandler.CountryList[0].CordinateX;


            // Create points that define curve.
            Point[] curvePoints = { points[0], points[1], points[2] };


            // Draw curve to screen.
            //e.Graphics.DrawCurve(redPen, curvePoints);
           
            // Draw dashed curve.
            float[] dashValues = { 4, 1 };
            Pen dashPen = new Pen(Color.Red, 3);
            dashPen.DashPattern = dashValues;
            var e2= e as System.Windows.Forms.PaintEventArgs;
            var e1 = System.Windows.Forms.PaintEventArgs.Empty;
            Debug.WriteLine(countryHandler.CountryList[countryHandler.CurrentAttkCountry].CountryName +
            "Attacks" + countryHandler.CountryList[countryHandler.CurrentDeffCountry].CountryName);
            UpdateLabels();
            //countryHandler.CountryList[countryHandler.CountryLabelScore == countryHandler.CurrentDeffCountry;
            //CountryLabelScore[1].Text = countryHandler.CountryList[countryHandler.CurrentAttkCountry].CountryName;
            //CountryLabelScore[2].Text = countryHandler.CountryList[countryHandler.CurrentDeffCountry].CountryName;

            //e2.Graphics.DrawCurve(dashPen, curvePoints);
            //panel1_Paint(this, e2);
        }

       

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            //get coords from countryhandler
            List<Point> points = h.DrawCurve(new Point(200, 0), new Point(400, 0));
            //int xfrom = countryHandler.CountryList[0].CordinateX;


            // Create points that define curve.
            Point[] curvePoints = { points[0], points[1], points[2] };


            // Draw curve to screen.
            //e.Graphics.DrawCurve(redPen, curvePoints);

            // Draw dashed curve.
            float[] dashValues = { 4, 1 };
            Pen dashPen = new Pen(Color.Red, 3);
            dashPen.DashPattern = dashValues;
            e.Graphics.DrawCurve(dashPen, curvePoints);
        }
        
    }
    
}