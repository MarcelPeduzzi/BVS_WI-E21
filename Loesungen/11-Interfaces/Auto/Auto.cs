using System;

namespace Auto
{
    public abstract class Auto
    {
        public int Ps { get; }
        public int Startnummer { get; }
        public int Geschwindigkeit { get; set; }

        public bool AutoFaehrt { get; set; }

        public Auto(int ps, int sn, int ge)
        {
            this.Ps = ps;
            this.Startnummer = sn;
            this.Geschwindigkeit = ge;

            // Default Werte
            AutoFaehrt = false;
        }

        public void Losfahren()
        {
            if (AutoFaehrt == true)
            {
                Console.WriteLine("Auto fährt bereits");
            }
            else
            {
                Console.WriteLine("Auto fährt los ...");
            }

            AutoFaehrt = true;
        }

        public void Anhalten()
        {
            if (AutoFaehrt == true)
            {
                Console.WriteLine("Auto haltet an.");
            }
            else
            {
                Console.WriteLine("Auto ist bereits angehalten");
            }

            AutoFaehrt = false;
        }
    }
}
