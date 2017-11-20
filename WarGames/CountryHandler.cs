using System;
using System.Collections.Generic;
using System.Drawing;
using WarGames.NuclearCountries;

namespace WarGames
{
    class CountryHandler
    {
        //HelperClass h = new HelperClass();
        public delegate void NukeCountryEventHandler(object source, EventArgs args);
        public delegate void DeadCountryEventHandler(object source, IntEventArgs args);

        public event NukeCountryEventHandler CountryNuked;
        public event DeadCountryEventHandler DeadCountry;
        
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
        /// 
        /// </summary>
        public void StartWar()
        {            
            if (CountryList.Count > 1)
            {
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
                if (CountryList[DefendingCountry].CheckIfCountryIsAlive() == false )
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
            CountryList.Add(new SouthAfrica());
            CountryList.Add(new UnitedKingdom());
            CountryList.Add(new UnitedStates());
        }
    }
}