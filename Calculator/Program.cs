using System;
using System.Runtime.CompilerServices;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title
            Title.DisplayTitle();

            //Ask user for first number
            Number.AskUserFirstNumber();

            //Ask user for Second number
            Number.AskUserSecondNumber();

            //Ask user for operator
            Operator.AskUserForOperator();

            //Display Result
            Results.DisplayResults();

            Console.Read();
        }
    }
}
