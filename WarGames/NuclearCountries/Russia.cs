using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.NuclearCountries
{
    class Russia : Country
    {
        //const int xCordinate = 860;
        //const int yCordinate = 110;


        // Fullscreen
        const int xCordinate = 985;
        const int yCordinate = 135;

        public Russia()
            :base("Russia", xCordinate, yCordinate)
        { }
    }
}
