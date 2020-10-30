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
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Modulo (Get Remainder)");
            Console.WriteLine("6. Quit Appication");

            double operatorChosen = double.Parse(Console.ReadLine());

            if (operatorChosen == 1)
            {
                Console.WriteLine($"You chose to add {num1} and {num2}... Your result is {num1 + num2} ");
            }
            else if (operatorChosen == 2)
            {
                Console.WriteLine($"You chose to subtract {num1} and {num2}... Your result is {num1 - num2} ");
            }
            else if (operatorChosen == 3)
            {
                Console.WriteLine($"You chose to multiply {num1} and {num2}... Your result is {num1 * num2} ");
            }
            else if (operatorChosen == 4)
            {
                Console.WriteLine($"You chose to divide {num1} and {num2}... Your result is {num1 / num2} ");
            }
            else if (operatorChosen == 5)
            {
                Console.WriteLine($"You chose to get the remainders {num1} and {num2}... Your result is {num1 % num2} ");
            }
            else if (operatorChosen == 6)
            {
                System.Environment.Exit(1);
            }
            else if (operatorChosen.Equals(null))
            {
                throw new System.ArgumentException("Parameter cannot be null", "original");
            }
            else
            {
                Console.WriteLine("Invalid Option! Choose a nubmer 1 - 6");
                Console.WriteLine("What would you like to do with these two numbers? Select a number then hit enter");
            }


            Console.Read();
        }
    }
}
