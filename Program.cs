using System;

namespace Coding_With_Moss_first_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //Write a program and ask the user to enter a number. The number should be between 1 to 10. 
            //If the user enters a valid number, display "Valid" on the console. 
            //Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
            
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

            
            
            
            //Exercise 2 
            //Write a program which takes two numbers from the console and displays the maximum of the two.
            /** try
             {
                 Console.Write("Please enter a number: ");
                 int firstUserInput = Convert.ToInt32(Console.ReadLine());

                 Console.Write("Please enter another number: ");
                 int secondUserInput = Convert.ToInt32(Console.ReadLine());

                int result = Math.Max(firstUserInput, secondUserInput);

                 Console.WriteLine($"The maximum number is {result}");
             }
             catch (System.Exception)
             {

                 Console.WriteLine("Please enter a number");
            }
             ***/

            // exercise 3
            //Write a program and ask the user to enter the width and height of an image. 
            //Then tell if the image is landscape or portrait. 

            /**
            try
            {
                double imageWidth = 11;
                double imageHeight = 8.5;

                Console.Write("Please enter the height of the image: ");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter the width of the image: ");
                double width = Convert.ToDouble(Console.ReadLine());

                if (height < imageHeight && width < imageWidth)
                {
                    Console.WriteLine($"You entered {width} for width and {height} for height.\nThe image is a potrait image");
                }
                else
                {
                    Console.WriteLine($"You entered {width} for width and {height} for height.\nThe image is a landscape image");
                }
            }
            catch (System.Exception)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid number");
            }
            **/


            // Exercise 4
            // Your job is to write a program for a speed camera. 
            // For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
            // Write a program that asks the user to enter the speed limit. 
            // Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, 
            // program should display Ok on the console. If the value is above the speed limit, 
            // the program should calculate the number of demerit points. 
            // For every 5km/hr above the speed limit, 1 demerit points should be incurred and 
            // displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.


            try
            {
                Console.Write("Please enter the speed limit: ");
                int speedLimit = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter the speed of the car: ");
                int speed = Convert.ToInt32(Console.ReadLine());


                if (speed < speedLimit)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ok!");
                }


                else
                {
                    const int kmDemeritPoints = 5;
                    int dermitPoints = (speed - speedLimit) / kmDemeritPoints;

                    if (dermitPoints >= 12)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"You have {dermitPoints} points.\nYour license is suspended");
                    }
                    else
                    {
                        Console.WriteLine($"Dermit points are {dermitPoints}");
                    }


                }
            }
            catch (System.Exception)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please enter a number");
            }








        }
    }
}
