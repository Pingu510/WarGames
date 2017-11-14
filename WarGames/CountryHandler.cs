using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarGames.NuclearCountries;
using System.Drawing;

namespace WarGames
{
    class CountryHandler
    {
        public delegate void NukeCountryEventHandler(object source, EventArgs args);

        public event NukeCountryEventHandler CountryNuked;

        
        public int CurrentAttkCountry;
        public int CurrentDeffCountry;


        public List<Country> CountryList = new List<Country>();
        Random random = new Random();

        
        /// <summary>
        /// Starts the game, creates the list and starts the war.
        /// </summary>
        public void StartGame()
        {
            CreateAllCountriesAnew();
            StartWar();
            Winner();
            //FIXA - Spelet är klart här, visa Endscreen eller starta om
        }


        /// <summary>
        /// Runs untill all countries are dead.
        /// </summary>
        public void StartWar()
        {
            // While there are countries still alive in the list
            while (CountryList.Count > 0)
            {

                //FIXA - Ska turordningen vara random eller ej?
                int AttackingCountry = GetRandomNr();
                int DefendingCountry = GetRandomNr();

                while(AttackingCountry == DefendingCountry)
                {
                    DefendingCountry = GetRandomNr();
                }

                CurrentAttkCountry = AttackingCountry;
                CurrentDeffCountry = DefendingCountry;

                NukeCountry(DefendingCountry);
                OnNukeCountry(); // FIXA - Event som triggar attack animation


                // Checks if the defending Country died.
                if (CountryList[DefendingCountry].CheckIfCountryIsAlive() == false)
                {
                    DeleteCountry(CountryList[DefendingCountry]);
                    //FIXA - Event som visar att landet dog?

                    // Gives a kill point to the last attcking country
                    CountryList[AttackingCountry].Kills += 1;
                }
                else
                {
                    CountryList[AttackingCountry].Assists += 1;
                }

                //FIXA - Någon sorts timer här 
                AttackSleepTime();

            }
        }

        public string Winner()
        {
            //Debug.WriteLine(CountryList[0].CountryName + " Won The 'Game'");
            return CountryList[0].CountryName;
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
        

        /// <summary>
        /// Deletes country from list
        /// </summary>
        private void DeleteCountry(Country c)
        {
            CountryList.Remove(c);
        }

        /// <summary>
        /// Skickar tbx ett random tal
        /// </summary>
        private int GetRandomNr()
        {
            return random.Next(0, CountryList.Count - 1);
        }

        /// <summary>
        ///  Setting for changeing attack frequency
        /// </summary>
        public void AttackSleepTime(int miliseconds = 500)
        {
            System.Threading.Thread.Sleep(miliseconds);
            //int secondinterval = 1000;
            //Timer timer = new Timer();
            //timer.Interval = secondinterval;
            //timer.Elapsed += Timer_Elapsed;
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
