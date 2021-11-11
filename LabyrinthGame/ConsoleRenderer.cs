using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthGame
{
    class ConsoleRenderer
    {
        GameModel model;

        public ConsoleRenderer(GameModel model)
        {
            this.model = model;
        }

        public void Render()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            for (int y = 0; y < model.Map.Height; y++)
            {
                for (int X = 0; X < model.Map.Width; X++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();

            Console.SetCursorPosition(0, model.Map.Height+2);
            Console.WriteLine("Heath: " + model.Player.Health);



            //draw items
            foreach(Item item in model.Map.Items)
            {
                int x = item.Position.X;
                int y = item.Position.Y;
                Console.SetCursorPosition(x, y);
                if(item.Type == ItemType.WALL)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Write(" ");
                    Console.ResetColor();
                }
                if (item.Type == ItemType.APPLE)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("A");
                    Console.ResetColor();
                }
                if (item.Type == ItemType.FIRE)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("F");
                    Console.ResetColor();
                }
                if (item.Type == ItemType.EXIT)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("X");
                    Console.ResetColor();
                }
            }

            //player
            {
                int x = model.Player.Position.X;
                int y = model.Player.Position.Y;
                Console.SetCursorPosition(x, y);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("O");
                Console.ResetColor();
            }
        }
    }
}
