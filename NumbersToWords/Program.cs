using NumbersToWords.Models;
using System;
class Program
{
  static void Main()
  {
    // Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    // Console.WriteLine("Welcome to the Scrabble app!");
    // Console.WriteLine("Please enter in a word:");
    // string targetWord = Console.ReadLine();
    // Word myWord = new Word(targetWord);
    // Console.WriteLine("Your score is: " + myWord.calScore());

    Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    Console.WriteLine("Welcome to the Rock Paper Scissors App!");
    Console.WriteLine("Player 1 enter in a choice:");
    string choice1 = Console.ReadLine();
    RPS player1 = new RPS(choice1);
    Random rand = new Random();
    int randomInt = rand.Next(3);
    string compChoice = "error";
    if(randomInt == 0)
    {
      compChoice = "rock";
    }
    else if(randomInt == 1)
    {
      compChoice = "paper";
    }
    else if(randomInt == 2)
    {
      compChoice = "scissors";
    }

    RPS compPlayer = new RPS(compChoice);
    Console.WriteLine("Computer choice is: " + compChoice);
    string result = player1.calOutcome(compPlayer);
    Console.WriteLine("So the result is: " + result);
  }
}