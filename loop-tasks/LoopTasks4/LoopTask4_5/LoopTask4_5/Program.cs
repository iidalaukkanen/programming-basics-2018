using System;

namespace LoopTask4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vakioveikkauksen rivisi on arvottu:\n");
            double odds;

            Random rnd = new Random();
            for (int i = 1; i <= 13; i++)
            {
                odds = rnd.NextDouble();
                if (odds <= 0.4)
                {
                    Console.WriteLine($"{i}.\t1");
                }
                else if (odds <= 0.6)
                {
                    Console.WriteLine($"{i}.\tX");
                }
                else
                {
                    Console.WriteLine($"{i}.\t2");
                }
            }
        }
    }
}
