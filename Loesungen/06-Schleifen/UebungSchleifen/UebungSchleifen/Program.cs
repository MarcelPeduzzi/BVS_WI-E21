using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumMinimumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Schleife();
            SchleifeMitMittelwert();
        }

        static void Schleife()
        {
            Console.WriteLine("Schleife");
            Console.WriteLine("========");
            string resultat = "";
            for (double d = 35; d >= 20; d = d - 2.5)
            {
                Console.WriteLine(d);
            }
        }

        static void SchleifeMitMittelwert()
        {
            Console.WriteLine("Schleife mit Mittelwert");
            Console.WriteLine("=======================");
            int count = 0;
            double summe = 0.0, mw;

            for (double d = 35; d >= 20; d = d - 2.5)
            {
                Console.WriteLine(d);
                count = count + 1;
                summe = summe + d;
            }

            mw = summe / count;
            Console.WriteLine( "Summe: " + summe );
            Console.WriteLine( "Mittelwert: " + mw );
        }
    }
}
