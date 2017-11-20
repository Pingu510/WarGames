using System;

namespace WarGames
{
    public class IntEventArgs : EventArgs
    {
        // The listindex of teh current defending country
        public int CountryID { get; set; }
    }
}
