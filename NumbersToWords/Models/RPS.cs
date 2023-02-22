namespace NumbersToWords.Models
{

  public class RPS
  {
    public string UserChoice { get; set; }


    public RPS(string userChoice)
    {
      UserChoice = userChoice;
    }

    public string calOutcome(RPS oppchoice)
    {
      if (this.UserChoice == "rock")
      {

        if (oppchoice.UserChoice == "rock")
        { return "Draw"; }
        else if (oppchoice.UserChoice == "scissors")
        {
          return "You Win";

        }
        else if (oppchoice.UserChoice == "paper")
        {
          return "You Lose";
        }

      }
      else if (this.UserChoice == "scissors")
      {
        if (oppchoice.UserChoice == "rock")
        { return "You Lose"; }
        else if (oppchoice.UserChoice == "scissors")
        {
          return "It's a Draw";

        }
        else if (oppchoice.UserChoice == "paper")
        {
          return "You Won";
        }
      }
      else if (this.UserChoice == "paper")
      {
        if (oppchoice.UserChoice == "rock")
        { return "You Win"; }
        else if (oppchoice.UserChoice == "scissors")
        {
          return "You lose";

        }
        else if (oppchoice.UserChoice == "paper")
        {
          return "It is a Draw";
        }
      }
      return "Error";
    }

  }
}