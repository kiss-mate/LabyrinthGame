using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthGame
{
    struct Vector_2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        //operator override
        public static Vector_2D operator +(Vector_2D p1, Vector_2D p2)
        {
            return new Vector_2D() { X = p1.X + p2.X, Y = p1.Y + p2.Y }; 
        }
    }
}
