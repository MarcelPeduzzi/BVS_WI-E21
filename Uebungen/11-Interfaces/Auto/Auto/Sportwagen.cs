using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public class Sportwagen : Auto
    {
        private bool _isTuned;

        public Sportwagen(int ps, int sn, int ge) : base(ps, sn, ge)
        {
            // Defaultwert
            _isTuned = false;
        }

        public void Tune()
        {
            if (_isTuned == true)
            {
                Console.WriteLine("Sportwagen ist bereits getunded");
            }
            else
            {
                Console.WriteLine("Sportwagen wird getuned");
            }

            _isTuned = true;
        }
    }
}
