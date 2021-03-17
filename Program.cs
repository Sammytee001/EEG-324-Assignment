using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEG_324_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empl1 = new Employee("Samuel", "Osifeso", 150000000);
            Employee empl2 = new Employee("Emmanuel", "Adefulu", 120000000);

            Console.WriteLine("Employee 1 Firstname: {0}", empl1.FirstName);
            Console.WriteLine("Employee 1 Lastname: {0}", empl1.LastName);
            Console.WriteLine("Employee 1 Salary: {0}", empl1.Salary);

            Console.WriteLine("Employee 2 Firstname: {0}", empl2.FirstName);
            Console.WriteLine("Employee 2 Lastname: {0}", empl2.LastName);
            Console.WriteLine("Employee 2 Salary: {0}", empl2.Salary);

            Console.WriteLine();
            Console.WriteLine("After 10% raise");

            empl1.Salary = empl1.Salary * (decimal)1.1;
            empl2.Salary = empl2.Salary * (decimal)1.1;
            Console.WriteLine("Employee 1 new salary: {0}", empl1.Salary);
            Console.WriteLine("Employee 2 new salary: {0}", empl2.Salary);

            Console.ReadLine();
        }
    }
}
