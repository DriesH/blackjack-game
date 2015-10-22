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
        PlayerController _playercontroller;

        public PlayerView(PlayerController _controller) {
            _playercontroller = _controller;
        }

        public PlayerView()
        {
            InitializeComponent();
        }

        private void PlayerView_Load(object sender, EventArgs e)
        {

        }
    }
}
