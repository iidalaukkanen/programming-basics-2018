﻿using System;
using System.IO;


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

                case 3:
                    Console.Clear();
                    string basePart = RefBase2();
                    if (LengthChecker1(basePart) == false)
                        break;
                    int amount = Amount();
                    string[] refNumberList = ListMaker(basePart, amount);
                    string[] checkNumberList = new string[refNumberList.Length];
                    for (int i = 0; i < refNumberList.Length; i++)
                    {
                        checkNumberList[i] = Reverse(refNumberList[i]);
                    }
                    for (int i = 0; i < refNumberList.Length; i++)
                    {
                        checkNumberList[i] = CheckNumberCreator(checkNumberList[i]);
                    }
                    for (int i = 0; i < refNumberList.Length; i++)
                    {
                        refNumberList[i] = refNumberList[i] + checkNumberList[i];
                    }
                    for (int i = 0; i < refNumberList.Length; i++)
                    {
                        refNumberList[i] = SpaceMaker(refNumberList[i]);
                    }
                    string path = @"C:\dev\TEMP\referencenumber.txt";
                    FileMaker(refNumberList, path);
                    Console.Clear();
                    Print3(path);
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

        static string RefBase2()
        {
            Console.WriteLine("Kirjoita viitenumeron perusosa:  ");
            return Console.ReadLine();
        }

        static int Amount()
        {
            int i;
            do
            {
                Console.Write("Syötä haluttujen viitenumeroiden määrä:  ");
                while (!int.TryParse(Console.ReadLine(), out i))
                {
                    Console.Clear();
                    Console.WriteLine("Väärä syöte!!");
                    Console.Write("Syötä haluttujen viitenumeroiden määrä:  ");
                }

                if (i < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Luku ei voi olla pienempi kuin 1.");
                }

            }
            while (i < 1);
            return i;
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

        static string[] ListMaker(string s, int a)
        {
            string[] list = new string[a];
            for (int i = 0; i < a; i++)
            {
                list[i] = s + (i + 1).ToString();
            }
            return list;
        }

        static void FileMaker(string[] a, string path)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();
                    using (TextWriter tw = new StreamWriter(path))
                    {
                        tw.WriteLine(a[i]);
                    }
                }

                else if (File.Exists(path))
                {
                    using (var tw = new StreamWriter(path, true))
                    {
                        tw.WriteLine(a[i]);
                    }
                }
            }
        }

        static void PrintTrue(string s)
        {
            Console.WriteLine("OK.");
            Console.WriteLine(s);
        }

        static void PrintFalse()
        {
            Console.WriteLine("Viitenumerosi on väärin!");
        }

        static void Print2(string s)
        {
            Console.WriteLine($"Viitenumerosi on {s}.");
        }

        static void Print3(string p)
        {
            string[] lines = File.ReadAllLines(p);
            Console.WriteLine("Uudet viitenumerosi ovat:\n");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
