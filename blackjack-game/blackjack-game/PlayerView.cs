﻿using System;
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

        public PlayerView(PlayerController _controller)
        {
            _playerController = _controller;
            InitializeComponent();
        }

        private void PlayerView_Load(object sender, EventArgs e)
        {
            

        }


    }
}
