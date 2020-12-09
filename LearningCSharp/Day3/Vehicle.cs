using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class Vehicle
    {
        public Vehicle(int engineSize)
        {

            this.engineSize = engineSize;

            Console.WriteLine(engineSize);

            Console.WriteLine("Implicit constructor from Vehicle class");
        }

        private int engineSize;

        public static int vehicleNumber;

        public int EngineSize { get; set; }

        public void Start()
        {
            Console.WriteLine("Start Method in Vehicle");
        }

        public virtual void Run()
        {
            Console.WriteLine("Run Method in Vehicle");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Method in Vehicle");
        }
    }
}
