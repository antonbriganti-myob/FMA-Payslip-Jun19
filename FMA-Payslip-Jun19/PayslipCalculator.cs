using System;
using System.Collections.Generic;

namespace FMA_Payslip_Jun19
{
    public class PayslipCalculator
    {
        
        
        public decimal CalculateGrossIncome(decimal salary)
        {
            return decimal.Round(salary / 12);
        }

        public decimal calculateIncomeTax(decimal salary)
        {
            decimal incomeTax = 0;
            
            List<TaxBracket> taxBrackets = new List<TaxBracket>()
            {
                new TaxBracket(0, 18200, 0, 0),
                new TaxBracket(18201, 37000, 0, 0.19m),
                new TaxBracket(37001, 87000, 3572, 0.325m),
                new TaxBracket(87001, 180000, 19822, 0.37m),
                new TaxBracket(180001, decimal.MaxValue, 54232, 0.45m)
            };

            foreach (var taxBracket in taxBrackets)
            {
                if (salary <= taxBracket.MaximumIncomeLimit)
                {
                    incomeTax = decimal.Round((taxBracket.BaseTax + (salary - taxBracket.MinimumIncomeLimit - 1) * taxBracket.TaxRate) / 12);
                    break;
                }
            }

            return incomeTax;
        }

        public decimal CalculateNetIncome(decimal grossIncome, decimal incomeTax)
        {
            return grossIncome - incomeTax;
        }
        

        public decimal CalculateSuperPaid(decimal grossIncome, decimal superRate)
        {
            return decimal.Round(grossIncome * superRate);
        }
        
        
    }
}