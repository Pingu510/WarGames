using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGames.NuclearCountries;

namespace WarGames
{
    public abstract class Country
    {
        // Theese count as read only and can only be set when initialised or in the ctor
        
        public string CountryName { get; }
        public int CordinateX { get; }
        public int CordinateY { get; }
        

        public int CountryEndurance { get; set; }
        public int Kills { get; set; }
        public int Assists { get; set; }
        
        public Country(string newCountryName, int xCordinate, int yCordinate)
        {
            CountryName = newCountryName;
            CordinateX = xCordinate;
            CordinateY = yCordinate;
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
