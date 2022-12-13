namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dein Name: ");
        var name = Console.ReadLine();
        Console.WriteLine("Hi " + name + ", willkommen in der Welt des Programmierens.");
        Console.WriteLine("");
        Console.WriteLine("Zum beenden Taste drücken");
        Console.ReadKey();
    }
}

