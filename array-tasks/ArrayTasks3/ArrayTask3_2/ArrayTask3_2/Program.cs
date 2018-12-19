using System;

namespace ArrayTask3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo taulukkoon luvut väliltä 0-99.");

            int[,] raffle = new int[10, 20];
            RndRaffle(ref raffle);
        }

        static void RndRaffle(ref int[,] arrRaffle)
        {
            Random rnd = new Random();

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine();
                for (int y = 0; y < 20; y++)
                {
                    arrRaffle[x, y] = rnd.Next(100);
                    Console.WriteLine($"[{x},{y}] = {arrRaffle[x,y]:d2}");
                }
            }
        }
    }
}
