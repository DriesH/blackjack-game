using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
  public class CardDeckController
  {

        CardDeckView _cardDeckView;
        public CardDeckModel _cardDeckModel;
        public int[] drawnCards;

        public CardDeckController()
        {
          _cardDeckView = new CardDeckView(this);
          _cardDeckModel = new CardDeckModel();
        }

        public CardDeckView getView()
        {
          return _cardDeckView;
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
                return _cardDeckModel.ArrCards[cardIndex];
              }
            }
          }
          drawnCards[0] = cardIndex;
            return _cardDeckModel.ArrCards[cardIndex];
        }

        public int getCardValue(string card, int currentTotal)
        {

          return 709;
        }

  }
}
