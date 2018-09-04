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
  public int num = 50;
  public string userfifty;
  public int fifty(string userfifty)
  {
    if (userfifty == "higher")
    {
      num += (num / 2);
    }
    else if (userfifty == "lower")
    {
      num -= (num / 2);
    }
    return num;
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
    Console.WriteLine("Is your number higher or lower than " + guessfifty.fifty(userfifty));
  }
}
