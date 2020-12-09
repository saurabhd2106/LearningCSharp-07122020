using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day1
{
    class EnumExample
    {
        public enum BrowserType
        {
            chrome = 1,
            firefox = 2,
            edge= 3
        }

        static void Main(string[] args)
        {
            //Enum

            var browserType = BrowserType.chrome;
            
            Console.WriteLine((int)browserType);

            BrowserType browserTypeAsInt = (BrowserType) 3;

            Console.WriteLine(browserTypeAsInt);

            var secNumber = 10;
            var firstNumber = "20";

           var secondNumber = Convert.ToInt32(firstNumber);

        }
    }
}
