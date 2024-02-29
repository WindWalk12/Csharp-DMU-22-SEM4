using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_exercise5
{
    internal class CardGame
    {
        private List<Card> cards = new List<Card>();

        public void addCard(Card.Suit suit, Card.Number number)
        {
            cards.Add(new Card(suit, number));
        }

        public List<Card> filterCardGame(FilterCardDelegate filter)
        {
            List<Card> filtered = new List<Card>();
            foreach (Card card in cards)
            {
                if (filter(card))
                {
                    filtered.Add(card);
                }
            }
            return filtered;
        }
    }
}
