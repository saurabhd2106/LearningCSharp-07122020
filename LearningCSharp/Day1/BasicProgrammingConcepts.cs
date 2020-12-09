using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day1
{
    public class BasicProgrammingConcepts
    {
        static void Main(string[] args)
        {

            //Write a code to find greatest out of two numbers

            int firstNumber = 10;

            int secondNumber = 20;

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("First number is greater than second");
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine("Second number is greater than First");
            }
            else
            {
                Console.WriteLine("Both are equal");
            }


            //Write a code to find greatest out of three numbers

            int firNumber = 10;
            int secNumber = 20;
            int thirdNumber = 25;

            // 1. First is greater, second is greater, third is greater
            // 2. When all are equal
            // 3. When firstNumber = second Number > third Number

            if ((firNumber > secNumber) && (firNumber > thirdNumber))
            {
                Console.WriteLine("First Number is greatest");
            }
            else if ((secNumber > firNumber) && (secNumber > thirdNumber))
            {
                Console.WriteLine("Second Number is greatest");
            }

            else if ((secNumber > firNumber) && (secNumber > thirdNumber))
            {
                Console.WriteLine("Second Number is greatest");
            }

            else if ((firNumber == secNumber) && (secNumber > thirdNumber))
            {
                Console.WriteLine("Both First and Second Number are greater than third");
            }

            else
            {
                Console.WriteLine("All are equal");
            }

            //Switch case statement

            int month = 1;

            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                default:
                    Console.WriteLine("Invalid Year");
                    break;
            }


       

    }
       
    }
}
