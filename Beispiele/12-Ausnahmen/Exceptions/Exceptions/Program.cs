using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //MethodeMitAusnahme(1);
            Console.ReadKey(true);

            //MethodeMitAusnahme(-1);
            Console.ReadKey(true);

            #region Fehler abfangen
            int resultat = Division(12, 0);

            Console.ReadKey(true);
            #endregion

            #region Fehler mit selbstdefinierten Exception
            try
            {
                resultat = DivisionMitParameterUeberpruefung(-2, -4);
            }

            catch (ParameterFehler ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey(true);
            #endregion

            #region finally

            try
            {
                var meineTestObjektFinally = new TestKlasseFinally();
                meineTestObjektFinally.DivisionMethode("a");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Formatfehler: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"DivisionDurch0: {ex.Message}");
            }


            Console.ReadKey(true);
            #endregion
        }

        public static void MethodeMitAusnahme(int p)
        {
            Console.WriteLine($"Beginn der Methode mit Parameter {p}");
            if (p < 0)
            {
                throw new System.Exception();
            }
            Console.WriteLine($"Ende der Methode mit Parameter {p}");
        }

        public static int Division(int a, int b)
        {
            int resultat = 0;

            try
            {
                resultat = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Division von {a} durch {b} ist nicht erlaubt.");
            }
            return resultat;
        }

        public static int DivisionMitParameterUeberpruefung(int a, int b)
        {
            if (a <= 0 || b <= 0)
            {
                string meldung = $"Falsche Inputparameter: a={a}, b={b}";
                throw new ParameterFehler(meldung);
            }

            return a / b;
        }

    }
}
