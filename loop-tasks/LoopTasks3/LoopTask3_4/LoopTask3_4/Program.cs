using System;

namespace LoopTask3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee ensimmäiset luvut yhteen.");
            int number = 0;
            int sum = 0;
            

            Console.WriteLine("Syötä viimeinen numero: ");
            number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    sum = sum + i;
                }
            }
            else
                for (int i = 0; i >= number; i--)
                {
                    sum = sum + i;
                }
            Console.WriteLine($"Lukujen summa on: {sum}");
     
        }
    }
}
