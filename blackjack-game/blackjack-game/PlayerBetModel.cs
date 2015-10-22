using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class PlayerBetModel
    {
        private int bettedMoney;

        public int BettedMoney
        {
            get
            {
                return bettedMoney;
            }
            set
            {
                bettedMoney = value;
            }
        }
    }
}
