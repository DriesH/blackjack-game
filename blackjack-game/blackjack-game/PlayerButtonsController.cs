using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
  public class PlayerButtonsController
  {

     PlayerButtonsView _playerButtonsView;
        public PlayerButtonsModel _playerButtonsModel;
        public int[] drawnCards;

        public PlayerButtonsController()
        {
          _playerButtonsView = new PlayerButtonsView(this);
          _playerButtonsModel = new PlayerButtonsModel();
        }

        public PlayerButtonsView getView()
        {
          return _playerButtonsView;
        }

        public string getRandomCard()
        {
          Random rnd = new Random();
          int cardIndex = rnd.Next(0, 52);

          if (drawnCards != null)
          {
            for (int i = 0; i < drawnCards.Length; i++)
            {
              if (drawnCards.Contains(cardIndex))
              {
                drawnCards[drawnCards.Length] = cardIndex;
                getRandomCard();
              }
              else
              {
                drawnCards[drawnCards.Length] = cardIndex;
                return _playerButtonsModel.ArrCards[cardIndex];
              }
            }
          }
          drawnCards[0] = cardIndex;
          return _playerButtonsModel.ArrCards[cardIndex];
        }

        public int getCardValue(string card, int currentTotal)
        {

          return 709;
        }

  }
}
