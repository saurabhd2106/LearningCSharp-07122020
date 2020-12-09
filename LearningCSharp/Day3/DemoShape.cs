using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class DemoShape
    {
        static void Main(string[] args)
        {
            Shape cube = new Cuboid();

            Cuboid cuboid = new Cuboid();

            double cuboidVolume = cuboid.CalculateVolume(10, 10);

            Console.WriteLine($"Cuboid volume is {cuboidVolume}");

            Cylinder cylinder = new Cylinder();

            double cylinderVolume = cylinder.CalculateVolume(10, 10);

            Console.WriteLine($"Cylinder volume is {cylinderVolume}");
        }
    }
}
