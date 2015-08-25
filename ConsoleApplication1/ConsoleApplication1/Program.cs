using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.PrintDeck();
            //     deck.DeleteCard("Hearts", "Five");
            //    deck.PrintDeck();
            deck.Shuffle();
            //    deck.PrintDeck();
            Console.Clear();
            int y = 0;
            while (y < 649739) {
            deck.RealShuffle();
            for (int x = 0; x < 5; x++) { 
            deck.DealCard();
            
                    y++;
                }
                deck.CheckForRoyalInSpades();
                deck.CheckForRoyalInHearts();
                deck.CheckForRoyalInDiamonds();
                deck.CheckForRoyalInClubs();
                deck = new Deck();
            }
        }
    }
}
