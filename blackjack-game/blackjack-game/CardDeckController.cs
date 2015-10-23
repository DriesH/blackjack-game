using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
  public class CardDeckController
  {
        static int seeder = 0;
        CardDeckView _cardDeckView;
        public CardDeckModel _cardDeckModel;
        public List<int> drawnCards = new List<int>();

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
            Random rnd = new Random(++seeder);
            int cardIndex = rnd.Next(0, 52);
            int sizeOfDrawnCards = drawnCards.Count();
                               
            for (int i = 0; i < sizeOfDrawnCards; i++)
            {
                if (drawnCards.Contains(cardIndex))
                {
                    drawnCards.Add(cardIndex);
                    getRandomCard();
                }
                else
                {
                    drawnCards.Add(cardIndex);
                    return _cardDeckModel.ArrCards[cardIndex];
                }
            }
            drawnCards.Add(cardIndex);
            return _cardDeckModel.ArrCards[cardIndex];
        }

        public void resetDrawnCards()
        {
            drawnCards.Clear();
        }

        public int getCardValue(string card, int currentTotal)
        {
            return 709;
        }
  }
}
