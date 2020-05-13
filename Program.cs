using System;

namespace Coding_With_Moss_first_exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Ask a = new Ask();
                //var isNumber = true;
                var number = 10;
                a.AskUser();

                int userInput = Convert.ToInt32(Console.ReadLine());
                if ( userInput <= number)
                {
                    Console.WriteLine($"Your number is {userInput}!");
                }
                else
                {
                    System.Console.WriteLine("Please enter a number between 1 and 10");
                    
                }
            }
            catch (System.Exception)
            {

                System.Console.WriteLine("Please enter a valid number between 1 and 10");
                Ask b = new Ask();
                
            }




        }
    }
}
