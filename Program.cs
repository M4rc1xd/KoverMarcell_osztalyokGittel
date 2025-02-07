using System;

namespace Gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
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