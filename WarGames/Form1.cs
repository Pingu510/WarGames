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

        HelperClass h = new HelperClass();

        public Form1()
        {
            countryHandler.CountryNuked += Repaint;

            InitializeComponent();
            // use countryHandler to acces the list and bombing events etc
            countryHandler.StartGame();



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
                    System.Threading.Thread.Sleep(500);
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
            tbxStart.Text.ToUpper();
            e.Handled = !(char.IsLetter(e.KeyChar)
            || e.KeyChar == (char)Keys.Y
            || e.KeyChar == (char)Keys.N);

            if (e.KeyChar == (char)Keys.Y)
            {
                tbxStart.Visible = false;
                picY.Visible = true;
                System.Threading.Thread.Sleep(500);
            }
            else if (e.KeyChar == (char)Keys.N)
            {
                picN.Visible = true;
                tbxStart.Visible = false;
            }
            else return; // Need some code here to handle what happends on all other keys Or rather prevent using the wrong keys AKA not Y/N



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

        public void Repaint(object source, EventArgs e)
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
            var e2= e as System.Windows.Forms.PaintEventArgs;
            //var e1 = System.Windows.Forms.PaintEventArgs.Empty;
            Debug.WriteLine(countryHandler.CountryList[countryHandler.CurrentAttkCountry].CountryName + " Attacks " + countryHandler.CountryList[countryHandler.CurrentDeffCountry].CountryName);
            //e2.Graphics.DrawCurve(dashPen, curvePoints);
            //panel1_Paint(this, e2);
        }

       

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            ////get coords from countryhandler
            //List<Point> points = h.DrawCurve(new Point (200,0), new Point (400,0));
            ////int xfrom = countryHandler.CountryList[0].CordinateX;


            //// Create points that define curve.
            //Point[] curvePoints = { points[0], points[1], points[2] };
            

            //// Draw curve to screen.
            ////e.Graphics.DrawCurve(redPen, curvePoints);

            //// Draw dashed curve.
            //float[] dashValues = { 4, 1 };
            //Pen dashPen = new Pen(Color.Red, 3);
            //dashPen.DashPattern = dashValues;
            //e.Graphics.DrawCurve(dashPen, curvePoints);
            
        }
    }
    
}