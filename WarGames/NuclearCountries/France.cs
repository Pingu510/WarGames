using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.NuclearCountries
{
    class France : Country
    {
        const int xCordinate = 572;
        const int yCordinate = 186;

        public France()
            :base("France", xCordinate, yCordinate)
        { }
    }
}