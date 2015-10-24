using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_game
{
  public class CardDeckModel
  {

    string[] arrCards = { "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "H10", "HJ", "HQ", "HK", "HA",
                          "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S10", "SJ", "SQ", "SK", "SA",
                          "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "R10", "RJ", "RQ", "RK", "RA",
                          "K2", "K3", "K4", "K5", "K6", "K7", "K8", "K9", "K10", "KJ", "KQ", "KK", "KA"};

    string[] shuffledDeck;
<<<<<<< HEAD:blackjack-game/blackjack-game/blackjack-game/CardDeckModel.cs
    


=======
>>>>>>> b0bbbec04703bb3d34d21ddc9029c45686ed6343:blackjack-game/blackjack-game/CardDeckModel.cs

    public string[] ArrCards
    {
      get { return arrCards; }
      set { arrCards = value; }
    }

    public string[] ShuffledDeck
    {
      get { return shuffledDeck; }
      set { shuffledDeck = value; }
    }
  }
}
