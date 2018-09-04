using System;

public class Game
{
  public string user;
  public string Guessing(string user)
  {
    if (user == "yes")
    {
      return "Wow thanks for playing with me";
    }
    else if (user == "no")
    {
      return "Okay, you don't want to play with me";
    }
    else
    {
      return "Sorry, I didn't understand that.";
    }
  }
}

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
    return newNum;
  }
}






class Program
{
  public static void Main()
  {
    Console.WriteLine("Would you like to play the higher/lower game?");
    string user = Console.ReadLine();
    Game play = new Game();
    Console.WriteLine(play.Guessing(user));

    Console.WriteLine("Is your number higher or lower than 50?");
    string userfifty = Console.ReadLine();
    numberGame guessfifty = new numberGame();
    if (userfifty == "Correct")
    {
      Console.WriteLine("I guessed it thanks for playing");
    }
    else
    {
      while (userfifty != "Correct")
      {
       Console.WriteLine("Is your number higher or lower than " + guessfifty.fifty(userfifty) + "?");
       userfifty = Console.ReadLine();
     }
    }
  }
}
