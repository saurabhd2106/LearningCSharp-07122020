using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class Car : Vehicle
    {
        public Car(int engineSize) : base (engineSize)
        {
            Console.WriteLine("Implicit constructor from Car class");

        }
        public int HoursePower { get; set; }

        public void Accelerate()
        {
            Start();


            Console.WriteLine("Acceleration from Car class");
        }

        public override void Run()
        {
            Console.WriteLine("Run method from child class");
        }

    }
}
