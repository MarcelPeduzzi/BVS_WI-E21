using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSample
{
    public class LinqKlasse
    {
        List<string> _names;

        public LinqKlasse()
        {
            _names = new List<string>() 
            { 
                "John Doe", 
                "Jane Loser", 
                "Jenna Doe", 
                "Joe Loser" };
        }



        /// <summary>
        /// Linq mit Abfrage Syntax
        /// </summary>
        public void LinqMitAbfrageSyntax()
        {
            // Alle Einträge aus der Liste _names die das Wort "Loser" enthalten
            var namesWithLoser = from name in _names
                                 where name.Contains("Loser")
                                 select name;


            Console.WriteLine("Unsortiert");
            Console.WriteLine("----------");
            foreach (var name in namesWithLoser)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Linq mit Abfrage Syntax
        /// </summary>
        public void LinqMitAbfrageSyntaxSortiert()
        {
            // Alle Einträge aus der Liste _names die das Wort "Loser" enthalten
            var namesWithLoser = from name in _names    
                                 where name.Contains("Loser")
                                 orderby name
                                 select name;

            Console.WriteLine("Sortiert");
            Console.WriteLine("--------");
            foreach (var name in namesWithLoser)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Linq mit Methoden Syntax
        /// </summary>
        public void LinqMitMethodenSyntax()
        {
            // Alle Einträge aus der Liste _names die das Wort "Loser" enthalten
            var namesWithLoser = _names.Where(name => name.Contains("Loser"));

            Console.WriteLine("Unsortiert");
            Console.WriteLine("----------");
            foreach (var name in namesWithLoser)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Linq mit Methoden Syntax
        /// </summary>
        public void LinqMitMethodenSyntaxSortiert()
        {
            // Alle Einträge aus der Liste _names die das Wort "Loser" enthalten
            var namesWithLoser = _names.Where(name => name.Contains("Loser"))
                                        .OrderBy(name => name);

            Console.WriteLine("Sortiert");
            Console.WriteLine("--------");
            foreach (var name in namesWithLoser)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
    }
}