using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumMinimumArrayOhneIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 Zufahlszahlen zwische 0 und 100 ausgeben
            Random rd = new Random();

            var randomNumbers = new int[10];

            randomNumbers[0] = rd.Next(1, 100);
            randomNumbers[1] = rd.Next(1, 100);
            randomNumbers[2] = rd.Next(1, 100);
            randomNumbers[3] = rd.Next(1, 100);
            randomNumbers[4] = rd.Next(1, 100);
            randomNumbers[5] = rd.Next(1, 100);
            randomNumbers[6] = rd.Next(1, 100);
            randomNumbers[7] = rd.Next(1, 100);
            randomNumbers[8] = rd.Next(1, 100);
            randomNumbers[9] = rd.Next(1, 100);

            Console.WriteLine(randomNumbers[0]);
            Console.WriteLine(randomNumbers[1]);
            Console.WriteLine(randomNumbers[2]);
            Console.WriteLine(randomNumbers[3]);
            Console.WriteLine(randomNumbers[4]);
            Console.WriteLine(randomNumbers[5]);
            Console.WriteLine(randomNumbers[6]);
            Console.WriteLine(randomNumbers[7]);
            Console.WriteLine(randomNumbers[8]);
            Console.WriteLine(randomNumbers[9]);

            int total = 0;
            total += randomNumbers[0];
            total += randomNumbers[1];
            total += randomNumbers[2];
            total += randomNumbers[3];
            total += randomNumbers[4];
            total += randomNumbers[5];
            total += randomNumbers[6];
            total += randomNumbers[7];
            total += randomNumbers[8];
            total += randomNumbers[9];

            // Alternative
            // int total = randomNumbers.Sum();

            Console.WriteLine("Summer:" + total);

            int mittelwert = total / randomNumbers.Length;
            Console.WriteLine("Mittelwert:" + mittelwert);

            Console.ReadKey();
        }
    }
}
