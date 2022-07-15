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

        static void PrintEmployees(List<Employee> employees)
        {
            Console.WriteLine("---------------------");
            for (int i = 0; i < employees.Count; i++) 
            {
            string template = "{0,-10}\t{1,-20}\t{2}";
            Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
            }
        }
    }
}
