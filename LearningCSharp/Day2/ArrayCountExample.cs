using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day2
{
    class ArrayCountExample
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            int[] arr = new int[100];

            for(int i=0; i < arr.Length; i++)
            {
                arr[i] = random.Next(10);

            }

            int[] count = new int[10];
           
            foreach(var temp in arr)
            {
                Console.WriteLine(temp);
                count[temp]++;
            }

            Console.WriteLine("--------------------------------------");

            var c = 0;
            foreach (var temp in count)
            {
                Console.WriteLine($" The count of {c} is {temp}");
                c++;
            }

        }
    }
}
