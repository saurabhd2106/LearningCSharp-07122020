using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day1
{
    public class DemoEmployee
    {
        public static void Main(string[] args)
        {
            Employee saurabh;

            //new (Instantiate) -- Allocating memory to a variable
            //Employee() (Constructor) -- assigning default values
            saurabh = new Employee();

            saurabh.Salary = 70000;

            saurabh.Bonus = 8000;

            Employee shruti = new Employee();

            shruti.Salary = 80000;

            Console.WriteLine(saurabh.Salary);

            Console.WriteLine("Shruti's Salary - "+ shruti.Salary + "with employee Id : "+ shruti.EmployeeId);

            int saurabhSalary = saurabh.CalculateSalary();

            Console.WriteLine($"Salary of Saurabh {saurabhSalary} with employee Id as : "+ saurabh.EmployeeId );

            //-----------------------------

            Employee chandan = new Employee(5000, 1000);

            chandan.CalculateSalary(50000, 800);
        }
    }
}
