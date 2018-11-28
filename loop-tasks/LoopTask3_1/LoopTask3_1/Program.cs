using System;

namespace LoopTask3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma selvittää syöttämäsi numeron kertoman.");
            int number = 0;
            int fact = 1;

            do
            {
                Console.WriteLine("Syötä numero: ");
                number = int.Parse(Console.ReadLine());

                if (number <= 0)
                    Console.WriteLine("Väärä syöte!");
            }
            while (number <= 0);

            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"{number}! = {fact}");

        }
    }
}
