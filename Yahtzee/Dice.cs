using System;

namespace Yahtzee;
public class Dice
{
    public readonly List<Die> DieList = new List<Die>();

    private int _numberOfDice;
    public Dice(int numberOfDice)
    {
        _numberOfDice = numberOfDice;
        CreateDice(_numberOfDice);

    }
    
    private void CreateDice(int n)
    {
        while(n > 0)
        {
            n--;
            DieList.Add(new Die());
        }


    }
}
