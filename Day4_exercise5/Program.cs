

using Day4_exercise5;
using System.Reflection.Metadata.Ecma335;
using static Day4_exercise5.Card;

static bool FilterByClubs(Card card)
{
    return card.GetSuit() == Suit.Clubs;
   
}

static bool FilterByPictureCard(Card card)
{
    List<Number> pictureNumbers = new List<Number> { Number.Jack, Number.Queen, Number.King };

    return pictureNumbers.Contains(card.GetNumber());
}

static bool FilterByNonPictureCard(Card card)
{
    List<Number> NonPictureNumbers = new List<Number> { Number.Ace, Number.Two, Number.Three, Number.Four, Number.Five, Number.Six, Number.Seven, Number.Eight, Number.Nine, Number.Ten };

    return NonPictureNumbers.Contains(card.GetNumber());
}

CardGame cg = new CardGame();

cg.addCard(Suit.Clubs, Number.Jack);
cg.addCard(Suit.Diamonds, Number.Queen);
cg.addCard(Suit.Hearts, Number.Ace);
cg.addCard(Suit.Spades, Number.Ten);
cg.addCard(Suit.Diamonds, Number.Jack);
cg.addCard(Suit.Clubs, Number.King);
cg.addCard(Suit.Clubs, Number.Nine);
cg.addCard(Suit.Hearts, Number.Four);

var pictureCards = cg.filterCardGame(FilterByPictureCard);

foreach (Card card in pictureCards)
{
    Console.WriteLine(card.ToString());
}

Console.WriteLine();

var clubsCards = cg.filterCardGame((Card c) => c.GetSuit() == Suit.Clubs);

foreach (Card card in clubsCards)
{
    Console.WriteLine(card.ToString());
}