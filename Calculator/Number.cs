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
        public static void AskUserFirstNumber(string input)
        {
            bool isValid = Decimal.TryParse(input, out num1);

            //Logic
            if (!isValid)
            {
                Console.WriteLine("Invalid input! Enter a NUMBER you would like to calculate, then hit enter");
                AskUserFirstNumber(input);
            }
            else
            {
                num1 = Decimal.Parse(input);    
            }

            //while (!isValid)
            //{
            //    Console.WriteLine("Invalid input! Enter a NUMBER you would like to calculate, then hit enter");
            //    num1 = decimal.Parse(input);
            //}

        }




        //Method that asks user for 2nd number
        public static void AskUserSecondNumber(string input)
        {
            bool isValid = Decimal.TryParse(input, out num2);

            //Logic
            if (!isValid)
            {
                Console.WriteLine("Invalid input! Enter a NUMBER you would like to calculate, then hit enter");
                input = "0.00";
                AskUserSecondNumber(input);
            }
            else
            {
                num2 = Decimal.Parse(input);
            }

            //while (!isValid)
            //{
            //    Console.WriteLine("Invalid input! Enter a NUMBER you would like to calculate, then hit enter");
            //    num1 = decimal.Parse(input);
            //}

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
