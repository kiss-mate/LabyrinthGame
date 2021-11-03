﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthGame
{
    struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        //operator override
        public static Position operator +(Position p1, Position p2)
        {
            return new Position() { X = p1.X + p2.X, Y = p1.Y + p2.Y }; 
        }
    }
}
