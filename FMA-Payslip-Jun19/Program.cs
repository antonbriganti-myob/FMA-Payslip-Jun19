using System;

namespace FMA_Payslip_Jun19
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserInput userInput = new ConsoleUserInput();
            EmployeeValidator validator = new EmployeeValidator();
            PayslipCalculator payslipCalculator = new PayslipCalculator();
            
            Employee employee = userInput.GetEmployeeDetails();
            

            if (validator.EmployeeIsValid(employee))
            {
                var payslip = payslipCalculator.CreatePayslip(employee);
                Console.WriteLine();
                Console.WriteLine(payslip);
            }
            else
            {
                Console.WriteLine("Bad employee data entered.");
            }
        }
    }
}
