using System;

namespace DepInj2
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
        public Car(Engine newEngine)
        {
            myEngine = newEngine;
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
            // Dependency Injection --> Created an engine --> sent it to car
            TurboEngine myTurbo = new TurboEngine();
            Car myCar = new Car(myTurbo);
            
            myCar.Drive();
        }
    }
}
