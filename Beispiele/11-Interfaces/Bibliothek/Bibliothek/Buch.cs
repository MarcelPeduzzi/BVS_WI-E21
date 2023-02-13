using System;
namespace Bibliothek
{
    public class Buch : PrintMedium
    {
        private string autor;

        public Buch(string title, string verlag, string autor) : base(title, verlag)
        {
            this.autor = autor;
            Console.Write("--> Buch");
        }

        public override string Info()
        {
            return $"{base.Info()}, Autor: {autor}";
        }
    }
}