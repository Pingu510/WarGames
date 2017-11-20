using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.NuclearCountries
{
    class UnitedStates : Country
    {
        //const int xCordinate = 240;
        //const int yCordinate = 175;

        // Fullscreen
        const int xCordinate = 302;
        const int yCordinate = 250;


        public UnitedStates()
            :base("United States", xCordinate, yCordinate)
        { }
    }
}
