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
        List<Label> CountryLabelScore = new List<Label>();
        

        HelperClass h = new HelperClass();

        public Form1()
        {
            // use countryHandler to acces the list and bombing events etc
            countryHandler.CountryNuked += UpdateLabels;
            countryHandler.CountryNuked += Repaint;
            //panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);

            InitializeComponent();
            
            
        }
        private void AddLabelsToList()
        {
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
        }

        private void tbxStart_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Y || e.KeyCode == Keys.N)
            //{
            //    if (e.KeyCode == Keys.Y)
            //    {
            //        tbxStart.Visible = false;
            //        picY.Visible = true;
                    

            //        AddLabelsToList();
            //        countryHandler.StartGame();
            //        tbxStart.Text = null;
                    
            //    }
            //    else if (e.KeyCode == Keys.N)
            //    {
            //        picN.Visible = true;
            //        tbxStart.Visible = false;
            //    }
            //}
            //else if (e.KeyCode == Keys.Back)
            //{
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("Only Y or N! Press backspace to retry");
            //    return;
            //}
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
            AddLabelsToList();
            countryHandler.StartGame();
            // Get mouse location in panel1
            //lblXNY.Text = e.Location.X + ":" + e.Location.Y;

        }

        public void UpdateLabelsHandler(object source, EventArgs e)
        {
            //CountryLabelScore.Clear();
            //int i = 0;
            //AddLabelsToList();
            //foreach (var item in countryHandler.CountryList)
            //{
            //    Label lbl = new Label();
            //    lbl.Text = countryHandler.CountryList[i].CountryEndurance.ToString();
            //    CountryLabelScore.Add(lbl); 
            //    i++;
            //}
            //this.BeginInvoke(new Action(UpdateLabels));
            
            
        }
        public void UpdateLabels(object source, EventArgs e)
        {
            int i = countryHandler.CurrentDeffCountry;
            if (countryHandler.CountryList[i].CountryEndurance == 0)
            {

                CountryLabelScore[i].Text = "Ded";
                CountryLabelScore.RemoveAt(i);
            }
            else
                CountryLabelScore[i].Text = countryHandler.CountryList[i].CountryEndurance.ToString();

        }

        public void Repaint(object source, EventArgs e)
        {
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
            g.DrawCurve(dashPen, curvePoints);

            Debug.WriteLine(countryHandler.CountryList[countryHandler.CurrentAttkCountry].CountryName +
            "Attacks" + countryHandler.CountryList[countryHandler.CurrentDeffCountry].CountryName);
            countryHandler.StartWar();

        }

    }
    
}