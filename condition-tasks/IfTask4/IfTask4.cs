using System;

namespace IfTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma järjestää kolme lukua nousevaan järjestykseen");
            Console.Write("Syötä 1. luku:");
            string userInput = Console.ReadLine();
            int x = int.Parse(userInput);

            Console.Write("Syötä 2. luku:");
            userInput = Console.ReadLine();
            int y = int.Parse(userInput);

            Console.Write("Syötä 3. luku:");
            userInput = Console.ReadLine();
            int z = int.Parse(userInput);

            if (x < y && x < z)
                if (y < z)
                    Console.WriteLine($"{x},{y},{z}");
                else
                    Console.WriteLine($"{x},{z},{y}");

            else if (y < x && y < z)
                if (x < z)
                    Console.WriteLine($"{y},{x},{z}");
                else
                    Console.WriteLine($"{y},{z},{x}");

            else if (z < x && z < y)
                if (x < y)
                    Console.WriteLine($"{z},{x},{y}");
                else
                    Console.WriteLine($"{z},{y},{x}");

        }
    }
}
