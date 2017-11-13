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
        protected override void OnMouseMove(MouseEventArgs e)
        {
            //lblX.Text = "X =" + e.X + "; Y =  " + e.Y;
            //int x = 0, y = 0;
            //base.OnMouseMove(e);
            //Graphics g = CreateGraphics();
            //Pen p = new Pen(Color.Red);
            //Pen erase = new Pen(Color.White);
            //g.DrawLine(erase, 0, 0, x, y);
            //x = e.X; y = e.Y;
            //g.DrawLine(p, 0, 0, x, y);
            //lblX.Location = new Point(x - lblX.Width, y);
            //lblY.Location = new Point(x, y - lblY.Height);
            //lblX.Text = x.ToString(); lblY.Text = y.ToString();

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            lblXNY.Text = "X =" + e.X + "; Y =  " + e.Y;

            
            int mouseClicksCounter = 0;

            MouseClick += Form1_MouseClick;


            int.TryParse(e.X.ToString(), out X);
            int.TryParse(e.Y.ToString(), out Y);

            cords = new coordinates(X, Y);

            coordinatessList.Add(cords);

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

            Pen p = new Pen(Color.Red,3);

            //e.Graphics.DrawLine(p , 765, 251, 572, 186);
            Rectangle rect = new Rectangle(0, 0, 2000, 200);

            float startAngle = 45F;
            float sweepAngle = 45F;

            e.Graphics.DrawArc(p, rect, startAngle, sweepAngle);
           // e.Graphics.DrawArc(0, -180f);
          //e.Graphics.DrawArc(Pens.Red, 765, 251, 572, 186, 0, -180);
            
        }
    }


}