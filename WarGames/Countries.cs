using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames
{
    public abstract class Countries
    {
       

        protected string _countryName { get; set; }
        protected int _countryEndurance { get; set; }

        protected int _health = 3;
       
        public virtual string GetCountryName()
        {
            return _countryName;
        }

        public virtual int GetCountryEndurance()
        {
            return _countryEndurance;
        }

        public Countries(string CountryName, int CountryEndurance)
        {
            _countryName = CountryName;
            _countryEndurance = CountryEndurance;

          }  
    }
}
