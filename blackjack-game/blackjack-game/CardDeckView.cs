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
  public partial class CardDeckView : UserControl
  {
    CardDeckController _cardDeckController;

    public CardDeckView(CardDeckController _controller)
    {
      InitializeComponent();
      _cardDeckController = _controller;
    }

    private void btnHit_Click(object sender, EventArgs e)
    {
      _cardDeckController.getRandomCard();
    }
  }
}
