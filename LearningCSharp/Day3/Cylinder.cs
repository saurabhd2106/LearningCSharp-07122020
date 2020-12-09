using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day3
{
    public class Cylinder : Shape
    {
        public override double CalculateArea(double side)
        {

            double area = Math.PI * side * side;

            return area;
        }

    }
}
