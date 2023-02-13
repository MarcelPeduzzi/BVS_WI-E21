using System;
namespace Bibliothek
{
    public abstract class PrintMedium : ILeihObjekt
    {
        private string title;
        private string verlag;
        private int seiten;

        public PrintMedium(string title, string verlag)
        {
            this.title = title; this.verlag = verlag;

            Console.Write("--> PrintMedium");
        }
        public PrintMedium(string title, string verlag, int seiten) : this(title, verlag)
        {
            this.seiten = seiten;
        }

        public virtual string Info()
        {
            return $"\n {this.title} des Verlags {this.verlag}";
        }

        public virtual string Info(string s)
        {
            return this.Info() + s + this.seiten;
        }
    }
}

