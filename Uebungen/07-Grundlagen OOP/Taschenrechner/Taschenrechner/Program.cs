using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechner meinRechner = new Rechner(30, 20);
            Console.WriteLine(meinRechner.Zahl1 + " + " + meinRechner.Zahl2 + " = " + meinRechner.Addieren());
            Console.WriteLine(meinRechner.Zahl1 + " - " + meinRechner.Zahl2 + " = " + meinRechner.Subtrahieren());
            Console.WriteLine(meinRechner.Zahl1 + " / " + meinRechner.Zahl2 + " = " + meinRechner.Dividieren());
            Console.WriteLine(meinRechner.Zahl1 + " * " + meinRechner.Zahl2 + " = " + meinRechner.Multiplizieren());

            Console.ReadKey(false);
        }
    }

    class Rechner
    {

        public Rechner(double zahl1, double zahl2)
        {
            // Code ...
        }

        // Methoden für die einzelnen Berechnungen
        // ...

    }
}
