using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchUpGroupCardGame;

public class Deck
{
    public List<Card> Cards { get; set; } = new List<Card>();


    // construct deck?
    public Deck()
    {
        Reset();
    }

    public void Reset()
    {
        try
        {
            List<string> suits = new List<string> { "♥", "♦", "♣", "♠" };
            List<string> ranks = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            List<int> values = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            // IEnumerable
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Card myCardToAdd = new Card(suit, rank, values[ranks.IndexOf(rank)]);
                    Cards.Add(myCardToAdd);
                }
            }
        } 
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }

    // deal
    // return card from deck & remove that card from the deck
    public Card DealRandomCard()
    {
        Random rnd = new Random();
        int cardToDealIndex = rnd.Next(Cards.Count);
        Card cardToDeal = Cards[cardToDealIndex];
        Cards.Remove(cardToDeal);
        return cardToDeal;
    }

}
