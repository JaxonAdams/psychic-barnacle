using System;
using System.Collections.Generic;

namespace Jaxon.BadgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string> ()
            {
                "Jaxon",
                "Paige"
            };

            employees.Add("Brea");
            employees.Add("Graham");

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            };
        }
    }
}
