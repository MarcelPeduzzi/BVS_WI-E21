using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KundenSample
{
    class Program
    {
        static void Main(string[] args)
        {

            PrivateKunde privateKunde = new PrivateKunde("Herr", "Meier", "9000 St.Gallen");
            privateKunde.StammKunde = true;

            privateKunde.AddGuthaben(100);

            Console.WriteLine(privateKunde.GetAdresse());

            Console.WriteLine(privateKunde.Guthaben);

            FirmenKunde firmenKunde = new FirmenKunde("Herr", "Meier", "Hohl AG");
            firmenKunde.StammKunde = true;
            firmenKunde.AddGuthaben(100);

            Console.WriteLine(firmenKunde.GetAdresse());
            Console.WriteLine(firmenKunde.Guthaben);
        }
    }
}
