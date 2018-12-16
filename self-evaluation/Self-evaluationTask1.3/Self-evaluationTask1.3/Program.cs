using System;

namespace Self_evaluationTask1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee syötettyjen lukujen summan, kunnes syötät luvun -1.");
            Console.WriteLine("Syötä lukuja: ");
            int userInput;
            int sum = 0;
            do
            {
                while (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Väärä syöte!");
                }

                sum = sum + userInput;
            }
            while (userInput != -1);

            Console.WriteLine($"Lukujen summa on {sum}.");
        }
    }
}
