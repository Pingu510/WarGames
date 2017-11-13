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

namespace WarGames
{
    public partial class Form1 : Form
    {
        int X;
        int Y;
        coordinates cords;

        public List<coordinates> coordinatessList = new List<coordinates>();
        
        CountryHandler countryHandler = new CountryHandler();

        HelperClass h = new HelperClass();
        public Form1()
        {
            System.Timers.Timer hitTime;
            InitializeComponent();
            // use countryHandler to acces the list and bombing events etc




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

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            //int xfrom = countryHandler.CountryList[0].CordinateX;
            int xfrom = 65;
            int yfrom = 170;
            int xto = 620;
            int yto = 68;
            float xcurve = 0;
            float ycurve = 0;

            // ifsatser för curve point.
            if (((yfrom + yto)/2 > 200) && (xfrom - xto) < 100) //nivåskillnad + kort avstånd
            {
                xcurve = (xfrom + xto)/2; 
                ycurve = Math.Abs(xfrom - xto)*2; // Math.Abs ger absoluta värdet dvs positivt tal
            }            
            //else if ((yfrom + yto)/2 > 100) // nivåskillnad
            //{

            //}
            //else if ((xfrom + xto) < 100) // kort avstånd
            //{

            //}
            //else if ((xfrom - xto) > 400) //långt avstånd
            //{

            //}
            else // standard
            {
                //http://mathforum.org/dr.math/gifs/darcy10.18.03c.gif
                //https://math.stackexchange.com/questions/96168/how-to-find-mid-point-of-an-arc
                //https://math.stackexchange.com/questions/1337344/get-third-point-from-an-arc-constructed-by-start-point-end-point-and-bulge
                xcurve = (xfrom + xto) / 2;
                ycurve = xcurve*((yfrom + yto)/((Math.Abs(xfrom - xto))/2f));
                //xcurve = (xfrom + xto) / 2;
                //ycurve = (yfrom - yto);
            }


            // Create points that define curve.
            Point point1 = new Point(xfrom, yfrom);
            Point point2 = new Point((int)xcurve, (int)ycurve);
            Point point3 = new Point(xto, yto);
            Point[] curvePoints = { point1, point2, point3 };
            

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