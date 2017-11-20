using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.NuclearCountries
{
    class Sweden : Country
    {
        //const int xCordinate = 615;
        //const int yCordinate = 80;

        // Fullscreen
        const int xCordinate = 742;
        const int yCordinate = 125;

        public Sweden() 
            : base("Sweden", xCordinate, yCordinate)
        { }
    }
}
