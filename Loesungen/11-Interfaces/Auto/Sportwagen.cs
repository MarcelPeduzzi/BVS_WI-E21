using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public interface ISportwagen
    {
        void Tune();
    }

    public class Sportwagen : Auto, ISportwagen
    {
        private bool _isTuned;

        public Sportwagen(int ps, int sn, int ge) : base(ps, sn, ge)
        {
            // Defaultwert
            _isTuned = false;
        }

        public void Tune()
        {
            if (AutoFaehrt == true)
            {
                Console.WriteLine("Das Auto kann während dem fahren nicht getuned werden.");
                return;
            }

            if (_isTuned == true)
            {
                Console.WriteLine("Sportwagen ist bereits getuned");
            }
            else
            {
                Console.WriteLine("Sportwagen wird getuned");
            }

            _isTuned = true;
        }
    }
}
