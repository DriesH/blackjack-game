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
  public partial class CardDeckView : UserControl
  {
    CardDeckController _cardDeckController;

    public Button _BtnDrawCard
    {
        get
        {
            return btnDrawCard;
        }
        set
        {
            btnDrawCard = value;
        }
    }

    public Button _BtnStop
    {
        get
        {
            return btnStop;
        }
        set
        {
            btnStop = value;
        }
    }



        public CardDeckView(CardDeckController _controller)
    {
      _cardDeckController = _controller;
      InitializeComponent();
    }

    private void CardDeckView_Load(object sender, EventArgs e)
    {
          btnDrawCard.Enabled = false;
          btnStop.Enabled = false;
    }

    private void btnDrawCard_Click(object sender, EventArgs e)
    {
            _cardDeckController.getRandomCard();
            //_cardDeckController.bustCheck();
            

        }

    private void btnStop_Click(object sender, EventArgs e)
    {

    }
  }
}

