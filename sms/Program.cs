using System;

namespace sms
{
    class Program
    {
        public static string[] betuk = new string[] { "", "", "abc", "dfe", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        static void Main(string[] args)
        {
           // task1();
            task2();
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
