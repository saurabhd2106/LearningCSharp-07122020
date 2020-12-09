using LearningCSharp.Day1;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day2
{
    public class ListExample
    {
        public static void Main(string[] args)
        {

            List<int> numbers = new List<int>();

            numbers.Add(23);
            numbers.Add(53);
            numbers.Add(33);
            numbers.Add(623);
            numbers.Add(263);
            numbers.Add(293);
            numbers.Add(223);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(numbers[0]);

            int[] arr = new int[5];

            arr[0] = 23;

            arr[1] = 56;

            arr[2] = 78;

            arr[3] = 74;

            arr[4] = 79;

            numbers.AddRange(arr);

            numbers.Reverse();
            Console.WriteLine("------------------------------------------------");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            Employee saurabh = new Employee();
            Employee shruti = new Employee();

            List<Employee> employees = new List<Employee>();

            employees.Add(saurabh);

            employees.Add(shruti);

        }
    }
}
