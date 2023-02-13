using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Klasse Directory
            //

            // Erstellen eines Directory
            Directory.CreateDirectory(@"c:\temp\Testverzeichnis");

            // Erstellen eines Directory mit Instanz-Methoden
            var directory = new DirectoryInfo(@"c:\temp\Testverzeichnis2");
            directory.Create();


            //
            // Klasse Path
            //

            // Temporärer Pfad des aktuellen User
            var tempPath = Path.GetTempPath();
            Console.WriteLine($"Temp Pfad: {tempPath}");


            Console.ReadKey(true);

            //
            // Klasse File
            //
            string filePath = @"c:\temp\Testverzeichnis\Example.txt";

            // File kopieren
            File.Copy(@".\Resources\Example.txt", filePath);

            // Lesen eines Files
            string[] lines;
            lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey(true);



            // Informationen eines Files lesen
            string creationTime = File.GetCreationTime(@"c:\temp\Testverzeichnis\Example.txt").ToString();
            string lastAccessTime = File.GetLastAccessTime(@"c:\temp\Testverzeichnis\Example.txt").ToString();

            Console.WriteLine($"Erstellungsdatum: {creationTime}");
            Console.WriteLine($"Letzter Zugriff: {lastAccessTime}");
            Console.ReadKey(true);



            // Informationen eines Files mit Instanz-Methoden
            FileInfo myFile = new FileInfo(@"c:\temp\Testverzeichnis\Example.txt");
            creationTime = myFile.CreationTime.ToString();
            lastAccessTime = myFile.LastAccessTime.ToString();

            Console.WriteLine($"Erstellungsdatum: {creationTime}");
            Console.WriteLine($"Letzter Zugriff: {lastAccessTime}");
            Console.ReadKey(true);
        }
    }
} 
