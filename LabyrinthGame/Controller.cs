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
            while(CheckGameState().Equals(State.PLAYER_INGAME))
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

        private State CheckGameState()
        {
            return State.PLAYER_INGAME;
        }

        private Vector_2D GetUserInput()
        {
            return new Vector_2D() { X = 0, Y = 0 };
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
