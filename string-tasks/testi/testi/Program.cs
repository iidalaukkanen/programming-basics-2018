using System;

namespace exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            AllCheck("131052-308T", 131052308);
        }

        static void AllCheck(string id, int fullNumber)
        {
            string checkId = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            int idModulo = fullNumber % 31;
            if (id[10] != checkId[idModulo])
                Console.WriteLine("Henkilötunnus on virheellinen.");
            else
                Console.WriteLine($"Henkilötunnuksen {id} oikea tarkaste on: {checkId[idModulo]}.");
        }

    }
}