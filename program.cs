using System;

namespace Treehouse.FitnessFrog 
{  
  class Program
  {
      static void Main()
      {
        int runningTotal = 0;
        bool keepGoing = true;
        
        while (keepGoing) 
        {
          //Prompt the user for minutes exercise
          Console.Write("Enter how many minutes you exercised, or type \"quit\" to exit: ");
          string entry = Console.ReadLine(); 
          
          if (entry == "quit") 
          {
            keepGoing = false;
          }
          else
          {

            try //the if/esle code block added within the try braces to ensure variables are mantained for the code to run - scope 
            {
            //Add minutes exercised to the total
            int minutes = int.Parse(entry);
              
                        if(minutes <= 0){
              Console.WriteLine("That's not acceptable.");
              continue;
              //input validation
            }
            else if(minutes <= 10){
              Console.WriteLine("Better than nothing, am I right?");
            }
            else if(minutes <= 30){
              Console.WriteLine("Way to go hot stuff!");
            }
            else if(minutes <= 60){
              Console.WriteLine("You must be a Ninja Warrior in training!");
            }
            else{
              Console.WriteLine("Okay, now you're just showing off");
            }
            
            runningTotal += minutes;
              
            }
            catch(FormatException) // incase the user inputs a value which is not an integer
            {
              Console.WriteLine("That is not valid input.");
              continue;
            }
            
            //Display total minutes exercised to the screen for the week
            Console.WriteLine("You've entered " + runningTotal + " minutes");
          }
          //Repeat until the user quits
        }
        Console.WriteLine("Goodbye!");
      }
  }
}
