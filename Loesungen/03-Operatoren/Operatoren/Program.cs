namespace Operatoren;
class Program
{
    static void Main(string[] args)
    {
        int a = 5, b = 10;
        int z = 10, w = 100;
        double x = 1.0, y = 5.7;
        int n1 = 1, n2 = 17;

        Console.WriteLine("a > 0 && b != 10" + " --> " + (a > 0 && b != 10));
        Console.WriteLine("a > 0 || b != 10" + " --> " + (a > 0 || b != 10));
        Console.WriteLine("z != 0 || z > w || w - z == 90" + " --> " + (z != 0 || z > w || w - z == 90));
        Console.WriteLine("z == 11 && z > w || w - z == 90" + " --> " + (z == 11 && z > w || w - z == 90));
        Console.WriteLine("x >= .9 && y <= 5.8" + " --> " + (x >= .9 && y <= 5.8));
        Console.WriteLine("x >= .9 && !(y <= 5.8)" + " -- > " + (x >= .9 && !(y <= 5.8)));
        Console.WriteLine("n1 > 0 && n2 > 0 || n1 > n2 && n2 != 17" + " --> " + (n1 > 0 && n2 > 0 || n1 > n2 && n2 != 17));
        Console.WriteLine("n1 > 0 && (n2 > 0 || n1 > n2) && n2 != 17" + " --> " + (n1 > 0 && (n2 > 0 || n1 > n2) && n2 != 17));
    }
}

