// instatiate a card

using CatchUpGroupCardGame;

Console.OutputEncoding = System.Text.Encoding.Unicode;

// alt + type 3,4,5,or 6 on keypad

Deck gameDeck = new Deck();

for (int i = 0; i < 5; i++)
{
    Console.Write(gameDeck.DealRandomCard());
}
