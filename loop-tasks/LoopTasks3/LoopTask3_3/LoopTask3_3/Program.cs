using System;

namespace LoopTask3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee edellisten parittomien ja parillisten lukujen summan.");
            int number = 0;
            int oddSum = 0;
            int evenSum = 0;

            Console.WriteLine("Syötä numero: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
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
