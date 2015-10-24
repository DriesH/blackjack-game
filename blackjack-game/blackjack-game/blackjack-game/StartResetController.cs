using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_game
{
    public class StartResetController
    {
        StartResetView _startResetView;
        public CardDeckController _cardDeckController;
        public StartResetModel _startResetModel;
        public PlayerController _playerController;
        public PlayerBetController _playerBetController;

        public StartResetController(CardDeckController _cdController, PlayerController _pController, PlayerBetController _pbController)
        {
            _cardDeckController = _cdController;
            _startResetView = new StartResetView(this);
            _startResetModel = new StartResetModel();
            _playerController = _pController;
            _playerBetController = _pbController;
        }

        public StartResetView getView()
        {
            return _startResetView;
        }

        void Clearlabels()
        {
            _playerController.getView()._lblMoney.Text = "Money: ";
            _playerController.getView()._lblKaarten.Text = "Kaarten: ";

        }


        public void StartGame(Button start)
        {
            //init
            string[] currentHand = _playerController._playerModel.CurrentHand;
            int currentMoney = _playerController._playerModel.CurrentMoney;
            Clearlabels();

            //set vars at start
            _startResetModel.GameStarted = true;
            start.Visible = false;
            _playerController._playerModel.CurrentMoney = 1000;

            //display the vars in labels           
            _playerController.getView()._lblMoney.Text += currentMoney.ToString();

            for (int i = 0; i < currentHand.Length; i++) {
                _playerController.getView()._lblKaarten.Text += currentHand[i];
            }

        }

        public void ResetGame(Button start)
        {
            if (start.Visible == true)
            {
                return;
            }
            else
            {
                _playerController.getView()._lblMoney.Text = "Money: ";
                _playerController.getView()._lblKaarten.Text = "Kaarten: ";
                _startResetModel.GameStarted = false;
                start.Visible = true;
                _cardDeckController.resetDrawnCards();
            }
        }
    }
}
