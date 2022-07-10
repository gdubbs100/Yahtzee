using Yahtzee;
namespace Yahtzee.Tests;

public class DiceTests
{
    [Fact]
    public void StartsWith5Die()
    {
        var dice = new Dice(5);
        Assert.Equal(5, dice.DieList.Count());
    }
}