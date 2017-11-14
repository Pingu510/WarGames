using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.NuclearCountries
{
    class UnitedStates : Countries
    {
        const int xCordinate = 240;
        const int yCordinate = 175;

        public UnitedStates()
            :base("United States", xCordinate, yCordinate)
        { }
    }
}
