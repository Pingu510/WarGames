using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.NuclearCountries
{
    class Pakistan : Countries
    {
        const int xCordinate = 790;
        const int yCordinate = 200;

        public Pakistan()
            :base("Pakistan", xCordinate, yCordinate)
        { }
    }
}
