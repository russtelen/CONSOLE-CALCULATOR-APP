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
            Console.WriteLine("Enter a number you would like to calculate, then hit enter");
            Number.AskUserFirstNumber(Console.ReadLine());

            //Ask user for Second number
            Console.WriteLine("Enter another number you would like to calculate, then hit enter");
            Number.AskUserSecondNumber(Console.ReadLine());

            //Ask user for operator
            Operator.AskUserForOperator();

            //Display Result
            Results.DisplayResults();

            Console.Read();
        }
    }
}
