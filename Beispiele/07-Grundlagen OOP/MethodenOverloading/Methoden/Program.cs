using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Ueberladen von Methoden
            //
            var resultatMitInt = MethodeOverload(45);
            Console.WriteLine(resultatMitInt);

            var resultatMitString = MethodeOverload("Oh yeaaah");
            Console.WriteLine(resultatMitString);

            Console.ReadKey(true);
            Console.WriteLine();
        }

        private static int MethodeOverload(int zahl1)
        {
            return zahl1 * 10;
        }

        private static string MethodeOverload(string wert1)
        {
            return ($"Eingabe: {wert1}");
        }
    }
}
