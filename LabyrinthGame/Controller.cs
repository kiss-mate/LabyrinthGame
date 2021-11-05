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
        //TODO ViewModel

        public Controller(GameModel gameModel)
        {
            this.gameModel = gameModel;
            //TODO ViewModel
        }

        public void run()
        {
            while(gameModel.State.Equals(State.PLAYER_INGAME))
            {
                //render
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
            throw new NotImplementedException();
        }

        //private State CheckGameState()
        //{
        //    return State.PLAYER_INGAME;
        //}

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
            throw new NotImplementedException();
        }

        private void UpdatePlayerState()
        {
            return;
        }

        private bool CheckCollision(Vector_2D step)
        {
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
