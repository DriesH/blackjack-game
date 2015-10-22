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
        public Label _lblKaarten = new Label();
        public Label _lblMoney = new Label();

        public PlayerView(PlayerController _controller)
        {
            _playerController = _controller;
            InitializeComponent();
        }

        private void PlayerView_Load(object sender, EventArgs e)
        {
            _playerController.updateMoney();
            lblMoney.Text = _lblMoney.Text;
            _playerController.updateKaarten();

        }


    }
}
