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
        
        public string CountryName { get;  private set; }
        public int CountryEndurance { get; set; }
        public int Kills { get; set; }
        public int Assists { get; set; }

        

        public Countries(string newCountryName)
        {
            CountryName = newCountryName;
            CountryEndurance = 3;
            Kills = 0;
            Assists = 0;            
        }
        

        /// <summary>
        /// If the country still has endurance returns true.
        /// </summary>
        public bool CheckIfCountryIsAlive()
        {
            if (CountryEndurance > 0)
            {
                return true;
            }
            return false;
        }

    }
}
