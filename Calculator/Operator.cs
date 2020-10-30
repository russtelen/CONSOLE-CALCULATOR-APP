using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Operator
    {
        public static string operatorChosen { get; set; }

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
    }
}
