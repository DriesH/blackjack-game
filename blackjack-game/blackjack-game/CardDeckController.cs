using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class CardDeckController
    {
        CardDeckView _cardDeckView;
        public CardDeckModel _cardDeckModel;
        
        
        public CardDeckController()
        {
            _cardDeckView = new CardDeckView(this);
            _cardDeckModel = new CardDeckModel();
        }

        public CardDeckView getView()
        {
            return _cardDeckView;
        }

        public string[] shuffle()
        {
            Random rnd = new Random();
            _cardDeckModel.ArrCards = _cardDeckModel.ArrCards.OrderBy(x => rnd.Next()).ToArray();
            return _cardDeckModel.ShuffledDeck;
        }

        public string getRandomCard(string turn)
        {
            string drawCard = _cardDeckModel.ArrCards[_cardDeckModel.Teller];
            Console.WriteLine(drawCard);
            getCardValue(drawCard, turn);

            if (turn == "dealer")
            {
                bustCheck(_cardDeckModel.CurrentDealerTotal);
            }
            if (turn == "player")
            {
                bustCheck(_cardDeckModel.CurrentPlayerTotal);
            }

            _cardDeckModel.Teller++;
            return drawCard;
        }

        public void resetDrawnCards()
        {
            _cardDeckModel.Teller = 0;
        }

        public void getCardValue(string card, string turn)
        {
            string lastChar = card.Substring(card.Length - 1, 1);

            switch (lastChar)
            {
                case "2":
                    addCurrentTotal(2, turn);
                    break;
                case "3":
                    addCurrentTotal(3, turn);
                    break;
                case "4":
                    addCurrentTotal(4, turn);
                    break;
                case "5":
                    addCurrentTotal(5, turn);
                    break;
                case "6":
                    addCurrentTotal(6, turn);
                    break;
                case "7":
                    addCurrentTotal(7, turn);
                    break;
                case "8":
                    addCurrentTotal(8, turn);
                    break;
                case "9":
                    addCurrentTotal(9, turn);
                    break;
                case "0":
                    addCurrentTotal(10, turn);
                    break;
                case "J":
                    addCurrentTotal(10, turn);
                    break;
                case "Q":
                    addCurrentTotal(10, turn);
                    break;
                case "K":
                    addCurrentTotal(10, turn);
                    break;
                case "A":
                    if (turn == "dealer")
                    {
                        if (_cardDeckModel.CurrentDealerTotal <= 10)
                        {
                            addCurrentTotal(11, turn);
                            _cardDeckModel.ElevenCounter++;
                            break;
                        }
                        else
                        {
                            addCurrentTotal(1, turn);
                            break;
                        }
                    }
                    else
                    {
                        if (_cardDeckModel.CurrentPlayerTotal <= 10)
                        {
                            addCurrentTotal(11, turn);
                            _cardDeckModel.ElevenCounter++;
                            break;
                        }
                        else
                        {
                            addCurrentTotal(1, turn);
                            break;
                        }
                    };
                default:
                    Console.WriteLine("Oops! Something went wrong ;( en ruben is nog steeds lelijk");
                    break;
            }
        }

        public void addCurrentTotal(int addTotal, string turn)
        {
            if (turn == "dealer")
            {
                _cardDeckModel.CurrentDealerTotal += addTotal;
            }

            if (turn == "player")
            {
                _cardDeckModel.CurrentPlayerTotal += addTotal;
            }
        }

        public int getCurrentTotal()
        {
            return _cardDeckModel.TotalValue;
        }

        public void bustCheck(int value)
        {
            if (value > 21)
            {
                if (_cardDeckModel.ElevenCounter == 0)
                {
                    Console.WriteLine("BUSTED NJIIIGAAAA");

                    Console.WriteLine(value);

                    _cardDeckModel.IsBust = true;
                }
                else
                {
                    value -= 10;
                    _cardDeckModel.ElevenCounter--;
                    bustCheck(value);
                }
            }
            Console.WriteLine(value);
        }

        public void clearValues()
        {
            _cardDeckModel.CurrentDealerTotal = 0;
            _cardDeckModel.CurrentPlayerTotal = 0;

        }
    }
}
