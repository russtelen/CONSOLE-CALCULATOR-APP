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
                Console.WriteLine($"You chose to add {Number.getNum1()} and {Number.getNum2()}... Your result is {Number.getNum1() + Number.getNum2()} ");
            }
            else if (Operator.OperatorChosen.Equals("2"))
            {
                Console.WriteLine($"You chose to subtract {Number.getNum1()} and {Number.getNum2()}... Your result is {Number.getNum1() - Number.getNum2()} ");
            }
            else if (Operator.OperatorChosen.Equals("3"))
            {
                Console.WriteLine($"You chose to multiply {Number.getNum1()} and {Number.getNum2()}... Your result is {Number.getNum1() * Number.getNum2()} ");
            }
            else if (Operator.OperatorChosen.Equals("4"))
            {
                Console.WriteLine($"You chose to divide {Number.getNum1()} and {Number.getNum2()}... Your result is {Number.getNum1() / Number.getNum2()} ");
            }
            else if (Operator.OperatorChosen.Equals("5"))
            {
                Console.WriteLine($"You chose to get the remainders {Number.getNum1()} and {Number.getNum2()}... Your result is {Number.getNum1() % Number.getNum2()} ");
            }
            else if (Operator.OperatorChosen.Equals("6"))
            {
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Invalid Option! Choose a nubmer 1 - 6");
                Operator.AskUserForOperator();
                DisplayResults();
            }

        }
    }
}
