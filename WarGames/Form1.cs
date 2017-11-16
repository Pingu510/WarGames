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
        List<Label> CountryLabelEnduranceList = new List<Label>();
        

        HelperClass h = new HelperClass();

        public Form1()
        {
            // use countryHandler to acces the list and bombing events etc
            countryHandler.DeadCountry += CountryDiedUpdateLabel;
            countryHandler.CountryNuked += UpdateLabels;
            countryHandler.CountryNuked += Repaint;
            
            //panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);

            InitializeComponent();
            
            
        }
        private void AddLabelsToList()
        {
            CountryLabelEnduranceList.Add(lblChinaEndurance);
            CountryLabelEnduranceList.Add(lblFranceEndurance);
            CountryLabelEnduranceList.Add(lblIndiaEndurance);
            CountryLabelEnduranceList.Add(lblIsraelEndurance);
            CountryLabelEnduranceList.Add(lblNorthKoreaEndurance);
            CountryLabelEnduranceList.Add(lblPakistanEndurance);
            CountryLabelEnduranceList.Add(lblRussiaEndurance);
            CountryLabelEnduranceList.Add(lblSwedenEndurance);
            CountryLabelEnduranceList.Add(lblUnitedKingdomEndurance);
            CountryLabelEnduranceList.Add(lblUnitedStatesEndurance);
        }

        private void SetLabelsStartUpText()
        {
            lblChinaEndurance.Text = countryHandler.CurrentEndurance.ToString();
            lblFranceEndurance.Text = countryHandler.CurrentEndurance.ToString();
            lblIndiaEndurance.Text = countryHandler.CurrentEndurance.ToString();
            lblIsraelEndurance.Text = countryHandler.CurrentEndurance.ToString();
            lblNorthKoreaEndurance.Text = countryHandler.CurrentEndurance.ToString();
            lblPakistanEndurance.Text = countryHandler.CurrentEndurance.ToString();
            lblRussiaEndurance.Text = countryHandler.CurrentEndurance.ToString();
            lblSwedenEndurance.Text = countryHandler.CurrentEndurance.ToString();
            lblUnitedKingdomEndurance.Text = countryHandler.CurrentEndurance.ToString();
            lblUnitedStatesEndurance.Text = countryHandler.CurrentEndurance.ToString();
        }

        private void tbxStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y || e.KeyCode == Keys.N)
            {
                if (e.KeyCode == Keys.Y)
                {
                    tbxStart.Visible = false;
                    picY.Visible = true;
                    new ManualResetEvent(false).WaitOne(1500);
                    
                    AddLabelsToList();
                    countryHandler.StartNewGame();
                    tbxStart.Text = null;

                }
                else if (e.KeyCode == Keys.N)
                {
                    picN.Visible = true;
                    tbxStart.Visible = false;
                    new ManualResetEvent(false).WaitOne(1500);
                    Application.Exit();
                }
            }
            else if (e.KeyCode == Keys.Back)
            {
                tbxStart.Clear();
                return;
            }
            else
            {
                MessageBox.Show("Only Y or N! Press backspace to retry");
                return;
            }
        }
        
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            SetLabelsStartUpText();
            AddLabelsToList();
            AttackTimer.Enabled = true;
            countryHandler.StartNewGame();
            // Get mouse location in panel1
            //lblXNY.Text = e.Location.X + ":" + e.Location.Y;

        }

        /// <summary>
        /// 
        /// </summary>
        public void UpdateLabels(object source, EventArgs e)
        {
            //int i = countryHandler.CurrentDeffCountry;
            for (int i = 0; i < countryHandler.CountryList.Count; i++)
            {                
                if (countryHandler.CountryList.Count == 1)
                {
                    CountryLabelEnduranceList[0].Text = "Winner";
                }
                else
                {
                    CountryLabelEnduranceList[i].Text = countryHandler.CountryList[i].CountryEndurance.ToString();
                }
            }
        }
        public void CountryDiedUpdateLabel(object source, IntEventArgs e)
        {
            if (countryHandler.CountryList[e.CountryID].CountryEndurance == 0)
            {

                CountryLabelEnduranceList[e.CountryID].Text = "Ded";
                CountryLabelEnduranceList.RemoveAt(e.CountryID);
            }
        }

        public void Repaint(object source, EventArgs e)
        {
            int i = countryHandler.CountryList.Count;
            int labelL = CountryLabelEnduranceList.Count;
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
            //countryHandler.StartWar();

        }

        private void AtackTimer_Tick(object sender, EventArgs e)
        {
            countryHandler.StartWar();
        }
    }
    
}