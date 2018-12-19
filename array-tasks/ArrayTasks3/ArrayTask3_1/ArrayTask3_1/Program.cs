using System;

namespace ArrayTask3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo taulukkoon luvut 0-19.");

            int[] raffle = new int[10];
            RndRaffle(ref raffle);
        }
        static void RndRaffle(ref int[] arrRaffle)
        {
            Random rnd = new Random();
            for (int i = 0; i < arrRaffle.Length; i++)
            {
                arrRaffle[i] = rnd.Next(20);
                Console.WriteLine($"[{i}] = {arrRaffle[i]:d2}");
            }
        }
    }
}
