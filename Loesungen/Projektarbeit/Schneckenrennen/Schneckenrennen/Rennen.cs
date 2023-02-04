using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Schneckenrennen
{
    public class Rennen
    {
        public string Name { get; set; }
        public List<Rennschnecke> Schnecken { get; set; }
        public double Renndistanz { get; set; }

        public Rennen(string name, double renndistanz)
        {
            this.Name = name;
            this.Renndistanz = renndistanz;
            this.Schnecken = new List<Rennschnecke>();
        }

        public void AddRennschnecke(Rennschnecke neueSchnecke)
        {
            if (Schnecken.Contains(neueSchnecke))
            {
                throw new ArgumentException($"Schnecke {neueSchnecke.Name} ist bereits dem Rennen zugeordnet.");
            }
            this.Schnecken.Add(neueSchnecke);
        }

        public void RemoveRennschnecke(string name)
        {
            foreach (var schnecke in this.Schnecken)
            {
                if (schnecke.Name == name)
                {
                    this.Schnecken.Remove(schnecke);
                    break;
                }
            }
        }

        public Rennschnecke GetRennschnecke(string name)
        {
            foreach (var schnecke in this.Schnecken)
            {
                if (schnecke.Name == name)
                {
                    return schnecke;
                }
            }

            throw new ArgumentException($"Schnecke {name} für dieses Rennen nicht gefundn.)");
        }


        public Rennschnecke ErmittleGewinner()
        {
            foreach (var schnecke in this.Schnecken)
            {
                if (schnecke.Strecke >= this.Renndistanz)
                {
                    return schnecke;
                }
            }

            return null;
        }

        private void LasseSchneckenKriechen()
        {
            foreach (var schnecke in this.Schnecken)
            {
                schnecke.Krieche();
            }
        }

        public void Zuruecksetzen()
        {
            foreach (var schnecke in this.Schnecken)
            {
                schnecke.Zurucksetzen();
            }
        }
        public void Durchfuehren()
        {
            //SpinAnimation.Start(50);
            while (ErmittleGewinner() == null)
            {
                LasseSchneckenKriechen();
                Console.WriteLine(new String('-', 60));
            }
            //Thread.Sleep(5000);
            //SpinAnimation.Stop();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rennstrecke: {this.Renndistanz} cm");
            sb.AppendLine(new string('-', 100));
            sb.AppendLine($"Teilnehmende Schnecken am Rennen {this.Name}");
            sb.AppendLine(new string('-', 100));

            sb.AppendLine($"Anzahl Schnecken: {this.Schnecken.Count}").AppendLine();


            foreach (var schnecke in this.Schnecken)
            {
                sb.AppendLine(schnecke.ToString());
            }

            return sb.ToString();
        }
    }
}
