using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_
{
    public class Employee
    {
        public int Salary { get; set; }
        public string Name { get; set; }
    }

    public class RunsComparison : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y) // X-> Rohit, y-> Virat
        {
            if (x.Salary < y.Salary)
            {
                return -1;
            }
            else if (x.Salary > y.Salary)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Employee Rohit = new Employee { Salary = 13000, Name = "Rohit" };
            Employee Virat = new Employee { Salary = 14000, Name = "Virat" };

            RunsComparison obj = new RunsComparison();
            int result = obj.Compare(Rohit, Virat);

            if (result < 0)
            {
                Console.WriteLine("Rohit has less salary than Virat");
            }
            else if (result > 0)
            {
                Console.WriteLine("Rohit has more salary than Virat");
            }
            else
            {
                Console.WriteLine("Rohit & Virat has same salary");
            }

        }

   
    }


}

