using System;

namespace FMA_Payslip_Jun19
{
    public class PayslipCalculatorDriver
    {
        private EmployeeValidator _employeeValidator;
        private PayslipCalculator _payslipCalculator;
        private IUserInput _userInput;

        public PayslipCalculatorDriver(EmployeeValidator employeeValidator, PayslipCalculator payslipCalculator, IUserInput userInput)
        {
            _employeeValidator = employeeValidator;
            _payslipCalculator = payslipCalculator;
            _userInput = userInput;
        }

        public void ExecutePayrun()
        {
            var employee = _userInput.GetEmployeeDetails();
            
            if (_employeeValidator.EmployeeIsValid(employee))
            {
                var payslip = _payslipCalculator.CreatePayslip(employee);
                Console.WriteLine(payslip);
            }
            else
            {
                Console.WriteLine("Bad employee details entered, no payslip created");
            }
            
        }

     
    }
}