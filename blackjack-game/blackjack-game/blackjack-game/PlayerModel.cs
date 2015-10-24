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
        string[] currentHand = new string[2];

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

        public string[] CurrentHand
        {
            get
            {
                return currentHand;
            }
            set
            {
                currentHand = value;
            }
        }
    }
}
