using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Deck
    {
        public List<Card> CardDeck { get; set; }

        private const int NUMBER_OF_CARDS = 52;

        private string[] faces = {"Ace", "Duece", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                                "Jack", "Queen", "King"};
        private string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
        private int currentCard;
        private Random ranNum;


        public Deck()
        {
            CardDeck = GetListOfCards();

        }
        public List<Card> GetListOfCards()
        {
            List<Card> cards = new List<Card>();

            foreach (string suit in suits)
            {
                foreach (string face in faces)
                {
                    cards.Add(new Card(suit,face));
                }
            }

            return cards;
        }
        //public void Shuffle()
        //{
        //    currentCard = 0;
        //    for (int first = 0; first < deck.Length; first++)
        //    {
        //        int second = ranNum.Next(NUMBER_OF_CARDS);
        //        Card temp = deck[second];
        //        deck[first] = deck[second];
        //        deck[second] = temp;
        //    }
        //}
        //public Card DealCard()
        //{
        //    if (currentCard < deck.Length)
        //    {
        //        return deck[currentCard++];
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        public void PrintDeck()
        {
            foreach (Card c in CardDeck)
            {
                Console.WriteLine(c.ToString());
            }
        }
        
    }
}
