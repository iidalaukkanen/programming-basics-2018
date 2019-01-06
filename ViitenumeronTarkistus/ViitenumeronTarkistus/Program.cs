using System;

namespace ViitenumeronTarkistus
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Clear();
                    string refNumber = RefNumber();
                    if (LengthChecker(refNumber) == false)
                        break;
                    string tmpRefNumber = Reverse(refNumber.Substring(0, refNumber.Length - 1));
                    string checkNumber = CheckNumberCreator(tmpRefNumber);
                    refNumber = SpaceMaker(refNumber);
                    if (Checker(refNumber.Substring(refNumber.Length - 1, 1), checkNumber) == true)
                    {
                        PrintTrue(refNumber);
                    }
                    else
                        PrintFalse();
                    break;

                case 2:
                    Console.Clear();
                    string refNumberBase = RefBase1();
                    if (LengthChecker1(refNumberBase) == false)
                        break;
                    tmpRefNumber = Reverse(refNumberBase);
                    checkNumber = CheckNumberCreator(tmpRefNumber);
                    refNumber = Conjoiner(refNumberBase, checkNumber);
                    refNumber = SpaceMaker(refNumber);
                    Console.Clear();
                    Print2(refNumber);
                    break;
            }
        }

        static void Intro()
        {
            Console.WriteLine("1. Ohjelma tarkistaa kotimaisen viitenumeron.\n2. Ohjelma luo kotimaisen viitenumeron.\n3. Ohjelma luo halutun määrän viitenumeroita.");
        }

        static string RefNumber()
        {
            Console.Write("Syötä viitenumero: ");
            return Console.ReadLine();
        }

        static string RefBase1()
        {
            Console.WriteLine("Syötä viitenumeron perusosa ilman tarkistenumeroa.");
            return Console.ReadLine();
        }

        static bool LengthChecker(string s)
        {
            if (s.Length < 4 || s.Length > 20)
            {
                Console.WriteLine("Viitenumerosi on väärän pituinen!");
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool LengthChecker1(string s)
        {
            if (s.Length < 3 || s.Length > 19)
            {
                Console.WriteLine("Viitenumerosi on väärän pituinen!");
                return false;
            }
            else
            {
                return true;
            }
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static string CheckNumberCreator(string s)
        {
            string checkMark = string.Empty;
            int sum = 0;
            int[] list = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                list[i] = int.Parse(s.Substring(i, 1));
            }

            for (int i = 0; i < list.Length; i++)
            {
                if (i % 3 == 0)
                {
                    list[i] = list[i] * 7;
                }
                else if (i % 3 == 1)
                {
                    list[i] = list[i] * 3;
                }
            }

            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            int difference = (int)(Math.Ceiling(sum / 10.0d) * 10);
            checkMark = (difference - sum).ToString();
            return checkMark;
        }

        static string SpaceMaker(string s)
        {
            int space = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (space > 2)
                    break;
                if (i >= 5 && i % 5 == 0)
                {
                    s = s.Insert(s.Length - i - space, " ");
                    space = space + 1;
                }
            }
            return s;
        }
         
        static bool Checker(string s1, string s2)
        {
            if (s1 == s2)
                return true;
            else
                return false;
        }

        static string Conjoiner(string s1, string s2)
        {
            string s = s1 + s2;
            return s;
        }

        static void PrintTrue(string s)
        {
            Console.WriteLine("OK.");
            Console.WriteLine(s);
        }

        static void PrintFalse()
        {
            Console.WriteLine("Viitenumerosi on väärä.");
        }

        static void Print2(string s)
        {
            Console.WriteLine(s);
        }
    }
}
