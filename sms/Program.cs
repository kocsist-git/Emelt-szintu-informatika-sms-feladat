using System;
using System.Collections.Generic;
using System.IO;

namespace sms
{
    class Program
    {
        public static string[] betuk = new string[] { "", "", "abc", "dfe", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        public static List<string> szavak = new List<string>();
        public static List<string> szamkod = new List<string>();
        static void Main(string[] args)
        {
            //task1();
            //task2();
            task3();
            task4();
            task5();
            task6();
            task7();
            task8();
        }

        private static void task8()
        {
            throw new NotImplementedException();
        }

        private static void task7()
        {
            Console.Write("\nHetedik feladat\nKérek egy számsort: ");
            int szamsor = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEzek a szók tartoznak hozzá");
            for (int i = 0; i < szamkod.Count; i++)
            {
                if (szamsor.ToString() == szamkod[i]) Console.WriteLine(szavak[i]);
            }        
        }

        private static void task6()
        {
           
            
            for (int j = 0; j < szavak.Count; j++)
            {
                string szamsor = "";
                for (int k = 0; k < szavak[j].Length; k++)
                {
                    for (int i = 2; i < betuk.Length; i++)
                    {
                        if (betuk[i].Contains(szavak[j][k]))
                        {
                            szamsor += i;
                        }
                    }
                }
                szamkod.Add(szamsor);                
            }

            StreamWriter sw = new StreamWriter("kodok.txt");
            foreach (var item in szamkod)
            {
                sw.WriteLine(item);
            }

            sw.Flush();
            sw.Close();         

        }

        private static void task5()
        {
            List<string> rovidszo = new List<string>();

            foreach (var item in szavak)
            {
                if (item.Length <= 5) rovidszo.Add(item);
            }

            Console.WriteLine("\nÖtödik feladat\nRövid szavak száma: " + rovidszo.Count);
        }

        private static void task4()
        {
            int leghosszabb = 0;
            string neve = "";
            foreach (var item in szavak)
            {
                if (item.Length > leghosszabb)
                {
                    leghosszabb = item.Length;
                    neve = item;
                }
            }
            Console.WriteLine("\nNegyedik feladat\nA leghosszabb szó: " + neve + "\nHossza: " + leghosszabb + " karakter");
        }

        private static void task3()
        {
            StreamReader sr = new StreamReader("szavak.txt");
            while (!sr.EndOfStream)
            {
                szavak.Add(sr.ReadLine());
            }
        }

        private static void task2()
        {
            Console.Write("\nMásodik feladat\nKérek egy szót: ");
            string bekertSzo = Console.ReadLine();
            string szamsor = "";
            for (int j = 0; j < bekertSzo.Length; j++)
            {
                for (int i = 2; i < betuk.Length; i++)
                {
                    if (betuk[i].Contains(bekertSzo[j]))
                    {
                        szamsor += i;  
                    }
                }
                    
            }
            Console.WriteLine(szamsor);

        }

        private static void task1()
        {
            Console.Write("Elso feladat\nKérek egy betűt: ");
            string bekertBetu = Console.ReadLine();
            
            for (int i = 2; i < betuk.Length; i++)
            {
                if (betuk[i].Contains(bekertBetu)) Console.WriteLine("Ez a kód tartozik hozzá: " + i);
            }
        }
    }
}
