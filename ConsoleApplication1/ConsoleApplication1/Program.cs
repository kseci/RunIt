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
            for (int x = 0; x < 50; x++) { 
            deck.DealCard();
            }
            Console.WriteLine("------DISCARDS-----");
            deck.PrintDiscards();
            Console.WriteLine("------DISCARDS-----");
            deck.CheckForRoyal();
        }
    }
}
