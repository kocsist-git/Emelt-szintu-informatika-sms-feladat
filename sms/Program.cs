using System;

namespace sms
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
        }

        private static void task1()
        {
            Console.Write("Elso feladat\nKérek egy betűt: ");
            string bekertBetu = Console.ReadLine();
            string[] betuk = new string[] { "", "", "abc", "dfe", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            for (int i = 0; i < betuk.Length; i++)
            {
                if (betuk[i].Contains(bekertBetu)) Console.WriteLine("Ez a kód tartozik hozzá: " + i);
            }
        }
    }
}
