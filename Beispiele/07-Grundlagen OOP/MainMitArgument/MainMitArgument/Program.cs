using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Es müssen 2 Parameter übergeben werden.");
            }
            else
            {
                Console.WriteLine($"Dein erster Parameter: {args[0]}");

                Console.WriteLine($"Dein zweiter Parameter: {args[1]}");
            }
        }
    }
}
