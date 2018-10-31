using System;

namespace ArrayTask_Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo lauantain lottonumerot ja tulostaa arvtotut luvut");
            int[] lottoNumbers = new int[40];
            Random rnd = new Random();
  

            for (int i = 0; i < 7; i++)
            {
                int rndNumber = rnd.Next(40);
                if (lottoNumbers[rndNumber] == 0)
                    lottoNumbers[rndNumber] = 1;
                else
                    i--;                
            }
            while (true)
            {
                int rndNumber = rnd.Next(40);
                if (lottoNumbers[rndNumber] == 0)
                {
                    lottoNumbers[rndNumber] = 2;
                    break;
                }

               
               
            }
            int plusNumber = rnd.Next(40)+1;
            Console.Write("Loton oikea rivi:");
            for (int i = 0; i < 40; i++)
            {
                if (lottoNumbers[i] == 1)
                    Console.Write($"{i + 1} ");
            }
            
            for (int i = 0; i < 40; i++)
            {
                if (lottoNumbers[i] == 2)
                    Console.WriteLine($"\nLisänumero: {i + 1}\t");
            }
            Console.WriteLine($"Plusnumero: {plusNumber}");
        }
    }
}
