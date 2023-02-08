using System;
using System.IO;

namespace UebungFileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            #region File lesen
            
            // File lesen und auf Console ausgeben
            var file = @"C:\Temp\Filehandling\Testdatei.txt";

            string[] lines;
            lines = File.ReadAllLines(file);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            
            #endregion

            #region Erstellen eines Verzeichnis

            // Erstellen eines Directory
            DirectoryInfo info= Directory.CreateDirectory(@"C:\Temp\Filehandling\TestVerzeichnis");
            
            #endregion

            #region File verschieben
            
            // File verschieben
            File.Move(@"C:\Temp\Filehandling\Testdatei.txt", @"C:\Temp\Filehandling\TestVerzeichnis\Testdatei.txt");
            
            #endregion

            // Zusatz
            var personList = new PersonList();
            
            // Liste abfüllen mittels string[]
            personList.FillUp(lines);
            
            // List auf Console drucken
            personList.Print();
            
            // neue Person der Liste hinzufügen
            personList.Add(new Person("Knöpfli", "Hansli")
            {
                Strasse = "Hüetliweg",
                HausNr = "12",
                Plz = "9000",
                Ort = "St.Gallen"
            });
            
            // Liste auf Filesystem speichern
            personList.Save(@"c:\temp\neu.txt");
        }

        
    }
}
