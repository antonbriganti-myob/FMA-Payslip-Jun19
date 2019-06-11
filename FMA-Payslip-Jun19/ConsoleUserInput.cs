using System;
using System.Collections.Generic;

namespace FMA_Payslip_Jun19
{
    public class ConsoleUserInput : IUserInput
    {
        public List<Employee> CreateEmployees()
        {
            var employeeList = new List<Employee>();
            while (true)
            {
                employeeList.Add(GetEmployeeDetails());
                Console.WriteLine("Add another employee? (anything but N continues)");
                if (Console.ReadKey().Key == ConsoleKey.N)
                     break;
            }

            return employeeList;
        }

        public Employee GetEmployeeDetails()
        {
            Console.Write("Input first name: ");
            var firstName = Console.ReadLine();

            Console.Write("Input last name: ");
            var lastName = Console.ReadLine();

            Console.Write("Input annual salary: ");
            var annualSalary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Input super rate (0-50 inclusive): ");
            var superRate = Convert.ToDecimal(Console.ReadLine())/100;

            Console.Write("Input start date: ");
            var startDate = Console.ReadLine();

            Console.Write("Input end date: ");
            var endDate = Console.ReadLine();

            return new Employee(firstName + " " + lastName, Convert.ToDecimal(annualSalary),
                Convert.ToDecimal(superRate), startDate, endDate);

        }
    }
}