using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Number
    {
        public static decimal num1 = 0.00m;
        public static decimal num2 = 0.00m;

        public Number(decimal num1, decimal num2)
        {
            Number.num1 = num1;
            Number.num2 = num2;
        }
        //Method that asks user for 1st number
        public static void AskUserFirstNumber()
        {

            Console.WriteLine("Enter a number, then hit enter");
            //Assign chosen number to num1
            num1 = decimal.Parse(Console.ReadLine());
        }

        //Method that asks user for 2nd number
        public static void AskUserSecondNumber()
        {
            Console.WriteLine("Enter a number, then hit enter");
            //Assign chosen number to num2
            num2 = decimal.Parse(Console.ReadLine());
        }

        public static decimal getNum1()
        {
            return num1;
        }

        public static decimal getNum2()
        {
            return num2;
        }
    }
}
