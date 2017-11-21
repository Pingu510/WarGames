using System;
using System.Collections.Generic;
using System.Drawing;
using WarGames.NuclearCountries;

namespace WarGames
{
    class CountryHandler
    {
        // Defines how the method should look, reference to a function that looks like it
        public delegate void NukeCountryEventHandler(object source, EventArgs args);
        public delegate void DeadCountryEventHandler(object source, IntEventArgs args);

        // Event based on the eventhandler/delegate
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
            //StartWar();
        }
        
        /// <summary>
        /// Does the logic of attacking and assigning points
        /// </summary>
        public void StartWar()
        {            
            if (CountryList.Count > 1)
            {
                int _attackingCountry = GetRandomNr();
                int _defendingCountry = GetRandomNr();

                while(_attackingCountry == _defendingCountry)
                {
                    //if (CountryList.Count > 2)
                        _defendingCountry = GetRandomNr();
                    //else if (AttackingCountry == 1)
                    //    DefendingCountry = 0;
                    //else
                    //    DefendingCountry = 1;
                }

                CurrentAttkCountry = _attackingCountry;
                CurrentDeffCountry = _defendingCountry;

                NukeCountry(_defendingCountry);

                CurrentEndurance = CountryList[_defendingCountry].CountryEndurance;

                // Checks if the defending Country died.
                if (CountryList[_defendingCountry].CheckIfCountryIsAlive() == false )
                {
                    // Gives a kill point to the last attacking country
                    CountryList[_attackingCountry].Kills += 1;
                }
                else
                {
                    CountryList[_attackingCountry].Assists += 1;
                }

                // Trigger events
                OnNukeCountry();
                OnDeadCountry();
            }
        }
        
        /// <summary>
        /// Takes away 1 endurance from the country
        /// </summary>
        private void NukeCountry(int DefendingCountry)
        {
            CountryList[DefendingCountry].CountryEndurance -= 1;            
        }

        /// <summary>
        /// Checks if there are any subscribers to the event, then triggers the event
        /// </summary>
        protected virtual void OnNukeCountry()
        {
            if (CountryNuked != null)
                CountryNuked(this, EventArgs.Empty);
        }

        /// <summary>
        /// Checks if there are any subscribers to the event, then triggers the event
        /// </summary>
        protected virtual void OnDeadCountry()
        {
            if (DeadCountry != null)
            {
                DeadCountry(this, new IntEventArgs() { CountryID = CurrentDeffCountry });
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
        /// Sends back a renadom to chose who attacks who.
        /// </summary>
        private int GetRandomNr()
        {
            return random.Next(0, CountryList.Count);
        }

        /// <summary>
        /// Clears and the adds country objects to Countrylist
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