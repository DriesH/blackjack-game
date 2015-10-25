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
        PlayerController _playerController;

        public DealerController(PlayerController _pController)
        {
            _dealerModel = new DealerModel();
            _dealerView = new DealerView(this);
            _playerController = _pController;
            

        }

        public DealerView getView()
        {
            return _dealerView;
        }

        public void drawDealerHand()
        {
            for (int counter = 0; counter < 2; counter++)
            {
                _dealerModel.DealerHand[counter] = _playerController.getRandomCard("dealer");
            }
        }
    }
}