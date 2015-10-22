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
     
        public DealerController()
        {
            _dealerModel = new DealerModel();
            _dealerView = new DealerView();
            _cardDeckController = new CardDeckController();
        }

        public DealerView getView()
        {
            return _dealerView;
        }

        public void GiveDealerCards()
        {
            _cardDeckController.getRandomCard();

        }
        
       
    }
}
