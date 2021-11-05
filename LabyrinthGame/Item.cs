using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthGame
{
    internal class Item
    {
        public Vector_2D Position { get; set; }
        public ItemType Type { get; set; }

        public Item(Vector_2D pos, ItemType type)
        {
            Position = pos;
            Type = type;
        }
    }
}
