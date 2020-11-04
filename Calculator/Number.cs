using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Number
    {
        public static decimal num1;
        public static decimal num2;
        public Number(decimal num1, decimal num2)
        {
            Number.num1 = num1;
            Number.num2 = num2;
        }

        //Assign 1st number
        public static void assignFirstNumber(string input)
        {
            bool isValid = Decimal.TryParse(input, out num1);   
            //Logic
            if (!isValid)
            {
                Console.WriteLine("Invalid input! Enter a NUMBER you would like to calculate, then hit enter");
                assignFirstNumber(Console.ReadLine());
            }
            else
            {
                num1 = Decimal.Parse(input);
            }
        }


        //Assign 2nd number
        public static void assignSecondNumber(string input)
        {
            bool isValid = Decimal.TryParse(input, out num2);
            //Logic
            if (!isValid)
            {
                Console.WriteLine("Invalid input! Enter a NUMBER you would like to calculate, then hit enter");
                assignSecondNumber(Console.ReadLine());
            }
            else
            {
                num2 = Decimal.Parse(input);
            }
        }

        //get num1
        public static decimal getNum1()
        {
            return num1;
        }

        //get num2
        public static decimal getNum2()
        {
            return num2;
        }
    }
}
