using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportwagen meinSportwagen = new Sportwagen(320, 23, 220);
            Gelaendewagen meinGelaendewagen = new Gelaendewagen(400, 42, 85, true);

            Console.WriteLine($"Aktuelle Geschwindigkeit des Sportwagen: {meinSportwagen.Geschwindigkeit}");
            meinSportwagen.Geschwindigkeit = 200;
            Console.WriteLine($"Neue Geschwindigkeit des Sportwagen: {meinSportwagen.Geschwindigkeit}");
            Console.WriteLine($"Aktuelle Geschwindigkeit des Geländewagens: {meinGelaendewagen.Geschwindigkeit}");
            Console.WriteLine($"Allradantrieb vorhanden: {meinGelaendewagen.Allradantrieb}");

            meinSportwagen.Tune();

            meinSportwagen.Losfahren();
            meinGelaendewagen.AllradAusschalten();

            meinGelaendewagen.Losfahren();
            meinGelaendewagen.Losfahren();

            meinSportwagen.Anhalten();
            meinGelaendewagen.Anhalten();

            Console.ReadKey();
        }
    }
}
