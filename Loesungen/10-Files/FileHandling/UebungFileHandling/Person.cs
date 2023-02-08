using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungFileHandling
{
    internal class Person
    {
        public string Name { get; set; }    
        public string Vorname { get; set; }
        public string Strasse { get; set; }
        public string HausNr { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }
        
        public Person(string line)
        {
            var attributArray = line.Split(';');
            
            Name = attributArray[0];
            Vorname = attributArray[1];
            Strasse = attributArray[2];
            HausNr = attributArray[3];
            Plz = attributArray[4];
            Ort = attributArray[5];
        }

        public Person(string name, string vorname)
        {
            Name = name;    
            Vorname = vorname;
        }

        // Person auf Console ausgeben
        public void Print()
        {
            Console.WriteLine($"{Vorname} {Name}, {Strasse} {HausNr}, {Plz} {Ort}");
        }

        // Aufbereitung für txt-File
        public override string ToString()
        {
            return $"{Name};{Vorname};{Strasse};{HausNr};{Plz};{Ort}";
        }
    }
}
