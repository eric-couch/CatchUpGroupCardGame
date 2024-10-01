namespace CatchUpGroupCardGame.Test;

public class UnitTest1
{
    [Fact]
    public void TestHasAce_True()
    {
        // Arrange
        List<Card> cards = new List<Card>()
        {
            new Card("♠", "8", 8),
            new Card("♠", "9", 9),
            new Card("♠", "Q", 12),
            new Card("♦", "5", 5),
            new Card("♠", "A", 14)
        };

        // Act
        bool hasAce = FiveCardDraw.HasAce(cards);

        // Assert
        Assert.True(hasAce);
    }

    [Fact]
    public void TestHasAce_False()
    {
        // Arrange
        List<Card> cards = new List<Card>()
        {
            new Card("♠", "8", 8),
            new Card("♠", "9", 9),
            new Card("♠", "Q", 12),
            new Card("♦", "5", 5),
            new Card("♠", "K", 13)
        };

        // Act
        bool hasAce = FiveCardDraw.HasAce(cards);

        // Assert
        Assert.False(hasAce);
    }

    [Fact]
    public void TestIsTrips_True()
    {
        // Arrange
        List<Card> cards = new List<Card>()
        {
            new Card("♠", "8", 8),
            new Card("♠", "9", 9),
            new Card("♠", "Q", 12),
            new Card("♦", "9", 9),
            new Card("♥", "9", 9)
        };

        // Act
        bool isTrips = FiveCardDraw.IsTrips(cards);

        // Assert
        Assert.True(isTrips);
    }

    [Fact]
    public void TestIsTrips_False()
    {
        // Arrange
        List<Card> cards = new List<Card>()
        {
            new Card("♠", "8", 8),
            new Card("♠", "9", 9),
            new Card("♠", "Q", 12),
            new Card("♦", "9", 9),
            new Card("♥", "5", 5)
        };

        // Act
        bool isTrips = FiveCardDraw.IsTrips(cards);

        // Assert
        Assert.False(isTrips);
    }

    [Fact]
    public void TestIsStraight_True()
    {
        // Arrange
        List<Card> cards = new List<Card>()
        {
            new Card("♠", "8", 8),
            new Card("♠", "9", 9),
            new Card("♠", "10", 10),
            new Card("♦", "J", 11),
            new Card("♥", "Q", 12)
        };

        // Act
        bool isStraight = FiveCardDraw.IsStraight(cards);

        // Assert
        Assert.True(isStraight);
    }

    [Fact]
    public void TestIsStraight_False()
    {
        // Arrange
        List<Card> cards = new List<Card>()
        {
            new Card("♠", "7", 7),
            new Card("♠", "9", 9),
            new Card("♠", "10", 10),
            new Card("♦", "J", 11),
            new Card("♥", "Q", 12)
        };

        // Act
        bool isStraight = FiveCardDraw.IsStraight(cards);

        // Assert
        Assert.False(isStraight);
    }
}