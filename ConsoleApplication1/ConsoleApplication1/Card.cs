﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Card
    {
        public Card(string suit, string face)
        {
            this.face = face;
            this.suit = suit;
        }

        public string face { get; set; }
        public string suit { get; set; }

        public override string ToString()
        {
            return face + " of " + suit;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            { 
                return false;
            }

            Card c = obj as Card;

            if((System.Object)c == null)
            {
                return false;
            }

            return (c.suit == this.suit && c.face == this.face);
        }
    }
}
