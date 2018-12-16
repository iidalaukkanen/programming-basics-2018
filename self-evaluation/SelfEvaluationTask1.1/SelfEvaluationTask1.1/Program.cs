using System;

namespace SelfEvaluationTask1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa syöttämäsi lausahduksen viisi kertaa.");
            Console.WriteLine("Kirjoita jotain: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(userInput);
            }
        }
    }
}
