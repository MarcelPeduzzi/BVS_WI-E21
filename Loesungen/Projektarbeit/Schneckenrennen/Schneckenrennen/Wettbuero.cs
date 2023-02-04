using System;
using System.Collections.Generic;

namespace Schneckenrennen
{
    public class Wettbuero
    {
        const int GewinnFaktor = 5; // Faktor mit dem der Gewinneinsatz multipliziert wird

        // Liste aller eingegangen Wetten
        public List<Wette> Wetten { get; private set; } = new List<Wette>();


        // Wette abgeben
        public void WetteAnnehmen(string spieler, decimal einsatz, Rennschnecke rennschnecke, Rennen rennen)
        {
            Wetten.Add(new Wette(spieler, einsatz, rennschnecke, rennen));
        }


        // Liste der Gewinner ausgeben
        public void PrintGewinnerliste(Rennschnecke siegerSchnecke, Rennen rennen)
        {
            Console.WriteLine("*************Gewinner Wettbüro***************");

            var gewinnerListe = GewonneneWetten(siegerSchnecke, rennen);

            foreach (var wette in gewinnerListe)
            {
                Console.WriteLine(wette);
            }

        }

        // Ermitteln der Sieger-Wetten
        private List<Wette> GewonneneWetten(Rennschnecke siegerSchnecke, Rennen rennen)
        {
            List<Wette> gewonneneWetten = new List<Wette>();

            foreach (var wette in Wetten)
            {
                if (wette.Rennen == rennen && wette.Rennschnecke == siegerSchnecke)
                {
                    wette.Gewinn = GewinnFaktor * wette.Einsatz;
                    gewonneneWetten.Add(wette);
                }
            }

            return gewonneneWetten;
        }
    }
}

