using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthGame
{
    internal class Player
    {
        public Vector_2D Position { get; set; }
        public int Health { get; set; }
        public char Avatar { get; set; }

        public Player()
        {
            Health = 100;
        }
    }
}
