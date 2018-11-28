using System;

namespace LoopTask3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee edellisten parittomien ja parillisten lukujen summan.");
            int number = 0;
            int oddSum = 0;
            int evenSum = 0;

            do
            {
                Console.WriteLine("Syötä numero: ");
                number = int.Parse(Console.ReadLine());
                if (number == 0)
                    Console.WriteLine("Väärä syöte!");
            }
            while (number == 0);

            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                        evenSum = evenSum + i;
                    else
                        oddSum = oddSum + i;
                }
            }
            else
                for (int i = 0; i >= number; i--)
                {
                    if (i % 2 == 0)
                        evenSum = evenSum + i;
                    else
                        oddSum = oddSum + i;
                }
            Console.WriteLine($"Parillisten lukujen summa: {evenSum}");
            Console.WriteLine($"Parittomien lukujen summa: {oddSum}");
        }
    }
}
