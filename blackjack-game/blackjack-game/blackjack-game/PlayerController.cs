using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class PlayerController
    {
        PlayerView _playerView;
        CardDeckController _cardDeckController;
        StartResetController _startResetController;
        public PlayerModel _playerModel;

        //public PlayerController()
        //{
        //    _cardDeckController = new CardDeckController();
        //    _playerView = new PlayerView(this);
        //    _playerModel = new PlayerModel();
        //}

        public PlayerController(StartResetController _srController, CardDeckController _cdController )
        {
            _cardDeckController = _cdController;
            _playerView = new PlayerView(this);
            _playerModel = new PlayerModel();
            _startResetController = _srController;
        }

        public PlayerView getView()
        {
            return _playerView;
        }

        public void updateMoney()
        {
            _playerView._lblMoney.Text = "Money: " + _playerModel.CurrentMoney.ToString();
        }

        public void updateKaarten()
        {
            _playerView._lblKaarten.Text = "Kaarten: " + _cardDeckController.getRandomCard();
        }

        public void drawPlayerHand()
        {
            for (int counter = 0; counter < 2; counter++)
            {
                _playerModel.CurrentHand[counter] = _cardDeckController.getRandomCard();
            }
        }

    }
}
