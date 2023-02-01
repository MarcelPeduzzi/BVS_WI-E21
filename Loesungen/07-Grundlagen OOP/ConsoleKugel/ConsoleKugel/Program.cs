using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKugel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kugelprogramm");
            Console.WriteLine("-------------");

            string berechnungsTyp;
            do
            {
                Console.WriteLine("Wollen Sie das (V)olumen oder den (D)urchmesser einer Kugel berechnen ?");
                berechnungsTyp = Console.ReadKey(true).KeyChar.ToString().ToUpper();
                Console.WriteLine(berechnungsTyp);
            }
            while (berechnungsTyp != "V" && berechnungsTyp != "D");

            if (berechnungsTyp == "V")
            {
                Console.WriteLine("Geben Sie den Durchmesser an:");
                var inputWert = Console.ReadLine();
                Console.WriteLine($"Volumen: {Kugel.Durchmesser_Volumen(inputWert)}");
            }
            else
            {
                Console.WriteLine("Geben Die das Volumen an:");
                var inputWert = Console.ReadLine();
                Console.WriteLine($"Durchmesser: {Kugel.Volumen_Durchmesser(inputWert)}");
            }

            Console.ReadKey();
        }
    }
}

