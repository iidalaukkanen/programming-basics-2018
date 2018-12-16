using System;

namespace Self_evaluationTask1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee syöttämäsi kahden luvun summan, erotuksen sekä jako- ja kertolaskun.");
            Console.WriteLine("Syötä 1. luku: ");

            decimal sum = 0;
            decimal difference = 0;
            decimal division = 0;
            decimal multiplication = 0;
            decimal input01;
            decimal input02;

            while (!decimal.TryParse(Console.ReadLine(), out input01))
            {
                Console.WriteLine("Väärä syöte!");
            }

            Console.Write("Syötä 2. luku: ");
            while (!decimal.TryParse(Console.ReadLine(), out input02))
            {
                Console.WriteLine("Väärä syöte!");
            }

            sum = input01 + input02;
            difference = input01 - input02;
            multiplication = input01 * input02;
            division = input01 / input02;


            Console.WriteLine($"{input01} + {input02} = {sum.ToString("F")}");
            Console.WriteLine($"{input01} - {input02} = {difference.ToString("F")}");
            Console.WriteLine($"{input01} * {input02} = {multiplication.ToString("F")}");
            Console.WriteLine($"{input01} / {input02} = {division.ToString("F")}");
        }
    }
}
