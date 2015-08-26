using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    class ThreadManager
    {
     public void go()
        {
            Thread cheeseThread = new Thread(cheese);
            Thread turkeyThread = new Thread(turkey);

            cheeseThread.Start();
            turkeyThread.Start();

        }   
    public void cheese()
        {
            int counter = 0;
            while (counter < 20) { 
            Console.Write("Cheese ");
            counter++;
                Thread.Sleep(1000);
            }
        }
        public void turkey()
        {
            int counter = 0;
            while (counter < 20)
            {
                Console.Write("Turkey ");
                counter++;
                Thread.Sleep(1000);
            }
        }
    }
}
