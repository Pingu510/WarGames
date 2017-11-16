using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading;

namespace WarGames
{
    public class HelperClass
    {
        private string dirpath;
       // private SoundPlayer Sound;

        /// <summary>
        /// Math for curve
        /// </summary>
        public Point DrawCurve(Point from, Point to)
        {
            Point Curve = new Point(0, 0);

            double distance;

            if (from.X >= to.X)
            {
                distance = from.X - to.X;
                Curve.X = (int)((from.X - to.X)/2.0 + to.X);
            }
            else
            {
                distance = to.X - from.X;
                Curve.X = (int)((to.X - from.X)/2.0 + from.X);
            }

            double Angle1_degrees = (45d * (Math.PI / 180));
            double Angle2_degrees = (90d * (Math.PI / 180));
            double calcylatedY = ((distance * Math.Sin(Angle1_degrees)) / Math.Sin(Angle2_degrees));
            Curve.Y = (int)Math.Round(calcylatedY, 0);

            return Curve;
            
        }
        
    }
}
