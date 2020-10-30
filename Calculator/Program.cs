using System;
using System.Runtime.CompilerServices;

namespace Calculator
{
    class Program
    {
        //Declare Variables

        private static string operatorChosen { get; set; }

        //Method to display title
        public static void DisplayTitle()
        {
            Console.WriteLine("Welcome to Russ' Calculator!");
            Console.WriteLine("");
        }

        //Method that asks user for inputs
        public static void AskUserForOperator()
        {
            //Ask user what they would like to do with the numbers
            Console.WriteLine("What would you like to do with these two numbers? Select a number then hit enter");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Modulo (Get Remainder)");
            Console.WriteLine("6. Quit Appication");

            operatorChosen = Console.ReadLine();

        }

        public static void DisplayResults()
        {
            if (operatorChosen.Equals("1"))
            {
                Console.WriteLine($"You chose to add {Number.num1} and {Number.num2}... Your result is {Number.num1 + Number.num2} ");
            }
            else if (operatorChosen.Equals("2"))
            {
                Console.WriteLine($"You chose to subtract {Number.num1} and {Number.num2}... Your result is {Number.num1 - Number.num2} ");
            }
            else if (operatorChosen.Equals("3"))
            {
                Console.WriteLine($"You chose to multiply {Number.num1} and {Number.num2}... Your result is {Number.num1 * Number.num2} ");
            }
            else if (operatorChosen.Equals("4"))
            {
                Console.WriteLine($"You chose to divide {Number.num1} and {Number.num2}... Your result is {Number.num1 / Number.num2} ");
            }
            else if (operatorChosen.Equals("5"))
            {
                Console.WriteLine($"You chose to get the remainders {Number.num1} and {Number.num2}... Your result is {Number.num1 % Number.num2} ");
            }
            else if (operatorChosen.Equals("6"))
            {
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Invalid Option! Choose a nubmer 1 - 6");
                AskUserForOperator();
                DisplayResults();
            }

        }

        static void Main(string[] args)
        {
            //Title
            DisplayTitle();

            //Ask user for first number
            Number.AskUserFirstNumber();

            //Ask user for Second number
            Number.AskUserSecondNumber();

            //Ask user for operator
            AskUserForOperator();

            //Display Result
            DisplayResults();

            Console.Read();
        }
    }
}
