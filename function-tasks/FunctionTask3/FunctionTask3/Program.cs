using System;

namespace FunctionTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = NumberFromRange(1,100);
            Print();
        }

        static int NumberFromRange(int lowerBound, int upperBound)
        {
            bool isNumber;
            int input;

            do
            {
                Console.Write($"Syötä luku väliltä {lowerBound} - {upperBound}: ");
                isNumber = int.TryParse(Console.ReadLine(), out input);

                if (isNumber && input >= lowerBound && input <= upperBound)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine($"Väärä syöte!");
                }
            }
            while (true);
        }

        static void Print()
        {
            Console.WriteLine("Luku kelvollinen!");
        }
    }
}
