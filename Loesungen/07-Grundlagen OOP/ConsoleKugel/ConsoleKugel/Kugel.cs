using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKugel
{
    public static class Kugel
    {
        private static double Pi = Math.PI;

        public static double Durchmesser_Volumen(string durchmesser)
        {
            double dur = double.Parse(durchmesser);
            
            return Durchmesser_Volumen(dur);
        }

        public static double Durchmesser_Volumen(double durchmesser)
        {
            double vol = Math.Pow(durchmesser, 3) * Pi / 6.0;
            return vol;
        }

        public static double Volumen_Durchmesser(string volumen)
        {
            double vol = double.Parse(volumen);
            double dur = Math.Pow(6 / Pi * vol, 1 / 3.0);
            return dur;
        }
    }
}