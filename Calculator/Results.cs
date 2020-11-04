using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Results
    {
        public static void DisplayResults()
        {
            if (Operator.OperatorChosen.Equals("1"))
            {
                Console.WriteLine($"You chose to add {Number.num1} and {Number.num2}... Your result is {Number.num1 + Number.num2} ");
            }
            else if (Operator.OperatorChosen.Equals("2"))
            {
                Console.WriteLine($"You chose to subtract {Number.num1} and {Number.num2}... Your result is {Number.num1 - Number.num2} ");
            }
            else if (Operator.OperatorChosen.Equals("3"))
            {
                Console.WriteLine($"You chose to multiply {Number.num1} and {Number.num2}... Your result is {Number.num1 * Number.num2} ");
            }
            else if (Operator.OperatorChosen.Equals("4"))
            {
                Console.WriteLine($"You chose to divide {Number.num1} and {Number.num2}... Your result is {Number.num1 / Number.num2} ");
            }
            else if (Operator.OperatorChosen.Equals("5"))
            {
                Console.WriteLine($"You chose to get the remainders {Number.num1} and {Number.num2}... Your result is {Number.num1 % Number.num2} ");
            }
            else if (Operator.OperatorChosen.Equals("6"))
            {
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Invalid Option! Choose a number from 1 - 6");
                Operator.AskUserForOperator();
                DisplayResults();
            }
        }
    }
}
