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

            //Ask user for first number, then assign
            Console.WriteLine("Enter a number you would like to calculate, then hit enter");
            Number.assignFirstNumber(Console.ReadLine());

            //Ask user for Second number, then assign
            Console.WriteLine("Enter another number you would like to calculate, then hit enter");
            Number.assignSecondNumber(Console.ReadLine());

            //Ask user for operator
            Operator.AskUserForOperator();

            //Display Result
            Results.DisplayResults();

            //Ask user if they want to restart
            Restart.RestartApp();

            Console.Read();
        }
    }
}
