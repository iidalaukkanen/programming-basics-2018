using System;

namespace Self_evaluationTask1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kirjoittamasi lauseen yhtä monta kertaa kuin siinä on kirjaimia.");
            Console.WriteLine("Kirjoita jotain: ");
            string userInput = Console.ReadLine();

            int k = userInput.Length;

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"{i}. {userInput}");
            }
        }
    }
}
