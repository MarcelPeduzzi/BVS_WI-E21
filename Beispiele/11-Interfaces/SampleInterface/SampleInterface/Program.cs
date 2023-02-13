using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Audi = new Car();
            Train Intercity = new Train();
            Human Bill = new Human();

            Master.MoveObject(Audi);
            Master.MoveObject(Intercity);
            Master.MoveObject(Bill);


            Console.ReadKey();
        }
    }

    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Der Auto fährt zur nächsten Ampel.");
        }
    }


    public class Human : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Der Mensch macht einen Schritt vor.");
        }
    }


    public class Train : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Der Zug fährt bis zum nächsten Bahnhof.");
        }
    }

    public class Master
    {
        public static void MoveObject(IMovable item)
        {
            Console.WriteLine("Ein bewegliches Objekt wird bewegt...");
            item.Move();
        }
    }

}
