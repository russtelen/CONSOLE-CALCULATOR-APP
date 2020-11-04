using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Restart
    {
        public static void RestartApp()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Would you like to continue using the app ? Enter 'Y' if yes, 'N' if no");

            string continueApp = Console.ReadLine();

            if (continueApp.ToUpper() == "Y")
            {
                //Ask user for first number, then assign
                Console.WriteLine("Enter a number you would like to calculate, then hit enter");
                Number.AssignFirstNumber(Console.ReadLine());

                //Ask user for Second number, then assign
                Console.WriteLine("Enter another number you would like to calculate, then hit enter");
                Number.AssignSecondNumber(Console.ReadLine());

                //Ask user for operator
                Operator.AskUserForOperator();

                //Display Result
                Results.DisplayResults();

                RestartApp();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
