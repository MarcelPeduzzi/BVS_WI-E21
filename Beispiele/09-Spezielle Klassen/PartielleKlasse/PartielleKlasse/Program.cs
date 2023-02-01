using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartielleKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde kunde = new Kunde("Hansli");
            kunde.AddGuthaben(34000);
            Console.WriteLine(kunde.Name);



            Kunde2 kunde2 = new Kunde2("Vreneli");
            kunde2.AddGuthaben(50000);
            Console.WriteLine(kunde2.Name);
        }
    }
}
