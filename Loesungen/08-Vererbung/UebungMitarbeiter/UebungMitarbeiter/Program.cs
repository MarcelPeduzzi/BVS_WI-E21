using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungMitarbeiter
{
    class Program
    {
        public static void Main(string[] args)
        {
            Mitarbeiter mMichael = new Mitarbeiter("Rüdiger", "Karl-Heinz", 40000);
            Boss bChuck = new Boss("Porsche", "Norris", "Chuck", 999999999);
            Azubi aElton = new Azubi(80, 30, "Murray", "Bill", 250000);

            mMichael.Arbeiten();
            bChuck.Fuehren();
            aElton.Arbeiten();
            aElton.Lernen();

            Console.ReadKey(false);
        }


    }

    public class Mitarbeiter
    {
        public string Name { get; }
        public string Vorname { get; }
        public int Gehalt { get; }


        public Mitarbeiter(string name, string vorname, int gehalt)
        {
            this.Name = name;
            this.Vorname = vorname;
            this.Gehalt = gehalt;
        }

        public virtual void Arbeiten()
        {
            Console.WriteLine(Vorname + ":Ich arbeite!");
        }

        public void Pausieren()
        {
            Console.WriteLine(Vorname + ":Ich chille!");
        }
    }

    public class Boss : Mitarbeiter
    {

        public string Firmenwagen { get; }


        public Boss(string firmenwagen, string name, string vorname, int gehalt) : base(name, vorname, gehalt)
        {
            this.Firmenwagen = firmenwagen;

        }

        public void Fuehren()
        {
            Console.WriteLine(Vorname + ":Ich führe!");
        }
    }

    public class Azubi : Mitarbeiter
    {
        public int Arbeitsstunden { get; }
        public int Schulstunden { get; }

        public Azubi(int arbeitsstunden, int schulstunden, string name, string vorname, int gehalt) : base(name, vorname, gehalt)
        {
            this.Arbeitsstunden = arbeitsstunden;
            this.Schulstunden = schulstunden;
        }

        public void Lernen()
        {
            Console.WriteLine(Vorname + ":Ich lerne " + Schulstunden + " Stunden!");
        }

        public override void Arbeiten()
        {
            Console.WriteLine(Vorname + ":Ich arbeite " + Arbeitsstunden + " Stunden!");
        }
    }
}
