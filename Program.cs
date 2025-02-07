using System;

namespace Gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            KemKuldetes k1 = new KemKuldetes("007", "Anglia", 100, 10);
            KemKuldetes k2 = new KemKuldetes("001", "Magyarország");
            Console.WriteLine(k1);
            Console.WriteLine(k2);
            System.Console.WriteLine();
            Console.WriteLine(k1.kuldetesInditasa());
            System.Console.WriteLine();
            k2.veszelySzintNovelese(20);
            Console.WriteLine(k2);
            System.Console.WriteLine();
            k1.sikerEsejNovelese(50);
            Console.WriteLine(k1);
            



            // Urhajo();
            // Karakter();
            // Film();
            // Konyv();
        }
        public static void Urhajo(){
            System.Console.WriteLine();
            Urhajo u1 = new Urhajo("Apollo 11", 1000, 10, 50);
            Urhajo u2 = new Urhajo("Apollo 9", 5);
            Console.WriteLine(u1);
            Console.WriteLine(u2);
            System.Console.WriteLine();
            u2.indulas();
            Console.WriteLine(u2);
            System.Console.WriteLine();
            u1.tankolas(20);
            Console.WriteLine(u2);
            System.Console.WriteLine();
            u2.landolas();
            Console.WriteLine(u1);
        }

        public static void Karakter(){
            System.Console.WriteLine();
            Karakter k1 = new Karakter("Gandalf", 100, 1000, 100);
            Karakter k2 = new Karakter("Frodo", 5);
            Console.WriteLine(k1);
            Console.WriteLine(k2);
            System.Console.WriteLine();
            Console.WriteLine(k1.Tamadas());
            Console.WriteLine();
            k2.Gyogyulas(50);
            Console.WriteLine(k2);
            System.Console.WriteLine();
            k1.SzintLepes();
            Console.WriteLine(k1);
        }

        public static void Film(){
            System.Console.WriteLine();
            Film f1 = new Film("Titanic", "James Cameron", 195, "Romantikus", true);
            Film f2 = new Film("Batman", "Christopher Nolan");
            System.Console.WriteLine(f1);
            System.Console.WriteLine(f2);
            System.Console.WriteLine();
            System.Console.WriteLine(f1.Jatszas());
            System.Console.WriteLine();
            f2.MufajModositas("Akció");
            System.Console.WriteLine(f2);
            System.Console.WriteLine();
            f1.HosszNovelese(10);
            System.Console.WriteLine(f1);
        }

        public static void Konyv(){
            System.Console.WriteLine();
            Konyv k1 = new Konyv("A kis herceg", "Antoine de Saint-Exupéry", 1943, 96, 1500);
            Konyv k2 = new Konyv("A Pál utcai fiúk", "Molnár Ferenc");
            Console.WriteLine(k1);
            Console.WriteLine(k2);
            System.Console.WriteLine();
            k1.Arnoveles(500);
            Console.WriteLine(k1);
            System.Console.WriteLine();
            k2.Kedvezmeny(10);
            Console.WriteLine(k2);
            System.Console.WriteLine();
            k1.HanyOldalMaradt(50);
            System.Console.WriteLine(k1);
        }
    }
}