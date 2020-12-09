using System;
using System.Collections.Generic;
using System.Text;

namespace LearningCSharp.Day1
{
    public class Employee
    {
        public Employee()
        {

            _salary = 1000;
            _salary = 500;

            Console.WriteLine($"Default value of salary is {_salary} and bonus is {_salary}");

            this.EmployeeId = employeeIdStartSeries;

            employeeIdStartSeries++;

        }

        public Employee(int Salary, int Bonus)
        {

            _salary = Salary;
            _bonus = Bonus;

            Console.WriteLine($"Default value of salary is {Salary} and bonus is {Bonus}");

            this.EmployeeId = employeeIdStartSeries;

            employeeIdStartSeries++;
        }

        public int EmployeeId { get; }

        private static int employeeIdStartSeries = 10000;

        //fields
        private int _salary;

        private int _bonus;

        //Properties
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if(value > 0) 
                {
                    _salary = value;
                }
                
            }
        }

        public int Bonus { 
            get
            {
                return _bonus;
            }
            set
            {
                _bonus = value;
            }

        }

        

        public int GetSalary()
        {
            return _salary;
        }

        //Standard Getter
        public int GetBonus()
        {
            return _bonus;
        }


        //Standard Setter
        public void SetSalary(int salary)
        {
            if(salary>0)
            {
                _salary = salary;
            }
            else
            {
                Console.WriteLine("Invalid Salary");
            }

        }

        public void SetBonus(int bonus)
        {
            if (bonus > 0)
            {
                _bonus = bonus;
            }
            else
            {
                Console.WriteLine("Invalid Bonus");
            }
        }
        
        
        public int CalculateSalary()
        {
            int totalSalary;

            totalSalary = _salary + _bonus;

            return totalSalary;

        }

        public int CalculateSalary(int salary, int bonus)
        {
            int totalSalary;

            totalSalary = salary + bonus;

            return totalSalary;

        }



    }
}
