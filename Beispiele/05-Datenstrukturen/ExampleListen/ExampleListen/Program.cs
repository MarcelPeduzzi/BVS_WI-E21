using System;
using System.Collections;
using System.Collections.Generic;

namespace ExampleListen
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExampleListenIdentischerDatentyp();
            ExampleListenUnterschiedlicherDatentyp();
        }

        static void ExampleListenIdentischerDatentyp()
        {
            List<int> meineListe = new List<int>();
            meineListe.Add(12);
            meineListe.Add(6);
            meineListe.Add(8);
            Console.WriteLine($"Wert 1: {meineListe[0]}");
            Console.WriteLine($"Wert 2: {meineListe[1]}");
            Console.WriteLine($"Wert 3: {meineListe[2]}");
            Console.WriteLine($"Länge: {meineListe.Count}");

            meineListe.Remove(6);
            meineListe[0] = 9;
            Console.WriteLine("Nach Änderung");
            Console.WriteLine($"Wert 1: {meineListe[0]}");
            Console.WriteLine($"Wert 2: {meineListe[1]}");
            Console.WriteLine($"Neue Länge: {meineListe.Count}");

            Console.ReadKey();
        }

        static void ExampleListenUnterschiedlicherDatentyp()
        {
            ArrayList meineListe = new ArrayList();
            meineListe.Add("Super");
            meineListe.Add(true);
            meineListe.Add(8);
            meineListe.Add(34.5);
            Console.WriteLine($"Wert 1: {meineListe[0]}");
            Console.WriteLine($"Wert 2: {meineListe[1]}");
            Console.WriteLine($"Wert 3: {meineListe[2]}");
            Console.WriteLine($"Wert 4: {meineListe[3]}");
            Console.WriteLine($"Länge: {meineListe.Count}");

            meineListe.Remove("Super");
            meineListe[2] = "Genial";
            Console.WriteLine("Nach Änderung");
            Console.WriteLine($"Wert 1: {meineListe[0]}");
            Console.WriteLine($"Wert 2: {meineListe[1]}");
            Console.WriteLine($"Wert 3: {meineListe[2]}");
            Console.WriteLine($"Neue Länge: {meineListe.Count}");

            Console.ReadKey();
        }
    }
}
