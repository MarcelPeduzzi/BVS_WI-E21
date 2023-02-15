using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqKlasse linqKlasse = new LinqKlasse();

            linqKlasse.LinqMitAbfrageSyntax();

            linqKlasse.LinqMitAbfrageSyntaxSortiert();

            linqKlasse.LinqMitAbfrageSyntaxDatumJahrgang84();

            Console.ReadKey(false);

            linqKlasse.LinqMitMethodenSyntax();

            linqKlasse.LinqMitMethodenSyntaxSortiert();

            linqKlasse.LinqMitMethodenSyntaxDatumJahrgang84();

            Console.ReadKey(false);

        }
    }
}
