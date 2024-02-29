using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_exercise5
{
    delegate bool FilterCardDelegate(Card card);
    internal class Card
    {
        private Suit suit;
        private Number number;

        public enum Suit
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }
        public enum Number
        {
            Ace,
            Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
            Jack,
            Queen,
            King
        }
        public Card(Suit suit, Number number)
        {
            this.suit = suit;
            this.number = number;
        }

        public Suit GetSuit() { return suit; }

        public Number GetNumber() { return number; }

        public override string ToString()
        {
            return this.suit + " " + this.number;
        }
    }
}
