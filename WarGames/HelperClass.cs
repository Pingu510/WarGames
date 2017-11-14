using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WarGames
{
    public class HelperClass
    {
        private static void BlendPictures (Bitmap bg, Bitmap front, int deltaX, int deltaY)
        {
            for (int y = 0; y < front.Height; y++)
            {
                for (int x = 0; x < front.Width ; x++)
                {
                    if(front.GetPixel(x,y).A < 255 )
                    {
                        Color newColor = bg.GetPixel(x + deltaX, y + deltaY);
                        front.SetPixel( x, y, newColor);
                    }
                }
            }
        }

        public static void BlendPictures (PictureBox picBoxBack, PictureBox picBoxFront)
        {
            int leftDifference = Math.Abs(picBoxBack.Left - picBoxFront.Left);
            int topDifference = Math.Abs(picBoxBack.Top - picBoxFront.Top);
            BlendPictures((Bitmap)picBoxBack.BackgroundImage, (Bitmap)picBoxFront.Image, leftDifference,topDifference);
        }


        public void Lost (string Country, int ContryEndurance )
        {
            if (ContryEndurance == 0)
            MessageBox.Show($" {Country} Lost");
        }

        /// <summary>
        /// Math for curve
        /// </summary>
        public List<Point> DrawCurve(Point from, Point to)
        {
            List<Point> Coordinates = new List<Point>();
            Point Curve = new Point(0,0) ;
            
            // ifsatser för curve point.
            if (true) //nivåskillnad + kort avstånd
            {
                Curve.X = 20;
                Curve.Y = 20;
                //xcurve = (xfrom + xto) / 2;
                //ycurve = Math.Abs(xfrom - xto) * 2; // Math.Abs ger absoluta värdet dvs positivt tal
            }
            else if (true) // nivåskillnad
            {

            }
            else if (true) // kort avstånd
            {

            }
            else if (true) //långt avstånd
            {

            }
            else // standard
            {
                //http://mathforum.org/dr.math/gifs/darcy10.18.03c.gif
                //https://math.stackexchange.com/questions/96168/how-to-find-mid-point-of-an-arc
                //https://math.stackexchange.com/questions/1337344/get-third-point-from-an-arc-constructed-by-start-point-end-point-and-bulge
                //xcurve = (xfrom + xto) / 2;
                //ycurve = xcurve * ((yfrom + yto) / ((Math.Abs(xfrom - xto)) / 2f));
                //xcurve = (xfrom + xto) / 2;
                //ycurve = (yfrom - yto);
            }

            Coordinates.Add(from);
            Coordinates.Add(Curve);
            Coordinates.Add(to);
            return Coordinates;


        }
    }
}
