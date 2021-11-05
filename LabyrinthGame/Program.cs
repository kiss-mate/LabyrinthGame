using System;

namespace LabyrinthGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameModel gameModel = new GameModel();
            gameModel.LoadData("map.txt");

            ConsoleRenderer gameRenderer = new ConsoleRenderer(gameModel);

            Controller gameControl = new Controller(gameModel, gameRenderer);
            gameControl.run();
        }
    }
}
