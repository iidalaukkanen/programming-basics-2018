using System;

namespace LoopTask4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 1-10 ja niiden neliöjuuret.");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i}.\t{Math.Sqrt(i):f2}");
            }
        }
    }
}
