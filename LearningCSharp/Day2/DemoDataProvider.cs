using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day2
{
    public class DemoDataProvider
    {
        public static void Main(string[] args)
        {
            DataProvider<int> data = new DataProvider<int>();

            data.Data = 19;

            Console.WriteLine(data.Data);

            DataProvider<string> dataStr = new DataProvider<string>();

            dataStr.Data = "Saurabh";

            Console.WriteLine(dataStr.Data) ;

        }
    }
}
