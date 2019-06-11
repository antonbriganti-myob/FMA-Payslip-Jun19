using System;

namespace FMA_Payslip_Jun19
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = args.Length > 0 && args[0] == "csv"
                ? (IUserInput) new CSVUserInput("./input/sample_input.csv")
                : new ConsoleUserInput();

            PayslipCalculatorDriver payslipCalculatorDriver = new PayslipCalculatorDriver(new EmployeeValidator(), new PayslipCalculator(), userInput);

            payslipCalculatorDriver.ExecutePayrun();
        }
        
    }
}
