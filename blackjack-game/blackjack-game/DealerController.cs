using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class DealerController
    {
        public DealerModel _dealerModel;
        DealerView _dealerView;
        CardDeckController _cardDeckController;

        public DealerController(CardDeckController _cdController)
        {
            _dealerModel = new DealerModel();
            _dealerView = new DealerView(this);
            _cardDeckController = _cdController;

        }

        public DealerView getView()
        {
            return _dealerView;
        }

        public void drawDealerHand()
        {
            for (int counter = 0; counter < 2; counter++)
            {
                _dealerModel.DealerHand[counter] = _cardDeckController.getRandomCard("dealer");
            }
        }
    }
}