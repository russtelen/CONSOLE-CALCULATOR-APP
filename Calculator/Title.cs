using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Calculator
{
    class Title
    {
        private static string name;

        public Title(string name)
        {
            Title.name = name;
        }

        public static void setName(string name) 
        {
            Title.name = name;
        }

        public static void DisplayTitle()
        {
            setName("Russ");
            Console.WriteLine($"Welcome to {name}' Calculator!");
            Console.WriteLine("-------------------------------");
        }
    }
}
