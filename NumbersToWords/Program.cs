using NumbersToWords.Models;
using System.Collections.Generic;
using System;
class Program
{
  static void Main()
  {
    // # 1 PROMT  SCRABBLE GAME
    // Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    // Console.WriteLine("Welcome to the Scrabble app!");
    // Console.WriteLine("Please enter in a word:");
    // string targetWord = Console.ReadLine();
    // Word myWord = new Word(targetWord);
    // Console.WriteLine("Your score is: " + myWord.calScore());


    // # 2 PROMT Rock Paper Scissors Game
    // Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    // Console.WriteLine("Welcome to the Rock Paper Scissors App!");
    // Console.WriteLine("Player 1 enter in a choice:");
    // string choice1 = Console.ReadLine();
    // RPS player1 = new RPS(choice1);
    // Random rand = new Random();
    // int randomInt = rand.Next(3);
    // string compChoice = "error";
    // if(randomInt == 0)
    // {
    //   compChoice = "rock";
    // }
    // else if(randomInt == 1)
    // {
    //   compChoice = "paper";
    // }
    // else if(randomInt == 2)
    // {
    //   compChoice = "scissors";
    // }
    // RPS compPlayer = new RPS(compChoice);
    // Console.WriteLine("Computer choice is: " + compChoice);
    // string result = player1.calOutcome(compPlayer);
    // Console.WriteLine("So the result is: " + result);

    // # 3 Find and replace with string game 
    // Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    // Console.WriteLine("Welcome to the Find Word and Replace App!");
    // Console.WriteLine("Please enter in a original string: ");
    // string choiceString = Console.ReadLine();
    // Console.WriteLine("Please enter in a word to search for: ");
    // string searchWord = Console.ReadLine();
    // Console.WriteLine("Please enter in a replace word: ");
    // string replaceWord = Console.ReadLine(); 
    // FandP myFandPobj = new FandP(choiceString,searchWord,replaceWord);
    // Console.WriteLine(myFandPobj.findAndReplace());

    // # 4 Prime Sifting
    Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    Console.WriteLine("Welcome to the Prime Sifting App!");
    Console.WriteLine("Please enter in a number : ");
    int userInput = int.Parse(Console.ReadLine());
    PrimeNumber priNumbers = new PrimeNumber(userInput);
    List<int> results = priNumbers.calPrimeNumber();
    foreach(int item in results)
    {
      Console.WriteLine("Prime Numbers: " + item);
    }
  }
}