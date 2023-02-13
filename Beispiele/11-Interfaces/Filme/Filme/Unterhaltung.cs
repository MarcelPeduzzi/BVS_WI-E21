using System;
namespace Filme
{
    public class Unterhaltung : Film
    {
        int Jahr { get; }

        public Unterhaltung(string titel, int laenge, int jahr) : base(titel, laenge)
        {
            this.Jahr = jahr;
        }

        public override void Ausgabe()
        {
            base.Ausgabe();
        
            Console.WriteLine($", aus dem Jahr {this.Jahr}");
        }
    }
}