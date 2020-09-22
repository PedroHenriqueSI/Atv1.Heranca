using HERANCA.Atv1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HERANCA.Atv1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Outsourced (y/n)? ");
                char l = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour:  ");
                double value = double.Parse(Console.ReadLine());

                if (l == 'y')
                {
                    Console.Write("Additional charge:");
                    double add = double.Parse(Console.ReadLine());
                    list.Add(new OutSourcedEmployee(name, hours, value, add));
                }
                else
                {
                    list.Add(new Employee(name, hours, value));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + "- "+emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
