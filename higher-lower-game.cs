using System;

public class numberGame
{
  public int startNum = 50;
  public int upperNum = 100;
  public int lowerNum = 0;
  public string userfifty;
  public int fifty(string userfifty)
  {
    int newNum = startNum;
    if (userfifty == "higher")
    {
      lowerNum = startNum;
      newNum += ((upperNum - startNum) / 2);
      startNum = newNum;
    }
    else if (userfifty == "lower")
    {
      upperNum = startNum;
      newNum -= ((startNum - lowerNum) / 2);
      startNum = newNum;
    }
    else
    {
      Console.WriteLine("Please respond higher or lower");
    }
    return newNum;
  }
}

class Program
{
  public static void Main()
  {
    Console.WriteLine("Would you like to play the higher/lower game? (yes/no)");
    string userResponse = Console.ReadLine().ToLower();
    if (userResponse == "yes")
    {
      Console.WriteLine("Think of a number between 1 and 100 and I'll guess it.");
    }
    else if (userResponse == "no")
    {
      Console.WriteLine("That's too bad. Maybe next time? Goodbye.");
      System.Environment.Exit(1);
    }
    else
    {
      Console.WriteLine("Sorry, I didn't understand what you said.");
    }

    Console.WriteLine("Is your number higher or lower than 50?");
    string userfifty = Console.ReadLine().ToLower();
    numberGame guessfifty = new numberGame();
    while (userfifty != "correct")
    {
     Console.WriteLine("Is your number higher or lower than " + guessfifty.fifty(userfifty) + "?");
     userfifty = Console.ReadLine();
    }
    if (userfifty == "correct")
    {
      Console.WriteLine("I guessed it thanks for playing");
    }
  }
}
