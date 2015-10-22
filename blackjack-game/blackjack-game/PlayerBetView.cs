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
    public partial class PlayerBetView : UserControl
    {
        PlayerBetController _playerBetController;
        
        public PlayerBetView(PlayerBetController _controller)
        {
            _playerBetController = _controller;
            InitializeComponent();
        }

        private void PlayerBetView_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            _playerBetController.Bet(txtBetMoney);
        }

        private void txtBetMoney_Click(object sender, EventArgs e)
        {
            _playerBetController.ClearTxtBox(txtBetMoney);
        }
    }
}
