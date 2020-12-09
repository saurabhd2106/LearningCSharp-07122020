using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class DemoVehicle
    {
        static void Main(string[] args)
        {

            Vehicle vehicle = new Vehicle(500);

            vehicle.EngineSize = 700;

            vehicle.Start();

            vehicle.Run();

            vehicle.Stop();

            Console.WriteLine(vehicle.EngineSize);

            Vehicle.vehicleNumber = 900;


            Console.WriteLine("--------------------------------------------------------");

            Car alto = new Car(600);

            alto.Start();

            alto.Run();

            alto.Accelerate();

            Car.vehicleNumber = 7834;


            Console.WriteLine("--------------------------------------------------------");

            Vehicle bmw = new Car(800);

            bmw.Start();

            bmw.Run();

            bmw.Stop();

            bmw.EngineSize = 9000;

            Console.WriteLine("--------------------------------------------------------");
            



        }
    }
}
