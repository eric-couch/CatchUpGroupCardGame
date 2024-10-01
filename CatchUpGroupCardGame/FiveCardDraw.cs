using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchUpGroupCardGame;

public class FiveCardDraw
{
    // Check for Aces
    public static bool HasAce(List<Card> cards)
    {
        var results = from card in cards
                      where card.rank == "A"
                      select card;

        return results.Count() > 0;
        //return cards.Any(card => card.rank == "A");

        //return cards.Select(card => card.rank).Contains("A");

        //return (from card in cards
        //        where card.rank == "A"
        //        select card).Any();

    }
    // Check Pair
    public static bool IsPair(List<Card> cards)
    {
        //var results = cards.GroupBy(card => card.rank);
        //return results.Any(group => group.Count() == 2);
        return cards.GroupBy(card => card.rank)
                    .Any(group => group.Count() == 2);
    }

    // Check for Two Pair


    // Check for Trips
    public static bool IsTrips(List<Card> cards)
    {
        //var results = cards.GroupBy(card => card.rank);
        //return results.Any(group => group.Count() == 2);
        return cards.GroupBy(card => card.rank)
                    .Any(group => group.Count() == 3);
    }

    // Check for Straight
    public static bool IsStraight(List<Card> cards)
    {
        var sortedCards = cards.OrderBy(c => c.value)
                                .Select(c => c.value)
                                .ToList();

        return sortedCards.Zip(sortedCards.Skip(1), (a,b) => b - a)
                            .All(x => x == 1);

    }

    // Check for Flush
    public static bool IsFlush(List<Card> cards)
    {
        return cards.GroupBy(card => card.suit)
                    .Any(group => group.Count() == 5);
    }

    // Check for FullHouse
    public static bool IsFullHouse(List<Card> cards)
    {
        return IsTrips(cards) && IsPair(cards);
    }

    // Check for Four of a Kind
    public static bool IsFourOfAKind(List<Card> cards)
    {
        return cards.GroupBy(card => card.rank)
                    .Any(group => group.Count() == 4);
    }

    // Check for Straight-Flush


}
