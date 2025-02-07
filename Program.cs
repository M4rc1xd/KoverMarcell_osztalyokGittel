using System;

namespace Gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
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



            // Konyv();
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