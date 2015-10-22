using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class PlayerBetController
    {
        PlayerBetView _playerBetView;
        public PlayerBetModel _playerBetModel;

        public PlayerBetController()
        {
            _playerBetView = new PlayerBetView(this);
            _playerBetModel = new PlayerBetModel();
        }

        public PlayerBetView getView()
        {
            return _playerBetView;

        }


    }
}
