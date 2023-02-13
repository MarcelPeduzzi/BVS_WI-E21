using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filme
{
    class Program
    {
        static void Main(string[] args)
        {
            Film[] liste = new Film[7];
            liste[0] = new Dokumentation("Der 13.", 100, "Sozial und Kultur");
            liste[1] = new Dokumentation("Durch die Wand", 100, "Sport");
            liste[2] = new Dokumentation("Jane", 90, "Natur");
            liste[3] = new Unterhaltung("Das Leben des Brian", 94, 1979);
            liste[4] = new Unterhaltung("The Big Lebowski", 117, 1998);
            liste[5] = new Unterhaltung("Inglourious Basterds", 153, 2009);
            liste[6] = new Kurzfilm("Sehr sehr kurz", 2, false);
            Array.Sort(liste);

            foreach (Film film in liste)
            {
                film.Ausgabe();
            }

            Console.ReadKey();
        }
    }
}
