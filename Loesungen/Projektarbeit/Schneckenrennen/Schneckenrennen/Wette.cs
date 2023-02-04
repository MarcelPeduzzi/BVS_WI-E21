using System;
namespace Schneckenrennen
{
    public class Wette
    {
        public Wette(string spieler, decimal einsatz, Rennschnecke rennschnecke, Rennen rennen)
        {
            Spieler = spieler;
            Einsatz = einsatz;
            Rennschnecke = rennschnecke;
            Rennen = rennen;
        }

        public string Spieler { get; set; }
        public decimal Einsatz { get; set; }
        public Rennschnecke Rennschnecke { get; set; }
        public Rennen Rennen { get; set; }
        public decimal Gewinn { get; set; }


        public override string ToString()
        {
            return $"{Spieler} hat {Gewinn} gewonnen";
        }
    }
}

