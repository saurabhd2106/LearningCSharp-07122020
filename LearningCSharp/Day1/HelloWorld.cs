using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day1
{
    public class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            var a = 10;
            var b = a;
            ++b;


            Console.WriteLine($"Value of a is {a} and value of b is {b}");

        

        }
    }

    
}
