using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class TestKlasseFinally
    {
        public void DivisionMethode(string s)
        {
            try
            {
                int i = int.Parse(s);
                Console.WriteLine($"Division: 2/{i}={2 / i}");
            }
            finally
            {
                Console.WriteLine($"Die Eingabe war: {s}");
            }
        }
    }
}
