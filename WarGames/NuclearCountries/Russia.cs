using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.NuclearCountries
{
    class Russia : Country
    {
        const int xCordinate = 860;
        const int yCordinate = 110;

        public Russia()
            :base("Russia", xCordinate, yCordinate)
        { }
    }
}
