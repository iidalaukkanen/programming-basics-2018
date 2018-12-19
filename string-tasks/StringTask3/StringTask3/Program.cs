using System;

namespace StringTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee syötteestä o-kirjaimet.");
            Console.WriteLine("Kirjoita jotain: ");
            string input = Console.ReadLine();

            int letterCounter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Substring(i,1).ToUpper()== "O")
                {
                    letterCounter++;
                }
            }
            Console.WriteLine("Lauseessa '{0}' on {1} O-kirjainta.", input.ToUpper(), letterCounter);
        }
    }
}
