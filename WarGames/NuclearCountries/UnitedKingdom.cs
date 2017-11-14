using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.NuclearCountries
{
    class UnitedKingdom : Country
    {
        const int xCordinate = 560;
        const int yCordinate = 123;

        public UnitedKingdom()
            : base("United Kingdom", xCordinate, yCordinate)
        { }
    }
}
