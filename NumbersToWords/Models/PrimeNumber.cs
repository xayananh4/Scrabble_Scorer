using System.Collections.Generic;
namespace NumbersToWords.Models
{

  public class PrimeNumber
  {
    private int _userInput;
    List<int> returnList = new List<int>();
    List<int> everyNumber = new List<int>();

    public PrimeNumber(int userInput)
    {
      this._userInput = userInput;

      for (int i = 2; i <= this._userInput; i++)
      {
        everyNumber.Add(i);
      }
    }

    public List<int> calPrimeNumber()
    {
      List<int> returnPrimeNumber = new List<int>();
      List<int> nonPrimeNumber = new List<int>(); //4,6,8,9,10

      for (int i = 0; i < this.everyNumber.Count; i++)
      {
        if (nonPrimeNumber.IndexOf(everyNumber[i]) == -1) // we have found a non prime number
        {
          returnPrimeNumber.Add(everyNumber[i]);
          for (int j = i + 1; j < this.everyNumber.Count; j++)
          {
            if (everyNumber[j] % everyNumber[i] == 0 && nonPrimeNumber.IndexOf(everyNumber[j]) == -1)
            {
              nonPrimeNumber.Add(everyNumber[j]);
            }

          }

        }

      }
      return returnPrimeNumber;
    }

  }











}