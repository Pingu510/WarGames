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


    }
}
