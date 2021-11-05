using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthGame
{
    internal class Map
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Item> Items { get; set; }

        public Map()
        {
            //Width = width;
            //Height = height;
            Items = new List<Item>();
        }
        
    }
}
