using System;
using System.Collections;
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
            int zahl1, zahl2, zahl3;

            ////
            //// Aufruf By Value
            ////
            //zahl1 = 10;
            //zahl2 = 20;

            //Console.WriteLine($"zahl1: {zahl1}");
            //Console.WriteLine($"zahl2: {zahl2}");

            //zahl3 = MethodByValue(zahl1, zahl2);

            //Console.WriteLine($"Nach Auruf {nameof(MethodByValue)}");
            //Console.WriteLine($"zahl1: {zahl1}");
            //Console.WriteLine($"zahl2: {zahl2}");
            //Console.WriteLine($"zahl3: {zahl3}");

            //Console.ReadKey(true);
            //Console.WriteLine();










            ////
            //// Aufruf By Reference
            ////
            //zahl1 = 10;
            //zahl2 = 20;

            //Console.WriteLine($"zahl1: {zahl1}");
            //Console.WriteLine($"zahl2: {zahl2}");

            //MethodWithRef(zahl1, ref zahl2);

            //Console.WriteLine($"Nach Auruf {nameof(MethodWithRef)}");
            //Console.WriteLine($"zahl1: {zahl1}");
            //Console.WriteLine($"zahl2: {zahl2}");

            //Console.ReadKey(true);
            //Console.WriteLine();

            //
            // Aufruf By Out
            //
            //zahl1 = 10;
            //zahl2 = 20;

            //Console.WriteLine($"zahl1: {zahl1}");
            //Console.WriteLine($"zahl2: {zahl2}");

            //MethodWithOut(zahl1, zahl2, out zahl3);

            //Console.WriteLine($"Nach Auruf {nameof(MethodWithOut)}");
            //Console.WriteLine($"zahl1: {zahl1}");
            //Console.WriteLine($"zahl2: {zahl2}");
            //Console.WriteLine($"zahl3: {zahl3}");

            //Console.ReadKey(true);
            //Console.WriteLine();

            //
            // Optionaler Parameter
            //
            var resultatOptional = MethodeOptionalerParameter("Bill");
            Console.WriteLine(resultatOptional);

            resultatOptional = MethodeOptionalerParameter("Bill", "Murray");
            Console.WriteLine(resultatOptional);

            Console.ReadKey(true);
            Console.WriteLine();

            //
            // Benannte Parameter
            //
            ArrayList buch = AddBuch(autor: "Douglas Adams", termin: null, titel: "The Hitchhiker's Guide to the Galaxy");

            foreach (var item in buch)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine($"Autor: {buch[1]}");
            //Console.WriteLine($"Titel: {buch[0]}");
            //Console.WriteLine($"Termin: {buch[2]}");

            Console.ReadKey(true);
        }



        private static void MethodWithRef(int zahl1, ref int zahl2)
        {
            zahl1 += zahl1;
        }

        private static void MethodWithOut(int zahl1, int zahl2, out int zahl3)
        {
            zahl3 = zahl1 + zahl2;
        }

        private static int MethodByValue(int zahl1, int zahl2)
        {
            zahl2 += zahl1;

            return zahl2;
        }

        private static string MethodeOptionalerParameter(string vorname, string name = "Du")
        {
            return ($"Hallo {name}");
        }

        private static ArrayList AddBuch(string titel, string autor = "", DateTime? termin = null)
        {
            ArrayList meinBuch = new ArrayList();

            if (termin == null)
            {
                termin = DateTime.Now;
            }

            meinBuch.Add(titel);
            meinBuch.Add(autor);
            meinBuch.Add(termin);

            return meinBuch;
        }
    }
}
