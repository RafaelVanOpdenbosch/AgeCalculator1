﻿using System;

namespace AgeCalculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EnterBirthDate test1 = new EnterBirthDate();
            test1.InputBirthDate();
            WelcomeMessage.ShowWelcomeMessage();
            Console.ReadLine();
        }
    }
}
