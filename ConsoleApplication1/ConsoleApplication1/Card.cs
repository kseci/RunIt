using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Card
    {
        public String face { get; set; }
        public String suit { get; set; }

        public Card(String face, String suit)
        {
            this.face = face;
            this.suit = suit;
        }
        public override string ToString()
        {
            return face + " of " + suit;
        }
    }
}
