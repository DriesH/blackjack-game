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
    public partial class StartResetView : UserControl
    {
        StartResetController _startResetController;

        public StartResetView(StartResetController _controller)
        {
            _startResetController = _controller;
            InitializeComponent();
        }

        private void StartResetView_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
          //shuffle deck/set boolean gamestarted on true/draw the player his first 2 cards
          _startResetController._cardDeckController.shuffle();
          _startResetController.StartGame(btnStart);
          _startResetController._playerController.drawPlayerHand();
        
          //set enabled
          _startResetController._cardDeckController.getView()._BtnDrawCard.Enabled = true;
          _startResetController._cardDeckController.getView()._BtnStop.Enabled = true;
          _startResetController._playerBetController.getView()._btnBet.Enabled = true;
          _startResetController._playerBetController.getView()._txtBetMoney.Enabled = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //set boolean gamestarted on false
            _startResetController.ResetGame(btnStart);

            //set disabled
            _startResetController._cardDeckController.getView()._BtnDrawCard.Enabled = false;
            _startResetController._cardDeckController.getView()._BtnStop.Enabled = false;
            _startResetController._playerBetController.getView()._btnBet.Enabled = false;
            _startResetController._playerBetController.getView()._txtBetMoney.Enabled = false;


        }
    }
}
