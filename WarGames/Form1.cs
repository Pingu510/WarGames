using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using WarGames.NuclearCountries;

namespace WarGames
{
    public partial class Form1 : Form
    {
        CountryHandler countryHandle = new CountryHandler();
        
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
            if (e.KeyCode == Keys.Y)
            {
                picY.Visible = true;
            }
            else if (e.KeyCode == Keys.N)
                picN.Visible = true;

            tbxStart.Visible = false;
            //Thread.Sleep(5000);
            //Application.Exit();

        }
    }
}
