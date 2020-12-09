using System;

namespace LearningCSharp.Day2
{
    public class ArrayExample
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];

            arr[0] = 23;

            arr[1] = 56;

            arr[2] = 78;

            arr[3] = 74;

            arr[4] = 79;

            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }


            Console.WriteLine("Max Value : " + max);

            Console.WriteLine("------------------------------------------");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            int num =5;
            while(num < arr.Length)
            {
                Console.WriteLine(arr[num]);

                num++;
            }

            Console.WriteLine("------------------------------------------");

            int count = 0;
            do
            {
                Console.WriteLine(arr[count]);

                count++;

            } while (count < arr.Length);

            object[] name = new object[5];

            name[0] = "Saurabh";
            name[1] = 78;

        }
    }
}
