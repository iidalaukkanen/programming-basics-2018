using System;

namespace IfTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku parillinen vai pariton");
            Console.WriteLine("Syötä numero:");
            string userInput = Console.ReadLine();
            int number = 0;
            int.TryParse(userInput, out number);
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
                if (number == 0)
                    Console.WriteLine($"Numero {number} on nolla!");
                else if (number < 0)
                    Console.WriteLine($"Numero {number} on negatiivinen!");
                else
                    Console.WriteLine($"Numero {number} on positiivinen!");
            if (isNumber)
                if (number % 2 == 0 && number != 0)
                    Console.WriteLine($"Numero {number} on parillinen");
                else if (number == 0)
                    Console.WriteLine($"Numero {number} on jakautumaton");
                else
                    Console.WriteLine($"Numero {number} on pariton");
            else
                Console.WriteLine("Väärä syöte");



        }
    }
}
