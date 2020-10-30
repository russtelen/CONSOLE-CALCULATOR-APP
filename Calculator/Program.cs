using System;

namespace Calculator
{
    class Program
    {
    
        static void Main(string[] args)
        {
            //Declare Variables
            decimal num1;
            decimal num2;

            //Title
            Console.WriteLine("Welcome to Russ' Calculator!");
            Console.WriteLine("");

            //Ask user for first number
            Console.WriteLine("Enter a number, then hit enter");
           //Assign chosen number to num1
            num1 = decimal.Parse(Console.ReadLine());

            //Ask user for Second number
            Console.WriteLine("Enter another number, then hit enter");
            //Assign chosen number to num1
            num2 = decimal.Parse(Console.ReadLine());

            //Ask user what they would like to do with the numbers
            Console.WriteLine("What would you like to do with these two numbers? Select a number then hit enter");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");

            double operatorChosen = double.Parse(Console.ReadLine());

            if (operatorChosen == 1)
            {
                Console.WriteLine($"You chose to add {num1} and {num2}... Your result is {num1 + num2} ");
            } 
            else
            {
                Console.WriteLine("Invalid Option! Choose a nubmer 1 - 6");
            }


            Console.Read();
        }
    }
}
