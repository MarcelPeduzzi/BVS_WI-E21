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
        public double Zahl1 { get; }
        public double Zahl2 { get; }

        public Rechner(double zahl1, double zahl2)
        {
            Zahl1 = zahl1;
            Zahl2 = zahl2;
        }

        public double Addieren()
        {
            return Zahl1 + Zahl2;
        }

        public double Subtrahieren()
        {
            return Zahl1 - Zahl2;
        }

        public double Dividieren()
        {
            return Zahl1 / Zahl2;
        }

        public double Multiplizieren()
        {
            return Zahl1 * Zahl2;
        }


    }
}
