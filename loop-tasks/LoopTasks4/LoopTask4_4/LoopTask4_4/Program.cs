using System;

namespace LoopTask4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa saatujen kruunien ja klaavojen määrän.");
            int heads = 0;
            int tails = 0;
            int n;
            Random rnd = new Random();
            int rndNumber;

            Console.Write("Syötä heittojen lukumäärä: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                rndNumber = rnd.Next(2);
                if (rndNumber == 1)
                {
                    heads = heads + 1;
                }
                else
                {
                    tails = tails + 1;
                }
            }
            Console.WriteLine($"Kruuna heitettiin {heads} kertaa ja klaava heitettiin {tails} kertaa.");

        }
    }
}
