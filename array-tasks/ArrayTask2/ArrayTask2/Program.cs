using System;

namespace ArrayTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo 100 lukua 0-50 väliltä ja tallettaa ne taulukkoon iT." +
                "Arvotut luvut sekä luvuista saatu keskiarvo ilmoitetaan käyttäjälle.");
            decimal[] iT = new decimal[100];
            Random rnd = new Random();

            //lukujen arvonta
            for (int i = 0; i < iT.Length; i++)
            {
                iT[i] = rnd.Next(51);          
            }
            //laske summa ja keskiarvo
            decimal sum = 0;
            for (int i = 0; i < iT.Length; i++)
            {
                sum = sum + iT[i];
            }
            decimal avrg = sum / 100;

            //tulosta vastaus
            for (int i = 0; i < iT.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {iT[i]}");
            }
            Console.WriteLine($"Keskiarvo on {avrg}");

        }
    }
}
