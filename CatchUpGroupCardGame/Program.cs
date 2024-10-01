// instatiate a card

using CatchUpGroupCardGame;

Console.OutputEncoding = System.Text.Encoding.Unicode;

// alt + type 3,4,5,or 6 on keypad

Deck gameDeck = new Deck();
List<Card> hand = new List<Card>();    

for (int i = 0; i < 5; i++)
{
    Card dealtCard = gameDeck.DealRandomCard();
    Console.Write(dealtCard);
    hand.Add(dealtCard);
}
Console.WriteLine();
Console.WriteLine($"Trips: {FiveCardDraw.IsTrips(hand)}");
Console.WriteLine($"Pair: {FiveCardDraw.IsPair(hand)}");
