﻿using System;

namespace FMA_Payslip_Jun19
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserInput userInput = new ConsoleUserInput();
            PayslipCalculatorDriver payslipCalculatorDriver = new PayslipCalculatorDriver(new EmployeeValidator(), new PayslipCalculator(), userInput);

            payslipCalculatorDriver.ExecutePayrun();
        }

        
    }
}
