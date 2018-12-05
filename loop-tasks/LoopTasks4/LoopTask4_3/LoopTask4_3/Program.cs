using System;

namespace LoopTask4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista lukua väliltä [0-50].");
            int number = 1;
            Random rnd = new Random();

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Rivi {i}: ");
                for (int j = 1; j <= 5; j++)
                {
                    number = rnd.Next(51);
                    if (j == 5)
                        Console.WriteLine($"{number}");
                    else
                        Console.Write($"{number}, ");
                }
            }
        }
    }
}
