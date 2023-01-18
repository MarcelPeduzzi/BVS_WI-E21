using System;

namespace oop
{

    class Program
    {
        static void Main(string[] args)
        {
            Fahrrad meinFahrrad1 = new Fahrrad("rot");
            meinFahrrad1.laufrad = 28;
            meinFahrrad1.rahmenhoehe = 60;
            meinFahrrad1.fahrradtyp = "Rennrad";
            meinFahrrad1.farbe = "blau";
            meinFahrrad1.preis = 1400;

            meinFahrrad1.Ausgeben();

            Fahrrad meinFahrrad2 = new Fahrrad(45, 2000);
            meinFahrrad2.farbe = "blau";
            meinFahrrad2.Ausgeben();
        }
    }


    class Fahrrad
    {
        public Fahrrad(string initFarbe)
        {
            farbe = initFarbe;
        }

        public Fahrrad(int initRahmenhoehe, int initLaufrad)
        {
            rahmenhoehe = initRahmenhoehe;
            laufrad = initLaufrad;
        }

        public Fahrrad(int initRahmenhoehe, int initLaufrad, string initFarbe)
        {
            rahmenhoehe = initRahmenhoehe;
            laufrad = initLaufrad;
            farbe = initFarbe;
        }

        public int laufrad;
        public int rahmenhoehe;
        public string farbe;
        public string fahrradtyp;
        public double preis;


        public void Ausgeben()
        {
            Console.WriteLine("Laufradgröße: " + laufrad);
            Console.WriteLine("Rahmenhöhe: " + rahmenhoehe);
            Console.WriteLine("Farbe: " + farbe);
            Console.WriteLine("Fahrradtyp: " + fahrradtyp);
            Console.WriteLine($"Preis: {preis} CHF)");

            Console.ReadKey(true);
        }
    }
}