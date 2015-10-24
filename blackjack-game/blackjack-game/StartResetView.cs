using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_game
{
    public partial class StartResetView : UserControl
    {
        StartResetController _startResetController;
        PlayerController _playerController;

        public StartResetView(StartResetController _controller)
        {
            _startResetController = _controller;
            InitializeComponent();
        }

        private void StartResetView_Load(object sender, EventArgs e)
        {
            _playerController = new PlayerController(_startResetController);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _startResetController.StartGame(btnStart);
            _playerController.drawPlayerHand();
            //_playerController.updateMoney();
            //_playerController.updateKaarten();
            _playerController.getView()._lblMoney.Text = "Money: JOREN";
            _startResetController._cardDeckController.shuffleDeck();

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            _startResetController.ResetGame(btnStart);
            
        }
    }
}
