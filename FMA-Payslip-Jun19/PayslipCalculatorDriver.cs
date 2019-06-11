using System;
using System.Collections.Generic;

namespace FMA_Payslip_Jun19
{
    public class PayslipCalculatorDriver
    {
        private readonly EmployeeValidator _employeeValidator;
        private readonly PayslipCalculator _payslipCalculator;
        private readonly IUserInput _userInput;

        public PayslipCalculatorDriver(EmployeeValidator employeeValidator, PayslipCalculator payslipCalculator, IUserInput userInput)
        {
            _employeeValidator = employeeValidator;
            _payslipCalculator = payslipCalculator;
            _userInput = userInput;
        }

        public void ExecutePayrun()
        {
            var employees = _userInput.CreateEmployees();
            var payslips = CreatePayslips(employees);
            foreach (var payslip in payslips)
            {
                Console.WriteLine(payslip + "\n");
            }
        }
        
        private List<Payslip> CreatePayslips(List<Employee> employees)
        {
            var payslips = new List<Payslip>();
            foreach (var employee in employees)
            {
                if (_employeeValidator.EmployeeIsValid(employee))
                {
                    payslips.Add(_payslipCalculator.CreatePayslip(employee));
                }
                else
                {
                    Console.WriteLine($"Employee details for {employee.Name} are invalid, no payslip created \n");
                }
            }

            return payslips;
        }
    }
}