using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthGame
{
    internal class Item
    {
        public Position Position { get; set; }
        public ItemType Type { get; set; }

        public Item(Position pos, ItemType type)
        {
            Position = pos;
            Type = type;
        }
    }
}
