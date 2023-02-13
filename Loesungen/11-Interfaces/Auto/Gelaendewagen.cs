using System;

namespace Auto
{
    public interface IGelaendewagen
    {
        void AllradEinschalten();

        void AllradAusschalten();

        bool Allradantrieb { get; }
    }

    public class Gelaendewagen : Auto, IGelaendewagen
    {
        bool _allradEingeschaltet;

        public bool Allradantrieb { get; }

        public Gelaendewagen(int ps, int sn, int ge, bool aa) : base(ps, sn, ge)
        {
            this.Allradantrieb = aa;

            // Defaultwert: Allrad ist Standardmässig eingeschaltet
            _allradEingeschaltet = true;
        }

        public void AllradEinschalten()
        {
            if (AutoFaehrt==true)
            {
                Console.WriteLine("Allrad kann während dem fahren nicht eingeschaltet werden");
                return;
            }

            if (_allradEingeschaltet==true)
            {
                Console.WriteLine("Allrad ist bereits eingeschaltet");
            }
            else
            {
                Console.WriteLine("Allrad wird eingeschaltet ...");
            }

            _allradEingeschaltet = true;
        }

        public void AllradAusschalten()
        {
            if (AutoFaehrt == true)
            {
                Console.WriteLine("Allrad kann während dem fahren nicht ausgeschaltet werden");
                return;
            }

            if (_allradEingeschaltet == true)
            {
                Console.WriteLine("Allrad wird ausgeschaltet ..,");
            }
            else
            {
                Console.WriteLine("Allrad ist bereits ausgeschaltet");
            }

            _allradEingeschaltet = true;
        }
    }
}
