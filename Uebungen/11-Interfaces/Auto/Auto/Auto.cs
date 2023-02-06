using System;

namespace Auto
{
    public abstract class Auto
    {
        public int Ps { get; }
        public int Startnummer { get; }
        public int Geschwindigkeit { get; set; }

        private bool _autoFaehrt;

        public Auto(int ps, int sn, int ge)
        {
            this.Ps = ps;
            this.Startnummer = sn;
            this.Geschwindigkeit = ge;

            // Default Werte
            _autoFaehrt = false;
        }

        public void Losfahren()
        {
            if (_autoFaehrt == true)
            {
                Console.WriteLine("Auto fährt bereits");
            }
            else
            {
                Console.WriteLine("Auto fährt los ...");
            }

            _autoFaehrt = true;
        }

        public void Anhalten()
        {
            if (_autoFaehrt == true)
            {
                Console.WriteLine("Auto haltet an.");
            }
            else
            {
                Console.WriteLine("Auto ist bereits angehalten");
            }

            _autoFaehrt = false;
        }
    }
}
