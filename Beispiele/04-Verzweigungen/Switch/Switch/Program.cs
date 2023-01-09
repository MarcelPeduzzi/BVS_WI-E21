using System;
using System.Collections;
using System.Collections.Generic;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int monat = 5;
            string output;

            switch (monat)
            {
                case 12:
                case 1:
                case 2:
                    output = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    output = "Frühling";
                    break;
                case 6:
                case 7:
                case 8:
                    output = "Sommer";
                    break;
                case 9:
                case 10:
                case 11:
                    output = "Herbst";
                    break;
                default:
                    output = "kein gültiger Monat!";
                    break;
            }

            Console.WriteLine(output);
        }
    }
}
