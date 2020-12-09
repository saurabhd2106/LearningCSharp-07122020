using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day2
{
    public class TypeCasting
    {
        public static void Main(string[] args)
        {
            int intVar = 32478;

            long longVar = 372462378723218l;

            //Implicit Conversion
            long var2Long = intVar;

            int var2Int = (int) longVar;

            double varDob = 56.78;

            var2Int = (int) varDob;

            Console.WriteLine($"Int var : {intVar} and longVar {longVar} and Var2Long {var2Long} and var2Int : {var2Int}");

        }
    }
}
