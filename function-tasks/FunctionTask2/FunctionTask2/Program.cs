using System;

namespace FunctionTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo, kumpi syötetyistä luvuista on pienempi.");
            int x, y;
            Intro(out x, out y);
            Console.WriteLine(SmallerNumber(x, y));
        }

        static void Intro(out int number1, out int number2)
        {
            Console.Write("Syötä 1. luku: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Syötä 2. luku: ");
            number2 = int.Parse(Console.ReadLine());
        }

        static string SmallerNumber(int a, int b)
        {
            if (a < b)
                return $"Luku {a} on pienempi kuin luku {b}.";
            else if (a > b)
                return $"Luku {b} on pienempi kuin luku {a}.";
            else
                return $"Luvut ovat keskenään yhtäsuuria.";
        }
    }
}
