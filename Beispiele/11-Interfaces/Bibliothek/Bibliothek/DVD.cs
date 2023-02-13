using System;

namespace Bibliothek
{
    public class DVD : ILeihObjekt
    {
        private int laenge;
        private string titel;

        public DVD(string title)
        {
            this.titel = title;
            Console.WriteLine("--> DVD");
        }

        public DVD(string title, int laenge) : this(title)
        {
            this.laenge = laenge;
        }

        public string Info()
        {
            return "\n" + this.titel;
        }

        public string Info(string s)
        {
            return this.Info() + " " + s + " " + this.laenge;
        }
    }
}

