using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schneckenrennen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Neues Rennen erstellen
            Rennen rennen = new Rennen("Master of Schleim", 1000);

            // Schnecken dem Rennen hinzufügen
            rennen.AddRennschnecke(new Rennschnecke("Harald", "Powerschnecke", 80));
            rennen.AddRennschnecke(new Rennschnecke("Kevin", "Powerschnecke", 80));
            rennen.AddRennschnecke(new Rennschnecke("Eveline", "Turboschnecke", 80));
            rennen.AddRennschnecke(new Rennschnecke("Gertrud", "Turboschnecke", 80));
            rennen.AddRennschnecke(new Rennschnecke("Bill", "Ligthspeeder", 80));

            Console.WriteLine(rennen.ToString());
            Console.ReadKey(true);

            char rennenNochmalsStarten = 'N';
            do
            {
                // Wetten annehmen
                var wettbureo = WettenAbgeben(rennen);

                // Rennen starten
                rennen.Durchfuehren();

                // Gewinner anzeigen
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("*************Gewinner***************");
                Console.WriteLine(rennen.ErmittleGewinner());
                Console.WriteLine("************************************");


                // Gewinnerliste anzeigen
                Console.WriteLine();
                wettbureo.PrintGewinnerliste(rennen.ErmittleGewinner(), rennen);

                // Rennen zurücksetzen
                Console.ResetColor();
                rennen.Zuruecksetzen();

                Console.WriteLine("Rennen nochmals durchführen? J=Ja, alles andere=Nein");
                rennenNochmalsStarten = Console.ReadKey().KeyChar;

            } while (rennenNochmalsStarten == 'J' || rennenNochmalsStarten == 'j');
        }


        // Abgabe der Wetten
        static Wettbuero WettenAbgeben(Rennen rennen)
        {
            Wettbuero wettbuero = new Wettbuero();

            wettbuero.WetteAnnehmen("Spieler1", 45, rennen.GetRennschnecke("Kevin"), rennen);
            wettbuero.WetteAnnehmen("Spieler2", 12, rennen.GetRennschnecke("Eveline"), rennen);
            wettbuero.WetteAnnehmen("Spieler3", 25, rennen.GetRennschnecke("Eveline"), rennen);
            wettbuero.WetteAnnehmen("Spieler4", 27, rennen.GetRennschnecke("Bill"), rennen);

            return wettbuero;
        }
    }
}
