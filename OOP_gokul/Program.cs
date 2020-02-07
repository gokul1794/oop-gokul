using System;

namespace OOP_gokul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car = new Car();
            Console.WriteLine(car.colour);
            car.fullThrottle();

            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.colour = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.colour = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);

            Car toyota = new Car();
            Console.WriteLine(car.model);

            Car AstonMartin = new Car("Aston Martin");
            Console.WriteLine(AstonMartin.model);

            Car Ford1 = new Car("Mustang", "Red", 1969);
            Console.WriteLine(Ford1.colour + " " + Ford1.year + " " + Ford1.model);

        }
    }
}
