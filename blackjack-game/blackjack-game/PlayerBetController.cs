using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_game
{
    public class PlayerBetController
    {
        PlayerBetView _playerBetView;
        public PlayerBetModel _playerBetModel;
        PlayerController _playerController;
        
        public PlayerBetController(PlayerController _controller)
        {
            _playerBetView = new PlayerBetView(this);
            _playerBetModel = new PlayerBetModel();
            _playerController = _controller;
        } 
        
        public PlayerBetView getView()
        {
            return _playerBetView;
        }

        public void Bet(TextBox txtBox)
        {
            if ( txtBox.Text == "" )
            {
                txtBox.Text = "Please put in a value!";
                return;
            }
            else
            {
                int betMoneyValue = int.Parse(txtBox.Text);

                if (betMoneyValue < _playerController._playerModel.CurrentMoney)
                { 
                    _playerBetModel.BettedMoney = betMoneyValue;
                    _playerController._playerModel.CurrentMoney -= betMoneyValue;
                    _playerController.updateMoney();
                }
                else
                {
                    txtBox.Text = "Not enough money!";
                    return;
                }
            }
        }

        public void ClearTxtBox(TextBox txtBox)
        {
            txtBox.Clear();
        }

    }
}
