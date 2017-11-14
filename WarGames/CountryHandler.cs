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

namespace WarGames
{
    class CountryHandler
    {

        //buildItem.SetMetadata("CopyToOutputDirectory", "Always");
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
        ///  Seeting for changeing attack frequence
        /// </summary>
        
        //public AttackTime(int secondinterval = 1000)
        //{
        //    timer = new Timer();
        //    timer.Interval = secondinterval;
        //    timer.Elapsed += Timer_Elapsed;


        //}

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
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"NuclearCountries/");
                //Path.GetDirectoryName(Application.ExecutablePath);//Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"NuclearCountries/");
            
            //string[] files = File.ReadAllLines(path);
            string[] fileEntries = Directory.GetFiles(path);
            foreach (string fileName in fileEntries)
            {
                Debug.WriteLine(fileName);
                string[] words = fileName.Split('.');
                string country = words[0];
                var t = country.GetType();
                //CountryList.Add(new country)
            }

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
