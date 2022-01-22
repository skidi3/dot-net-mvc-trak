using System;
using System.IO;

namespace app2
{
    public class Employee
    {
        public string emp_name;
        public string emp_email;
        public int emp_age;

        public void getEmployeeDetails()
        {
            Console.WriteLine("Enter Name:");
            this.emp_name = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            this.emp_email = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            this.emp_age = Convert.ToInt32(Console.ReadLine());
        }
        public void addDetailstofile()
        {
            string path = "D:\\test.txt";

            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("Name:" + emp_name + "Email:" + emp_email + "age:" + emp_age);
            sw.Flush();
            sw.Close();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getEmployeeDetails();
            emp.addDetailstofile();
        }
    }
}
