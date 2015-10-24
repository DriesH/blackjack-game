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
    public int teller = 0;
    public int ElevenCounter = 0;
    public string[] shuffledDeck;
    public int totalValue = 0;
    public bool bust = false;

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
      return shuffledDeck;
    }

    public string getRandomCard()
    {
      string drawCard = _cardDeckModel.ArrCards[teller];
      Console.WriteLine(drawCard);
      getCardValue(drawCard);
      bustCheck();
      teller++;
      return drawCard;
    }

    public void resetDrawnCards()
    {
      teller = 0;
    }

    public void getCardValue(string card)
    {
      string lastChar = card.Substring(card.Length - 1, 1);

      switch (lastChar)
      {
        case "2":
          addCurrentTotal(2);
          break;
        case "3":
          addCurrentTotal(3);
          break;
        case "4":
          addCurrentTotal(4);
          break;
        case "5":
          addCurrentTotal(5);
          break;
        case "6":
          addCurrentTotal(6);
          break;
        case "7":
          addCurrentTotal(7);
          break;
        case "8":
          addCurrentTotal(8);
          break;
        case "9":
          addCurrentTotal(9);
          break;
        case "0":
          addCurrentTotal(10);
          break;
        case "J":
          addCurrentTotal(10);
          break;
        case "Q":
          addCurrentTotal(10);
          break;
        case "K":
          addCurrentTotal(10);
          break;
        case "A":
          if(totalValue <= 10)
          {
            addCurrentTotal(11);
            ElevenCounter++;
            break;
          }
          else
          {
            addCurrentTotal(1);
            break;
          };
        default:
          Console.WriteLine("Oops! Something went wrong ;(");
          break;
      }
    }

    public void addCurrentTotal(int addTotal)
    {
      totalValue += addTotal;
    }

    public int getCurrentTotal()
    {
      return totalValue;
    }

    public void bustCheck()
    {
      if (totalValue > 21)
      {
        if (ElevenCounter == 0)
        {
          Console.WriteLine("BUSTED NJIIIGAAAA");

          Console.WriteLine(totalValue);

          bust = true;
        }
        else
        {
          totalValue -= 10;
          ElevenCounter--;
          bustCheck();
        }
      }

      Console.WriteLine(totalValue);

    }
  }
}
