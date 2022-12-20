using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wertzuweisung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wert-Typ --> Integer");
            int a = 5;
            int b = a;                                      // Zuweisung von Wert
            Console.WriteLine($"a={a}, b={b}");             // Werte von a und b ausgeben
            a = 7;                                          // Wert von a ändern
            Console.WriteLine($"a={a}, b={b}");             // Wert von a und b sind verschieden
            Console.WriteLine("Referenz-Typ --> Array");
            double[] s = { 12, 2.2 };
            double[] t = s;                                 // Zuweisung von Referenz
            Console.WriteLine($"s={s[0]}, t={t[0]}");
            s[0] = 17;                                      // Element des Arrays änder auf den Wert 17
            Console.WriteLine($"s={s[0]}, t={t[0]}");       // s und t sind gleich
            Console.ReadLine();
        }
    }
}
