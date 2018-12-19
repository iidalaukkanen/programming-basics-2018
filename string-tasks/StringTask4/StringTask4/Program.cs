﻿using System;

namespace StringTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkistaa, onko syötetty sana/lause palindromi.");
            Console.WriteLine("Syötä sana tai lause: ");

            string input = Console.ReadLine();
            Console.WriteLine(input);

            string isPalindrome = "";

            string inputTrimmed = input.Replace(" ", "");

            for (int i = 0; i < inputTrimmed.Length; i++)
            {
                if (inputTrimmed.Substring(i, 1) != inputTrimmed.Substring(inputTrimmed.Length - 1 - i, 1))
                {
                    isPalindrome = "not ";
                }
            }
            Console.WriteLine("The string {0} is {1}a palindrome.", input, isPalindrome);
            Console.WriteLine();
        }
    }
}
