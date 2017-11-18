using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarGames.NuclearCountries;

namespace WarGames
{
    class CountryHandler
    {

        HelperClass h = new HelperClass();
        public delegate void NukeCountryEventHandler(object source, EventArgs args);
        public delegate void DeadCountryEventHandler(object source, IntEventArgs args);
        public delegate void HitCountryEventHandler(object source, PointEventArgs args);


        public event NukeCountryEventHandler CountryNuked;
        public event DeadCountryEventHandler DeadCountry;
        public event HitCountryEventHandler HitCountry;
        
        public int CurrentAttkCountry;
        public int CurrentDeffCountry;
   
        public int CurrentEndurance;
        Random random;


        public List<Point> AttackPoint = new List<Point>();
        public List<Country> CountryList = new List<Country>();
        
        public CountryHandler()
        {
            random = new Random(DateTime.Now.Millisecond);
        }
        
        /// <summary>
        /// Starts the game, creates the list and starts the war.
        /// </summary>
        public void StartNewGame()
        {
            CreateAllCountriesAnew();
            StartWar();
        }


        /// <summary>
        /// Runs untill all countries are dead.
        /// </summary>
        public void StartWar()
        {            
            if (CountryList.Count > 1)
            {
                //FIXA - Ska turordningen vara random eller ej?
                int AttackingCountry = GetRandomNr();
                int DefendingCountry = GetRandomNr();

                while(AttackingCountry == DefendingCountry)
                {
                    if (CountryList.Count > 2)
                        DefendingCountry = GetRandomNr();
                    else if (AttackingCountry == 1)
                        DefendingCountry = 0;
                    else
                        DefendingCountry = 1;
                }

                CurrentAttkCountry = AttackingCountry;
                CurrentDeffCountry = DefendingCountry;
                CurrentAttkCountry.ToString();

                NukeCountry(DefendingCountry);

                CurrentEndurance = CountryList[DefendingCountry].CountryEndurance;

                // Checks if the defending Country died.
                if (CountryList[DefendingCountry].CheckIfCountryIsAlive() == false )//&& CountryList[AttackingCountry].CheckIfCountryIsAlive == true)
                {
                    // Gives a kill point to the last attacking country
                    CountryList[AttackingCountry].Kills += 1;

                }
                else
                {
                    CountryList[AttackingCountry].Assists += 1;
                }
                OnNukeCountry();
                OnDeadCountry();
            }
        }

        public void Winner()
        {
            //Debug.WriteLine(CountryList[0].CountryName + " Won The 'Game'");
            //return CountryList[0].CountryName;
        }

        /// <summary>
        /// Attacks the country and takes away 1 endurance
        /// </summary>
        private void NukeCountry(int DefendingCountry)
        {
            CountryList[DefendingCountry].CountryEndurance -= 1;
            
        }

        protected virtual void OnNukeCountry()
        {
            if (CountryNuked != null)
                CountryNuked(this, EventArgs.Empty);
        }

        protected virtual void OnDeadCountry()
        {
            if (DeadCountry != null)
            {
                DeadCountry(this, new IntEventArgs() {CountryID = CurrentDeffCountry });
            }
        }

        // What to place here to actually use this?????
        protected virtual void OnHitCountry()
        {
            if (HitCountry != null)
            {
                //countryHandler.CountryList[countryHandler.CurrentDeffCountry]
                //HitCountry(this, new PointEventArgs() { HitPoint =   });// new Point(CountryList[DefendingCountry].CordinateX, CountryList[DefendingCountry].CordinateY) });
                //HitCountry(this, new PointEventArgs() { HitPoint = new Point(DefendingCountry.CordinateX, DefendingCountry.CordinateY);

            }
        }


        /// <summary>
        /// Deletes country from list
        /// </summary>
        public void DeleteCountry(int i)//Country c)
        {
            CountryList.RemoveAt(i);
            

        }

        /// <summary>
        /// Skickar tbx ett random tal
        /// </summary>
        private int GetRandomNr()
        {
            return random.Next(0, CountryList.Count);
        }
        

        /// <summary>
        /// Creates a new list with all the countries.
        /// </summary>
        private void CreateAllCountriesAnew()
        {
            CountryList.Clear();
                       
            CountryList.Add(new China());           
            CountryList.Add(new France());
            CountryList.Add(new India());
            CountryList.Add(new Israel());
            CountryList.Add(new NorthKorea());
            CountryList.Add(new Pakistan());
            CountryList.Add(new Russia());
            CountryList.Add(new Sweden());
            CountryList.Add(new UnitedKingdom());
            CountryList.Add(new UnitedStates());

        }
    }
}
