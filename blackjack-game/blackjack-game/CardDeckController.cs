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
        public List<int> drawnCards = new List<int>();

        public CardDeckController()
        {
            _cardDeckView = new CardDeckView(this);
            _cardDeckModel = new CardDeckModel();
        }

        public CardDeckView getView()
        {
            return _cardDeckView;
        }

        //********************STATIC HELPER CLASS************************//


        public static class StaticRandom
        {
            private static int seed;

            private static ThreadLocal<Random> threadLocal = new ThreadLocal<Random>
                (() => new Random(Interlocked.Increment(ref seed)));

            static StaticRandom()
            {
                seed = Environment.TickCount;
            }

            public static Random Instance { get { return threadLocal.Value; } }
        }


        //****************************************************************//


        public string getRandomCard()
        {

            int cardIndex = StaticRandom.Instance.Next(0, 52);
            int sizeOfDrawnCards = drawnCards.Count();


            for (int i = 0; i < sizeOfDrawnCards; i++)
            {
                if (drawnCards.Contains(cardIndex))
                {
                    drawnCards.Add(cardIndex);
                    getRandomCard();
                }
                else
                {
                    drawnCards.Add(cardIndex);
                    return _cardDeckModel.ArrCards[cardIndex];
                }
            }
            drawnCards.Add(cardIndex);
            return _cardDeckModel.ArrCards[cardIndex];
        }

        public void resetDrawnCards()
        {
            drawnCards.Clear();
        }

        public int getCardValue(string card, int currentTotal)
        {
            string lastChar = card.Substring(card.Length - 1, 1);

            switch (lastChar)
            {
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "0":
                    return 10;
                case "J":
                    return 10; ;
                case "Q":
                    return 10;
                case "K":
                    return 10;
                case "A":
                    return 11;
                default:
                    Console.WriteLine("Oops! Something went wrong ;(");
                    return 0;
            }
        }


    }
}