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

            Console.ReadKey(false);

            linqKlasse.LinqMitMethodenSyntax();

            linqKlasse.LinqMitMethodenSyntaxSortiert();

            Console.ReadKey(false);

        }
    }
}
