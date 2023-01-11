namespace If_Statement;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Eingabe erste Zahl: ");
        int zahl1 = int.Parse(Console.ReadLine());
        Console.Write("Eingabe zweite Zahl: ");
        int zahl2 = int.Parse(Console.ReadLine());

        if (zahl1 == zahl2)
        {
            Console.WriteLine(zahl1 + " und " + zahl2 + " sind gleich");
        }
        else
        {
            Console.WriteLine(zahl1 + " und " + zahl2 + " sind ungleich");
        }

    }
}

