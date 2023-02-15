using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSample
{
    public class LinqKlasse
    {
        List<Person> _persons;

        public LinqKlasse()
        {
            _persons = new List<Person>()
            {
                new Person(1,"Meier", "Peter", "12.3.1984"),
                new Person(2,"Müller", "Vera", "22.6.1972"),
                new Person(3,"Vogel", "Kurt", "5.8.1990"),
                new Person(4,"Meier", "Susanne", "1.5.1988"),
                new Person(5,"Schmid", "Karin", "4.12.1984"),
            };
        }

        #region Abfrage Syntax

        // Linq mit Abfrage Syntax
        public void LinqMitAbfrageSyntax()
        {
            // Alle Einträge aus der Liste _names die das Wort "Loser" enthalten
            var personWithMeier = from person in _persons
                                  where person.Name == "Meier"
                                  select person;

            Console.WriteLine("Unsortiert");
            Console.WriteLine("----------");
            foreach (var person in personWithMeier)
            {
                person.Print();
            }
            Console.WriteLine();
        }

        // Linq mit Abfrage und Sortierung Syntax
        public void LinqMitAbfrageSyntaxSortiert()
        {
            // Alle Einträge aus der Liste _names die das Wort "Loser" enthalten
            var personWithMeier = from person in _persons
                                  where person.Name == "Meier"
                                  orderby person.Vorname
                                  select person;

            Console.WriteLine("Sortiert");
            Console.WriteLine("--------");
            foreach (var person in personWithMeier)
            {
                person.Print();
            }
            Console.WriteLine();
        }

        // Linq mit Abfrage nach Datum
        public void LinqMitAbfrageSyntaxDatumJahrgang84()
        {
            var personWithJahrgang84 = from person in _persons
                                       where person.Birthday.Year == 1984
                                       select person;

            Console.WriteLine("Jahrgang 1984");
            Console.WriteLine("--------");
            foreach (var person in personWithJahrgang84)
            {
                person.Print();
            }
            Console.WriteLine();
        }

        #endregion

        #region Methoden Syntax
        // Linq mit Methoden Syntax
        public void LinqMitMethodenSyntax()
        {
            // Alle Einträge aus der Liste _names die das Wort "Loser" enthalten
            var personWithMeier = _persons.Where(person => person.Name == "Meier");

            Console.WriteLine("Unsortiert");
            Console.WriteLine("----------");
            foreach (var person in personWithMeier)
            {
                person.Print();
            }

            Console.WriteLine();
        }

        // Linq mit Methoden und Sortierung Syntax
        public void LinqMitMethodenSyntaxSortiert()
        {
            // Alle Einträge aus der Liste _names die das Wort "Loser" enthalten
            var personWithMeier = _persons.Where(person => person.Name == "Meier")
                                        .OrderBy(person => person.Vorname);

            Console.WriteLine("Sortiert");
            Console.WriteLine("--------");
            foreach (var person in personWithMeier)
            {
                person.Print();
            }
            Console.WriteLine();
        }

        // Linq mit Abfrage nach Datum
        public void LinqMitMethodenSyntaxDatumJahrgang84()
        {
            var personWithJahrgang84 = _persons.Where(person => person.Birthday.Year == 1984);

            Console.WriteLine("Jahrgang 1984");
            Console.WriteLine("--------");
            foreach (var person in personWithJahrgang84)
            {
                person.Print();
            }
            Console.WriteLine();
        }
        #endregion
    }


    public class Person
    {
        public Person(int id, string name, string vorname, DateTime birthDay)
        {
            Id = id;
            Name = name;
            Vorname = vorname;
            Birthday = birthDay;
        }

        public Person(int id, string name, string vorname, string birthDayAsString) : this(id, name, vorname, Convert.ToDateTime(birthDayAsString))
        {
        }

        public int Id { get; }
        public string Name { get; set; }
        public string Vorname { get; set; }
        public DateTime Birthday { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Vorname: {Vorname}, Geburtsdatum: {Birthday.ToString("dd.MM.yyyy")}");
        }
    }

}