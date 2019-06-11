using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FMA_Payslip_Jun19
{
    public class CSVUserInput : IUserInput
    {
        public List<Employee> CreateEmployees()
        {
            List<Employee> employees = File.ReadAllLines("./input/sample_input.csv")
                .Skip(1)
                .Select(CreateEmployeeFromCSVLine)
                .ToList();

            return employees;
        }

        public Employee CreateEmployeeFromCSVLine(string csvLine)
        {
            string[] values = csvLine.Split(',');
            var name = values[0] + " " + values[1];
            var salary = Convert.ToDecimal(values[2]);
            var superRate = Convert.ToDecimal(values[3].Replace("%", ""))/100;
            
            var payPeriod = values[4].Split(" – ");
            var payPeriodStart = payPeriod[0];
            var payPeriodEnd = payPeriod[1];
            
            return new Employee(name, salary, superRate, payPeriodStart, payPeriodEnd);
        }
    }
}