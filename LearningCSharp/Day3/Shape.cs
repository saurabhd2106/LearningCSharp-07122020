using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public abstract class Shape
    {
        public double CalculateVolume(double side, double height)
        {
            double volume =  CalculateArea(side) * height;

            return volume;

        }

        public abstract double CalculateArea(double side);

    }
}
