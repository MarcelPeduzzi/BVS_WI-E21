using System;
using System.Collections.Generic;
using System.IO;

namespace UebungFileHandling
{
    internal class PersonList
    {
        // set auf Private damit diese Liste nur innerhabl dieser Klasse
        // befüllt werden kann
        public List<Person> PersonenListe { get; private set; } = new List<Person>();


        // overloading FillUp
        public void FillUp(string filePath)
        {
           var lines = File.ReadAllLines(filePath);
           FillUp(lines);
        }

        // overloading FillUp
        public void FillUp(string[] lines)
        {
            // Zuerst löschen
            PersonenListe.Clear();

            // jetzt abfüllen
            foreach (string line in lines)
            {
                PersonenListe.Add(new Person(line));
            }
        }

        // List auf Console ausgeben
        public void Print()
        {
            foreach (Person person in PersonenListe)
            {
                person.Print();
            }
        }

        // Speicher in ein File
        public void Save(string filePath)
        {
            string[] stringArray = new string[PersonenListe.Count];

            int i = 0;
            foreach(Person person in PersonenListe)
            {
                stringArray[i++] = person.ToString();
            }
            File.WriteAllLines(filePath, stringArray);
        }

        // Person hinzufügen
        public void Add(Person person)
        {
            PersonenListe.Add(person);
        }
    }
}
