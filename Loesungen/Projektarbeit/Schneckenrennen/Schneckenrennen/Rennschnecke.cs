using System;

namespace Schneckenrennen
{
    public class Rennschnecke
    {
        public string Name { get; set; }
        public string Rasse { get; set; }
        public double MaxGeschwindigkeit { get; set; }
        public double Strecke { get; set; }

        public Rennschnecke(string name, string rasse, double maxGeschwindigkeit)
        {
            this.Name = name;
            this.Rasse = rasse;
            this.MaxGeschwindigkeit = maxGeschwindigkeit;
            this.Strecke = 0;
        }


        /*
	     * Bewegt die Schnecke mit einer zufälligen Geschwindigkeit (im Abhängigkeit von der Maximalgeschwindigkeit).
	    */
        public void Krieche()
        {
            // Maximalgeschwindigkeit wird mit 0,01..1 multipliziert
            // und auf ganze cm gerundet
            var random = GenerateRandom.GetRandomValue();
            this.Strecke += Math.Round(this.MaxGeschwindigkeit * random, 0);

            Console.WriteLine($"{this.Name} hat {this.Strecke} cm zurückgelegt.");
        }

        public void Zurucksetzen()
        {
            this.Strecke = 0;
        }
        public override string ToString()
        {
            return $"({this.Name}.{this.Rasse} : Max Speed: {this.MaxGeschwindigkeit}cm/min, zurückgelegte Strecke {this.Strecke})";
        }
    }
}
