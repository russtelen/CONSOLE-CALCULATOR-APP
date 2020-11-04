using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Calculator
{
    class Title
    {
        public static string Name { get; private set; }

        public Title(string Name)
        {
            Title.Name = Name;
        }

        public static void DisplayTitle()
        {
            Title.Name = "Russ";
            Console.WriteLine($"Welcome to {Name}' Calculator!");
            Console.WriteLine("-------------------------------");
        }
    }
}
