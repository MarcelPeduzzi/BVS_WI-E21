using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartielleKlasse
{
    /// <summary>
    /// Ein File mit 3 Partial Klassen für Kunde
    /// </summary>
    /// 


    // Konstruktor
    public partial class Kunde
    {
        public Kunde(string name)
        {
            Name = name;
        }
    }

    // Eigenschaften
    public partial class Kunde
    {
        public string Name { get; protected set; }
        public double Guthaben { get; protected set; }
    }

    // Methoden
    public partial class Kunde
    {
        public void AddGuthaben(double betrag)
        {
            Guthaben += betrag;
        }
    }
}
