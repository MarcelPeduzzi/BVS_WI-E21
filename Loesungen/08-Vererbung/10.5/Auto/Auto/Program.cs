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
            Auto meinAuto = new Auto(320, 23, 220);
            Gelaendewagen meinGelaendewagen = new Gelaendewagen(400, 42, 85, true);

            Console.WriteLine($"Aktuelle Geschwindigkeit des Autos: {meinAuto.Geschwindigkeit}");
            meinAuto.Geschwindigkeit = 200;
            Console.WriteLine($"Neue Geschwindigkeit des Autos: {meinAuto.Geschwindigkeit}");
            Console.WriteLine($"Aktuelle Geschwindigkeit des Geländewagens: {meinGelaendewagen.Geschwindigkeit}");
            Console.WriteLine($"Allradantrieb vorhanden: {meinGelaendewagen.Allradantrieb}");

            Console.ReadKey();
        }
    }
}
