using System;
using System.Threading;
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
            
            
            ThreadManager tm = new ThreadManager();
            tm.go();
            Deck deck = new Deck();
            Deck test = new Deck();
            Thread okay = new Thread(new ThreadStart(deck.CheckForRoyal));
            Console.WriteLine("---------STARTING THREAD------");
            okay.Start();
            Console.WriteLine("---------SPINNING-----");
            Console.WriteLine("---------SPINNING-----");
            while (!okay.IsAlive) ;
            Console.WriteLine("---------Thread sleep-----");
            Console.WriteLine("---------Thread sleep-----");
            Thread.Sleep(100);
            Console.WriteLine("---------oThread abort-----");
            Console.WriteLine("---------oThread abort-----");
            okay.Abort();
            Console.WriteLine("---------oThread join-----");
            Console.WriteLine("---------oThread join-----");
            okay.Join();

            Console.WriteLine();
            Console.WriteLine("Alpha.Beta has finished");

            try
            {
                Console.WriteLine("Try to restart the Alpha.Beta thread");
                okay.Start();
            }
            catch (ThreadStateException)
            {
                Console.Write("ThreadStateException trying to retard Alpha.Beta");
                Console.WriteLine("Expected since aborted threads cannot be restarted");
            }


            //Console.WriteLine("AAAA");
            //while (!okay.IsAlive) ;

            //Thread.Sleep(1);

            //okay.Abort();

            //okay.Join();

            //Console.WriteLine();
            //Console.WriteLine("TEST FINISHED");



            ////     deck.DeleteCard("Hearts", "Five");
            ////    deck.PrintDeck();
            ////    deck.PrintDeck();

            //int y = 0;
            //while (y < 649739) {
            //deck.RealShuffle();
            //for (int x = 0; x < 5; x++) { 
            //deck.DealCard();


            //    }
            //    y++;
            //    deck.CheckForRoyalInSpades();
            //    deck.CheckForRoyalInHearts();
            //    deck.CheckForRoyalInDiamonds();
            //    deck.CheckForRoyalInClubs();
            //    deck = new Deck();
            //}
        }
    }
}
