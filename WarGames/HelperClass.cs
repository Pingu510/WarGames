﻿using System;
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
        /// <summary>
        /// Math for curve
        /// </summary>
        public Point DrawCurve(Point from, Point to)
        {
            
            Point Curve = new Point(0,0) ;
            
            // ifsatser för curve point.
            if (true) //nivåskillnad + kort avstånd
            {
                Curve.X = 400;
                Curve.Y = 30;
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
            
            return Curve;
            
        }
    }
}
