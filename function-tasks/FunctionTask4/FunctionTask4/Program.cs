using System;

namespace FunctionTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxIndex = 0;
            Console.WriteLine("Syötä 10 positiivista lukua: ");
            Console.WriteLine($"Suurin luku oli {Numbers(ref maxIndex)} ja se oli {maxIndex}.");
            Console.ReadKey();
        }
        static int Numbers(ref int maxIndex)
        {
            int nbr = 0;
            int max = 0;
            bool isNumber;
            string output = "";
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}.");
                isNumber = int.TryParse(Console.ReadLine(), out nbr);
                if (isNumber && nbr > 0)
                {
                    output += $"{nbr} ";
                    if (max < nbr)
                    {
                        max = nbr;
                        maxIndex = i + 1;
                    }
                }
                else
                {
                    Console.WriteLine("Väärä syöte! Syötä positiivinen kokonaisluku: ");
                }
            }
            Console.WriteLine($"Syötit seuraavat luvut:\n{output}\n");
            return max;
        }
    }
}
