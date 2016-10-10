using System;

namespace FactoryPattern.BasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type car manufacturer");
            var carManf = Console.ReadLine();

            var car = new AutoFactory().CreateInstance(carManf);

            if (car == null)
            {
                Console.WriteLine("Car manufacturer not found");
            }
            else
            {
                car.TurnOn();
                car.TurnOff();
            }

            Console.ReadKey();
        }
    }
}
