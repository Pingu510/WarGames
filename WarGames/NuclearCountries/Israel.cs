﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames.NuclearCountries
{
    class Israel : Country
    {
        const int xCordinate = 685;
        const int yCordinate = 190;

        public Israel()
            :base("Israel", xCordinate, yCordinate)
        { }
    }
}
