﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_10_18_02_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.feladat

            string jelszo = "";

            Console.WriteLine("Kérem a jelszót: ");
            jelszo = Console.ReadLine();

            while (jelszo.Length < 8) 
            {
                Console.WriteLine("A jelszó nem felel meg a kritériumoknak, próbálja újra: ");
                jelszo = Console.ReadLine();
            }

            Console.WriteLine("Jelszó elfogadva!");
        }
    }
}
