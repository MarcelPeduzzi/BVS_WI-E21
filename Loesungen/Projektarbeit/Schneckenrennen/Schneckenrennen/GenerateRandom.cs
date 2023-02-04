using System;

namespace Schneckenrennen
{
    public static class GenerateRandom
    {
        static Random _random = new Random();

        public static double GetRandomValue()
        {
            return (_random.Next(100) + 1) / 100d;
        }
    }
}
