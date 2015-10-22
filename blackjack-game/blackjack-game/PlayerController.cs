using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class PlayerController
    {
        PlayerView _playerview;
        public PlayerModel _playermodel;

        public PlayerController() {
            _playerview = new PlayerView(this);
            _playermodel = new PlayerModel();
        }

    }
}
