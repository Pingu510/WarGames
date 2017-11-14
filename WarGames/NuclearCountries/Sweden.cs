using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.NuclearCountries
{
    class Sweden : Countries
    {
        const int xCordinate = 615;
        const int yCordinate = 80;

        public Sweden() 
            : base("Sweden", xCordinate, yCordinate)
        { }
    }
}
