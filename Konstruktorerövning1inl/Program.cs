using Konstruktorerövning1inl;
using System;

namespace Konstruktörerövning1inl
{
    class Program
    {
        static void Main(string[] args)
        {
            BILREKGISLTER p1 = new BILREKGISLTER();
            Console.WriteLine("Vilket märke är bilen?");
            p1.brand = Console.ReadLine();
            Console.WriteLine("Vilken model är bilen?");
            p1.model = Console.ReadLine();
            Console.WriteLine("Hur många hästkrafter har bilen?");
            p1.hp = Console.ReadLine();
            Console.WriteLine("Hur många cc är motorn?");
            p1.enginedisplacement = Console.ReadLine();
            Console.WriteLine("Vilket år byggdes bilen?");
            p1.year = Console.ReadLine();

            Console.Write(p1.brand + " ");
            Console.WriteLine(p1.model);
            Console.WriteLine("Hästkrafter: " + p1.hp);
            Console.WriteLine("Motor storlek: " + p1.enginedisplacement);
            Console.WriteLine("År: " + p1.year);
            Console.WriteLine("");


        }
    }
}