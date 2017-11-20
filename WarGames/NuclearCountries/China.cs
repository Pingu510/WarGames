using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.NuclearCountries
{
    class China : Country
    {
        //const int xCordinate = 910;
        //const int yCordinate = 210;

        // Fullscreen
        const int xCordinate = 1090;
        const int yCordinate = 290;

        public China()
            : base("China", xCordinate, yCordinate)
        { }
    }
}