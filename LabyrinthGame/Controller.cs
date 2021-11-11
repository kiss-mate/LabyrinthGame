using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthGame
{
    internal class Controller
    {
        GameModel gameModel;
        ConsoleRenderer gameRenderer;
        //TODO ViewModel

        public Controller(GameModel gameModel, ConsoleRenderer consoleRenderer)
        {
            this.gameModel = gameModel;
            this.gameRenderer = consoleRenderer;
            //TODO ViewModel
        }

        public void run()
        {
            
            while(gameModel.State.Equals(State.PLAYER_INGAME))
            {
                gameRenderer.Render();
                Vector_2D step = GetUserInput();
                if(!CheckCollision(step))
                {
                    MovePlayer(step);
                    UpdatePlayerState();    
                }
                UpdateGameState();
            }
        }

        private void UpdateGameState()
        {
            Vector_2D currentPos = gameModel.Player.Position;
            foreach (Item item in gameModel.Map.Items)
            {
                //polimorf viselkedés utánzása, szorosan kötött...
                if (item.Position == currentPos && item.Type.Equals(ItemType.EXIT))
                {
                    gameModel.State = State.PLAYER_WON;
                }
            }

            if(gameModel.Player.Health == 0)
            {
                gameModel.State = State.PLAYER_LOST;
            }
        }

        private Vector_2D GetUserInput()
        {
            ConsoleKey keyPressed = Console.ReadKey().Key;
            switch (keyPressed)
            {
                case ConsoleKey.Escape:
                    gameModel.State = State.PLAYER_LOST;
                    return new Vector_2D() { X = 0, Y = 0 };
                    break;
                case ConsoleKey.LeftArrow:
                    return new Vector_2D() { X = -1, Y = 0 };
                    break;
                case ConsoleKey.UpArrow:
                    return new Vector_2D() { X = 0, Y = -1 };
                    break;
                case ConsoleKey.RightArrow:
                    return new Vector_2D() { X = 1, Y = 0 };
                    break;
                case ConsoleKey.DownArrow:
                    return new Vector_2D() { X = 0, Y = 1 };
                    break;
                default:
                    return new Vector_2D() { X = 0, Y = 0 };
                    break;
            }

            
        }

        private void MovePlayer(Vector_2D step)
        {
            gameModel.Player.Position += step;
        }

        private void UpdatePlayerState()
        {
            Vector_2D currentPos = gameModel.Player.Position;
            foreach (Item item in gameModel.Map.Items)
            {
                //polimorf viselkedés utánzása, szorosan kötött...
                if (item.Position == currentPos)
                {
                    if (item.Type.Equals(ItemType.WALL))
                    {
                        //not possible
                    }
                    if (item.Type.Equals(ItemType.APPLE))
                    {
                        gameModel.Player.Health = Math.Min(100, gameModel.Player.Health + 25);
                        gameModel.Map.Items.Remove(item);
                        break;
                    }
                    if (item.Type.Equals(ItemType.FIRE))
                    {
                        gameModel.Player.Health = Math.Max(0, gameModel.Player.Health - 50);
                    }
                }
            } 
        }

        private bool CheckCollision(Vector_2D step)
        {
            Vector_2D target = gameModel.Player.Position + step;
            foreach(Item item in gameModel.Map.Items)
            {
                //polimorf viselkedés utánzása, szorosan kötött...
                if (item.Position == target)
                {
                    if (item.Type.Equals(ItemType.WALL))
                    {
                        return true;
                    }
                    if (item.Type.Equals(ItemType.APPLE))
                    {
                        return false;
                    }
                    if (item.Type.Equals(ItemType.FIRE))
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        private bool Collision_FIRE()
        {
            throw new NotImplementedException();
        }

        private bool Collision_APPLE()
        {
            throw new NotImplementedException();
        }

        private bool Collision_WALL()
        {
            throw new NotImplementedException();
        }
    }
}
