using System;

namespace FunctionTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Intro();
            string asterisks = getNAsterisks(n);
            Print(asterisks);
        }
        static int Intro()
        {
            Console.WriteLine("Tähtien lukumäärä:");
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                    Console.WriteLine($"Luku {n} ei ole sallittu luku.");
                else
                    break;
            }
            return n;
        }

        static string getNAsterisks(int n)
        {
            string res = string.Empty;
            for (int i = 0; i < n; i++)
            {
                res += '*';
            }
            return res;
        }
        static void Print(string x)
        {
            Console.WriteLine(x);
        }

    }
}
