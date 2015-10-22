using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class StartResetController
    {
        StartResetView _startResetView;
        public StartResetModel _StartResetModel;

        public StartResetController()
        {
            _startResetView = new StartResetView(this);
            _StartResetModel = new StartResetModel();
        }

        public StartResetView getView()
        {
            return _startResetView;
        }



    }
}
