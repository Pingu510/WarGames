using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGames.NuclearCountries;

namespace WarGames
{
    class CountryHandler
    {
        public List<Countries> CountryList = new List<Countries>();
        Random random = new Random();

        
        /// <summary>
        /// Starts the game, creates the list and starts the war.
        /// </summary>
        public void StartGame()
        {
            CreateAllCountriesAnew();
            StartWar();
            //FIXA - Spelet är klart här, visa Endscreen eller starta om
        }

        /// <summary>
        /// Runs untill all countries are dead.
        /// </summary>
        private void StartWar()
        {
            // While there are countries still alive in the list
            while (CountryList.Count > 0)
            {
                //FIXA - Någon sorts timer här 

                //FIXA - Ska turordningen vara random eller ej?
                int AttackingCountry = GetRandomNr();
                int DefendingCountry = GetRandomNr();


                NukeCountry(DefendingCountry);
                // FIXA - Event som triggar attack animation

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
            }
        }

        /// <summary>
        /// Attacks the country and takes away 1 endurance
        /// </summary>
        private void NukeCountry(int DefendingCountry)
        {
            CountryList[DefendingCountry].CountryEndurance -= 1;
        }


        /// <summary>
        /// Deletes country from list
        /// </summary>
        private void DeleteCountry(Countries c)
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
