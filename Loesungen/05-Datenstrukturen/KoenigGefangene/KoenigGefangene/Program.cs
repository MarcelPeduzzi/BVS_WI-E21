using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoenigGefangene
{
    class Program
    {
        static void Main(string[] args)
        {
            Verfahren1();
            Verfahren2();
        }

        static void Verfahren1()
        {
            // Default false = alle Türen sind geschlossen
            bool[] tueren = new bool[100];

            // k=0 öffnen, k=1 schließen, k=2 öffnen, k...
            for (int k = 0; k < tueren.Length; k++)
            {
                for (int i = k; i < tueren.Length; i += k + 1)
                    tueren[i] = k % 2 == 0 ? true : false;
            }

            // Ausgeben offene Türen
            int count = 0;
            for (int i = 0; i < tueren.Length; i++)
            {
                if (tueren[i]) // Türe ist offen
                {
                    count++;
                    Console.WriteLine(i + 1);
                }
            }
            Console.WriteLine($"Anzahl offene Türen Verfahren 1: {count}");

            Console.ReadKey();
        }

        static void Verfahren2()
        {
            // Default false = alle Türen sind geschlossen
            bool[] tueren = new bool[100];

            //jede k-te türe öffnen, wenn geschlossen und umgekehrt
            for (int k = 0; k < tueren.Length; k++)
            {
                for (int i = k; i < tueren.Length; i += k + 1)
                    tueren[i] = !tueren[i];
            }

            // Ausgeben offene Türen
            int count = 0;
            for (int i = 0; i < tueren.Length; i++)
            {
                if (tueren[i]) // Türe ist offen
                {
                    count++;
                    Console.WriteLine(i + 1);
                }
            }
            Console.WriteLine($"Anzahl offene Türen Verfahren 2: {count}");

            Console.ReadKey();
        }
    }
}
