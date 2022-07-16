using System;
using System.Collections.Generic;

namespace Jaxon.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
        }

        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee> ();

            while(true)
            {
                Console.WriteLine("Enter first name: (leave empty to exit)");
                Console.WriteLine("---------------------");
                string newName = Console.ReadLine();

                if (newName == "") 
                {
                    break;
                }

                Console.WriteLine("Enter last name: ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Employee ID: ");
                int id = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Photo URL: ");
                string photoUrl = Console.ReadLine();

                Console.WriteLine("---------------------");

                Employee currentEmployee = new Employee(newName, lastName, id, photoUrl);
                employees.Add(currentEmployee);
            };

            return employees;
        }
    }
}
