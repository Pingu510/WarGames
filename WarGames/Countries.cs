using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGames.NuclearCountries;

namespace WarGames
{
    public abstract class Countries
    {
        public List<Countries> CountryList = new List<Countries>();

        public string CountryName { get;  private set; }
        public int CountryEndurance { get; set; }
        public int Kills { get; set; }
        public int Assists { get; set; }

        Random random = new Random();

        public Countries(string newCountryName)
        {
            CountryName = newCountryName;
            CountryEndurance = 3;
            Kills = 0;
            Assists = 0;            
        }

        /// <summary>
        /// Starts the game
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

                // Checks if the defending Country died.
                if (CheckIfCountryIsAlive(CountryList[DefendingCountry]) == false)
                {
                    DeleteCountry(CountryList[DefendingCountry]);

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
        /// Skickar tbx ett random tal
        /// </summary>
        private int GetRandomNr()
        {
            return random.Next(0, CountryList.Count -1);
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
            CountryList.Add(new UnitedKingdom());
            CountryList.Add(new UnitedStates());
        }

        /// <summary>
        /// If the country still has endurance returns true.
        /// </summary>
        public bool CheckIfCountryIsAlive(Countries c)
        {
            if (c.CountryEndurance > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Deletes country from list
        /// </summary>
        private void DeleteCountry(Countries c)
        {
            CountryList.Remove(c);
        }
    }
}
