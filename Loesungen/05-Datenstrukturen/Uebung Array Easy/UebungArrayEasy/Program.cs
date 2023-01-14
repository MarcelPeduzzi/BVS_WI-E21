namespace UebungArray1;
class Program
{
    static void Main(string[] args)
    {
        string[] myArray = new string[10];

        myArray[0] = "Detlev";
        myArray[1] = "Olivia";
        myArray[2] = "Kurt";
        myArray[3] = "Susi";
        myArray[4] = "Eugen";
        myArray[5] = "Olav";
        myArray[6] = "Otto";
        myArray[7] = "Anna";
        myArray[8] = "Berth";
        myArray[9] = "Hans";

        Console.Write("Index: ");
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine("Name: " + myArray[index]);

    }
}

