using System;

namespace DependencyInjection
{
    public class Engine
    {
        public virtual void Run()
        {
            Console.WriteLine("Engine is running!");
        }
    }

    class EconomyEngine : Engine
    {
        public override void Run()
        {
            Console.WriteLine("Economy engine is running!");
        }
    }

    class TurboEngine : Engine
    {
        public override void Run()
        {
            Console.WriteLine("Turbo engine is running!");
        }
    }


    public class Car
    {
        Engine myEngine;
        public Car(string engineType)
        {
            if (engineType.ToLower() == "economy")
            {
                myEngine = new EconomyEngine();
            }
            else if (engineType.ToLower() == "turbo")
            {
                myEngine = new TurboEngine();
            }
        }
        public void Drive()
        {
            Console.WriteLine("Car is starting up...");
            myEngine.Run();
            Console.WriteLine("Car is driving!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car("turbo");
            ford.Drive();
        }
    }
}
