using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthGame
{
    internal class GameModel
    {
        public Player Player { get; set; }
        public Map Map { get; set; }

        public GameModel(Player player, Map map)
        {
            Player = player;
            Map = map;
        }
    }
}
