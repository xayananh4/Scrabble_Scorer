using System;
namespace NumbersToWords.Models
{
  public class FandP
  {
    public string _userInput;
    public string _searchedWord;
    public string _replaceWord;

    public FandP(string userInput, string searchedWord, string replaceWord)
    {
      _userInput = userInput;
      _searchedWord = searchedWord;
      _replaceWord = replaceWord;
    }

    public string findAndReplace()
    {
      string mySearch = "";
      string returnWord = "";

      for (int i = 0; i < this._userInput.Length - this._searchedWord.Length + 1; i++)
      {
        mySearch = this._userInput.Substring(i, this._searchedWord.Length);

        if (mySearch.Equals(this._searchedWord)) // we found the serach word
        {
          returnWord += this._replaceWord;
          i = i + this._searchedWord.Length -1;
          if (i >= this._userInput.Length - this._searchedWord.Length){
            return returnWord;
          }
        }
        else
        {
          // we did not find the search term
          returnWord += this._userInput.Substring(i, 1);
        }
      }
      returnWord += _userInput.Substring(this._userInput.Length - this._searchedWord.Length + 1, this._searchedWord.Length - 1);
      return returnWord;
    }
  }
}