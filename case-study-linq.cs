using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        public class Employee
        {
            public string name;
            public string department;
            public float salary;
            public Employee(string name, string department, float salary)
            {
                this.name = name;
                this.department = department;
                this.salary = salary;
            }
        }
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("User1", "IT", 40000));
            employees.Add(new Employee("User2", "Sales", 50000));
            employees.Add(new Employee("User3", "IT", 32000));
            employees.Add(new Employee("User4", "Sales", 65000));
            employees.Add(new Employee("User5", "Sales", 40000));
            employees.Add(new Employee("User6", "Sales", 40000));
            employees.Add(new Employee("User7", "Marketing", 40000));
            employees.Add(new Employee("Us8", "Marketing", 40000));

            var query = from e in employees  where e.department == "Sales" && e.salary > 15000 select e;
            Console.WriteLine("Query 1:");
            foreach (Employee employee in query)
            {
                Console.WriteLine(employee.name + " " + employee.department + " " + employee.salary);
            }

            var query2 = from e in employees where e.name.Length < 4 select e;
            Console.WriteLine("Query 2:");
            foreach (Employee employee in query2)
            {
                Console.WriteLine(employee.name + " " + employee.department + " " + employee.salary);
            }
            Console.ReadKey();
        }
    }
}
