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
            Console.WriteLine("Before shuffle");
            for (int i = 0; i < 52; i++)
            {
                Console.Write("|0,-19| " + deck.DealCard());
                if ((i + 1) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
            
            deck.Shuffle();
            Console.WriteLine("After shuffle");
            for (int i = 0; i < 52; i++)
            {
                Console.Write("|0,-19| " + deck.DealCard());
                if ((i + 1) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
