using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class StartResetModel
    {
        bool gameStarted = false;

        public bool GameStarted
        {
            get
            {
                return gameStarted;
            }
            set
            {
                gameStarted = value;
            }
        }
    }
}
