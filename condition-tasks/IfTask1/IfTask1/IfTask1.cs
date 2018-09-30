using System;

namespace IfTask1
{
    // This one line comment
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Ohjelma selvittää, onko annettu luku positiivinen, negatiivinen vai nolla");
            Console.Write("Syötä luku: ");
            String userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            Console.WriteLine($"Syötit numeron {userInput}");

            if (number == 0)
                Console.WriteLine($"Numero {number} on nolla!");
            else if (number < 0)
                Console.WriteLine($"Numero {number} on negatiivinen!");
            else
                Console.WriteLine($"Numero {number} on positiivinen!");

            
        }
    }
}
