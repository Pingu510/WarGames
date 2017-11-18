using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGames
{
    public class PointEventArgs :EventArgs
    {
        public Point  HitPoint { get; set; }
    }
}
