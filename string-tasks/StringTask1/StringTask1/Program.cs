using System;

namespace StringTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee syötettyjen merkkien määrän.");
            Console.WriteLine("Kirjoita jotain: ");
            string k = Console.ReadLine();
            Console.WriteLine($"Lauseessa '{k}' on {k.Length} merkkiä.");
        }
    }
}
