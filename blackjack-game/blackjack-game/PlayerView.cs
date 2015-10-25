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
    public partial class PlayerView : UserControl
    {
        PlayerController _playerController;

        public Label _lblMoney {
            get { return lblMoney; }
            set { lblMoney = value; }
        }

        public Label _lblKaarten
        {
            get { return lblKaarten; }
            set { lblKaarten = value; }
        }

        public Button _BtnDrawCard
        {
            get { return btnDrawCard; }
            set { btnDrawCard = value; }
        }

        public Button _BtnStop
        {
            get { return btnStop; }
            set { btnStop = value; }
        }
        
        public PlayerView(PlayerController _controller)
        {
            _playerController = _controller;
            InitializeComponent();
        }

        private void PlayerView_Load(object sender, EventArgs e)
        {
            btnDrawCard.Enabled = false;
            btnStop.Enabled = false;
        }

        private void btnDrawCard_Click(object sender, EventArgs e)
        {
            _playerController.getRandomCard("player");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_playerController._playerModel.CurrentDealerTotal < 16)
            {

            }
        }
    }
}
