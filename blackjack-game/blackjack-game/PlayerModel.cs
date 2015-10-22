using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class PlayerModel
    {
        int currentMoney = 1000;

        public int CurrentMoney {
          get { return currentMoney; }   
          set { currentMoney = value; }
        }
    }
}
