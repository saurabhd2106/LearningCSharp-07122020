using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day1
{
    public class Program
    {
   

        static void Main(string[] args)
        {

            //byte -- 1, short -- 2, int - 4,long - 8

            int firstNumber = 10;

            Console.WriteLine("First Number : " + firstNumber);

            Console.WriteLine("Min value of int : " + int.MinValue);
            Console.WriteLine("Max value of int : " + int.MaxValue);

            long lonNumber = 3757892347589l;


            Console.WriteLine("Long Number : " + lonNumber);

            Console.WriteLine("Min value of long : " + long.MinValue);
            Console.WriteLine("Max value of long : " + long.MaxValue);

            byte byteVariable;


            //float - 4, double -- 8, decimal - 16
            float floatVar = 5647.437f;

            Console.WriteLine("Min value of float : " + float.MinValue);
            Console.WriteLine("Max value of float : " + float.MaxValue);

            double dobVariable = 4785.4578;

            Console.WriteLine("Min value of double : " + double.MinValue);
            Console.WriteLine("Max value of double : " + double.MaxValue);


            decimal decVariable = 7348.7548m;


            //char - 2 Byte

            char charVar = 'Y';

            //bool
            bool booleanVar = true;

            string str;

            str = "    My Name is Saurabh      ";

            Console.WriteLine("STring - "+ str);
            Console.WriteLine("Length of Str - "+ str.Length);

            //Removes the white space from start and end
            str = str.Trim();

            Console.WriteLine("STring - " + str);
            Console.WriteLine("Length of Str - " + str.Length);

            str =  str.Replace("Saurabh", "Chandan");
            Console.WriteLine("STring - " + str);
            Console.WriteLine("Length of Str - " + str.Length);

            str = str.ToUpper();

            Console.WriteLine("STring - " + str);

            str = str.ToLower();
            bool status = str.Contains("name");

            Console.WriteLine(str.IndexOf('n'));

            Console.WriteLine(status);

            string name = "Saurabh";
            int employeeId = 7485734;

            Console.WriteLine($"Name : {name} and employeeId is {employeeId}");
            Console.WriteLine("Name : {0} and employeeId is :{1}", name, employeeId);

           string message = String.Format("Name : {0} and employeeId is :{1}", name, employeeId);

            Console.WriteLine(message);
        }
    }
}
