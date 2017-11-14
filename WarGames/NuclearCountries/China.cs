using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.NuclearCountries
{
    class China : Countries
    {
        const int xCordinate = 910;
        const int yCordinate = 210;

        public China()
            : base("China", xCordinate, yCordinate)
        { }
    }
}