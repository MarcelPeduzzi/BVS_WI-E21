using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliothek;

namespace Filme
{
    class Program
    {
        static void Main(string[] args)
        {

            DVD dvd1 = new DVD("Herr der Ringe", 240);
            Buch buch1 = new Buch("Harry Potter", "Ein Verlag", "Joanne Kathleen Rowling");


            Console.WriteLine(dvd1.Info());
            Console.WriteLine(buch1.Info());

            Console.ReadKey();
        }
    }
}
