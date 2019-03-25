﻿using System;

namespace GyufaKonya
{
    class Program
    {
        private static int gyufaszam = 20;
        static void Main(string[] args)
        {
            // gyufaszámból elveszünk 1/2/3 db-t > input amig a gyufaszam > 0
            // i a játékos szám
            for (int i = 0; gyufaszam > 0; i++)
            {
                Console.WriteLine("Játékos szama: {0}", (i%2)+1);
                int gyufaminusz = AdatBekeres("Add meg hany gyufat vennél el");
                gyufaszam -= gyufaminusz;
                Console.WriteLine("Gyufák száma: {0}", gyufaszam);
                if (gyufaszam <= 0)
                { 
                    Console.WriteLine("Vesztes szama: {0}", (i % 2 + 1));
                }
            }
            Console.WriteLine("Játék vége");
            Console.ReadKey();
        }
        // berkéi a gyufaszálak számát
        private static int AdatBekeres(string szoveg = "Add meg az adatot!")
        {
            int adat = default(int);
            Console.WriteLine(szoveg);
            string adatbe = Console.ReadLine();
            try
            {
                adat = Convert.ToInt32(adatbe);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Hibás adat: {0}", e.Message);
                Console.WriteLine("Próbáld meg újra!");
                adat = AdatBekeres(szoveg);
            }
            if (adat < 1 || adat > 3)
            {
                Console.WriteLine("Hibás adat");
                Console.WriteLine("Próbáld meg újra!");
                adat = AdatBekeres(szoveg);
            }
            return adat;
        }
    }
}
