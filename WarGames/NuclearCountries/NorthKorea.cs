using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.NuclearCountries
{
    class NorthKorea : Country
    {
        const int xCordinate = 965;
        const int yCordinate = 175;

        public NorthKorea()
            :base("North Korea", xCordinate, yCordinate)
        { }
    }
}
