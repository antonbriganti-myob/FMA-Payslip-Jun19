using System;
using System.Collections.Generic;
using FMA_Payslip_Jun19;
using Xunit;

namespace FMA_Payslip_Jun19_Tests
{
    public class PayslipCalculatorTest
    {
        
        [Fact]
        public void calculateGrossIncome_calculatesGrossIncome_correctly()
        {
            PayslipCalculator payslipCalculator = new PayslipCalculator();
            var expectedGrossIncome = 5004;

            var actualGrossIncome = payslipCalculator.CalculateGrossIncome(60050);
            
            Assert.Equal(expectedGrossIncome, actualGrossIncome);
        }
        
        [Fact]
        public void calculateNetIncome_calculatesNetIncome_correctly()
        {
            PayslipCalculator payslipCalculator = new PayslipCalculator();
            var expectedNetIncome = 4082;

            var actualNetIncome = payslipCalculator.CalculateNetIncome(5004, 922);
            
            Assert.Equal(expectedNetIncome, actualNetIncome);
        }
        
        [Fact]
        public void calculateSuperPaid_calculatesSuperPaid_correctly()
        {
            PayslipCalculator payslipCalculator = new PayslipCalculator();
            var expectedSuperPaid = 450;

            var actualSuperPaid = payslipCalculator.CalculateSuperPaid(5004, 0.09m);
            
            Assert.Equal(expectedSuperPaid, actualSuperPaid);
        }
        
        [Theory]
        [InlineData(0, 0)]
        [InlineData(18200, 0)]
        [InlineData(18201, 0)]
        [InlineData(37000, 298)]
        [InlineData(37001, 298)]
        [InlineData(87000, 1652)]
        [InlineData(87001, 1652)]
        [InlineData(180000, 4519)]
        [InlineData(180001, 4519)]
        [InlineData(200000, 5269)]
        public void calculateIncomeTax_calculatesIncomeTax_correctly(int testSalary, decimal expectedIncomeTax)
        {
            PayslipCalculator payslipCalculator = new PayslipCalculator();

            decimal actualIncomeTax = payslipCalculator.CalculateIncomeTax(testSalary);
            
            Assert.Equal(expectedIncomeTax, actualIncomeTax);
        }
    }
}
