using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumMinimumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 Zufahlszahlen zwische 0 und 100 ausgeben
            Random rd = new Random();

            var randomNumbers = new int[10];

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rd.Next(100);
                Console.WriteLine(randomNumbers[i]);
            }

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                Console.WriteLine(randomNumbers[i]);
            }

            foreach (var item in randomNumbers)
            {
                Console.WriteLine(item);
            }

            // Maximum/Minimumwert ausgeben
            int maxNumber = randomNumbers[0];
            int minNumber = randomNumbers[0];

            foreach (var number in randomNumbers)
            {
                if (number > maxNumber)
                    maxNumber = number;
                if (number < minNumber)
                    minNumber = number;
            }

            Console.WriteLine($"Maximum Nummer: {maxNumber}");
            Console.WriteLine($"Minimum Nummer: {minNumber}");
            Console.ReadKey();

            // Mittelwert
            int total = 0;
            total = randomNumbers.Sum();

            int mittel = total / randomNumbers.Length;

            Console.WriteLine($"Mittelwert: {mittel}");

            Console.ReadKey();
        }
    }
}
