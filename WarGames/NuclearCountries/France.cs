using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.NuclearCountries
{
    class France : Country
    {
        const int xCordinate = 570;
        const int yCordinate = 140;

        public France()
            :base("France", xCordinate, yCordinate)
        { }
    }
}