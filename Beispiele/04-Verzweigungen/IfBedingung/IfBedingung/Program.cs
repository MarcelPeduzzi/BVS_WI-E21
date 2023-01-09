using System;
using System.Collections;
using System.Collections.Generic;

namespace IfBedingung
{
    class Program
    {
        static void Main(string[] args)
        {
            int note = 4;
            string output;

            if (note == 6)
            {
                output = "sehr gut!";
            }
            else if (note == 5)
            {
                output = "gut";
            }
            else if (note == 4)
            {
                output = "genügend";
            }
            else if (note == 3)
            {
                output = "ungenügend";
            }
            else if (note == 2)
            {
                output = "schlecht";
            }
            else if (note == 1)
            {
                output = "Schade sind wir nicht in Deutschland";
            }
            else
            {
                output = "ungültige Note";
            }

            Console.WriteLine(output);
        }
    }
}
