using System;

namespace LoopTask4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9.");

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{(i * j):d2}  ");
                }
                Console.WriteLine();
            }
        }
    }
}
