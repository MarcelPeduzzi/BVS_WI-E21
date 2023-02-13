using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ParameterFehler :Exception
    {
        public ParameterFehler(string message): base($"Ungültige Parameter: {message}")
        {
            // Fehlermeldung abspeichern 
        }
    }
}
