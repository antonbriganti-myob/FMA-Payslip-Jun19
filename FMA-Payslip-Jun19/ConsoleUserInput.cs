using System;

namespace FMA_Payslip_Jun19
{
    public class ConsoleUserInput : IUserInput
    {
        public Employee GetEmployeeDetails()
        {
            Console.Write("Input first name: ");
            var firstName = Console.ReadLine();

            Console.Write("Input last name: ");
            var lastName = Console.ReadLine();

            Console.Write("Input annual salary: ");
            var annualSalary = Console.ReadLine();

            Console.Write("Input super rate: ");
            var superRate = Console.ReadLine();

            Console.Write("Input start date: ");
            var startDate = Console.ReadLine();

            Console.Write("Input end date: ");
            var endDate = Console.ReadLine();

            return new Employee(firstName + " " + lastName, Convert.ToDecimal(annualSalary),
                Convert.ToDecimal(superRate), startDate, endDate);

        }
    }
}