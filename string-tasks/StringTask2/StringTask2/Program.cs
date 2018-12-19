using System;

namespace StringTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa kirjoittamasi lauseen kaikki e-kirjaimet @-merkeiksi.");
            Console.WriteLine("Kirjoita jotain: ");

            string input = Console.ReadLine();

            Console.WriteLine(input.Replace("e","@"));
        }
    }
}
