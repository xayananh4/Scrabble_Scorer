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
    Console.WriteLine("Please enter in a word:");
    string targetWord = Console.ReadLine();
    Word myWord = new Word(targetWord);
    Console.WriteLine("Your score is: " + myWord.calScore());



  }
}