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
        public PlayerModel _playerModel;

        public PlayerController()
        {
            _playerView = new PlayerView(this);
            _playerModel = new PlayerModel();

        }

        public PlayerView getView()
        {
            return _playerView;
        }

        public void updateMoney() {
           

        }

    }
}
