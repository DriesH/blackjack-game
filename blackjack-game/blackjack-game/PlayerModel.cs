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
        string[] currentPlayerHand = new string[11];

        public int CurrentMoney
        {
            get
            {
                return currentMoney;
            }   
            set
            {
                currentMoney = value;
            }
        }

        public string[] CurrentPlayerHand
        {
            get
            {
                return currentPlayerHand;
            }
            set
            {
                currentPlayerHand = value;
            }
        }
    }
}
