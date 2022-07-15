using System;
using System.Collections.Generic;

namespace Jaxon.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            PrintEmployees(employees);
        }

        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee> ();

            while(true)
            {
                Console.WriteLine("Please enter a name: (leave empty to exit)");
                Console.WriteLine("---------------------");

                string newName = Console.ReadLine();
                Console.WriteLine("---------------------");

                if (newName == "") 
                {
                    break;
                }

                Employee currentEmployee = new Employee(newName, "Smith");
                employees.Add(currentEmployee);
            };

            return employees;
        }

        static void PrintEmployees(List<Employee> employees)
        {
            Console.WriteLine("---------------------");
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].GetName());
            };
        }
    }
}
