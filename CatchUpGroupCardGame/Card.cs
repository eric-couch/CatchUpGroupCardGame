using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchUpGroupCardGame;

public class Card
{
    public string suit { get; set; }
    public string rank { get; set; }  // 9, 10, J, Q, K, A
    public int value { get; set; }  // 9, 10, 11, 12, 13, 14

    /// <summary>
    /// This will create a new card 
    /// </summary>
    /// <param name="suit">♥, ♦, ♣, ♠</param>
    /// <param name="rank">2, 3, 4, 5... 10, J, Q, K, A</param>
    /// <param name="value">2, 3, 4, 5... 10, 11, 12, 13, 14</param>
    public Card(string suit, string rank, int value)
    {
        this.suit = suit;
        this.rank = rank;
        this.value = value;
    }

    public override string? ToString()
    {
        // interpolated string
        return $"{rank}{suit} ";
    }
}
