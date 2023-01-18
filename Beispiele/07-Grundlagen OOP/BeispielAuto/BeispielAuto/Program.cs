using System;
using System.Threading;

namespace BeispielAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto audi = new Auto();

            audi.Farbe = "violete";
            audi.Leistung = 20;
            audi.Laenge = 215;

            audi.Fahren();

            // Warte 100 ms
            Thread.Sleep(100);

            audi.Bremsen();

            Console.ReadKey();
        }
    }

    class Auto
    {
        public string Farbe { get; set; }
        public int Leistung { get; set; }
        public int Laenge { get; set; }


        public void Fahren()
        {
            Console.WriteLine($"Auto fährt mit {Leistung} PS");
        }

        public void Bremsen()
        {
            Console.WriteLine("Auto bremst");
        }

        public void Lenken()
        {
            Console.WriteLine("Auto wird gelenkt");
        }
    }
}
