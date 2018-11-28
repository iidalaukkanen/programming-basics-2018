using System;

namespace LoopTask3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee ensimmäiset luvut yhteen.");
            int number = 0;
            int summa = 0;

           
            
            Console.WriteLine("Syötä viimeinen numero: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                summa = summa + i;
            }
            Console.WriteLine($"Lukujen summa on: {summa}");
            
        }
    }
}
