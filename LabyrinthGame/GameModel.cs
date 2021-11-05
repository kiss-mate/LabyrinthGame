using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LabyrinthGame
{
    internal class GameModel
    {
        public Player Player { get; set; }
        public Map Map { get; set; }
        public State State { get; set; }

        public GameModel(Player player, Map map)
        {
            Player = player;
            Map = map;
            State = State.PLAYER_INGAME;
        }

        public void LoadData(string path)
        {
            string[] mapData = File.ReadAllLines(path);
            Map.Height = mapData.Length;
            Map.Width = mapData[0].Length;
            for (int y = 0; y < mapData.Length; y++)
            {
                for (int x = 0; x < mapData[y].Length; x++)
                {
                    char current = mapData[y][x];
                    if (current == 'w') Map.Items.Add(new Item(new Vector_2D() { X = x, Y = y }, ItemType.WALL));
                    if (current == 'a') Map.Items.Add(new Item(new Vector_2D() { X = x, Y = y }, ItemType.APPLE));
                    if (current == 'f') Map.Items.Add(new Item(new Vector_2D() { X = x, Y = y }, ItemType.FIRE));
                    if (current == 'X') Map.Items.Add(new Item(new Vector_2D() { X = x, Y = y }, ItemType.EXIT));
                    if (current == 'P') Player.Position = new Vector_2D() { X = x, Y = y };


                }
            }
        }
    }
}
