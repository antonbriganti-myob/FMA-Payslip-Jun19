using FMA_Payslip_Jun19;
using Xunit;

namespace FMA_Payslip_Jun19_Tests
{
    public class PayslipCalculatorTest
    {
        
        [Fact]
        public void calculateGrossIncome_calculatesGrossIncome_correctly()
        {
            var payslipCalculator = new PayslipCalculator();
            var testEmployee = new Employee("John Smith", 60050, 0.09m, "March 1", "March 31");
            var expectedGrossIncome = 5004;
            
            var actualGrossIncome = payslipCalculator.CreatePayslip(testEmployee).GrossIncome;
            
            Assert.Equal(expectedGrossIncome, actualGrossIncome);
        }
        
        [Fact]
        public void calculateNetIncome_calculatesNetIncome_correctly()
        {
            var payslipCalculator = new PayslipCalculator();
            var testEmployee = new Employee("John Smith", 60050, 0.09m, "March 1", "March 31");
            var expectedNetIncome = 4082;

            var actualNetIncome = payslipCalculator.CreatePayslip(testEmployee).NetIncome;
            
            Assert.Equal(expectedNetIncome, actualNetIncome);
        }
        
        [Fact]
        public void calculateSuperPaid_calculatesSuperPaid_correctly()
        {
            var payslipCalculator = new PayslipCalculator();
            var testEmployee = new Employee("John Smith", 60050, 0.09m, "March 1", "March 31");
            var expectedSuperPaid = 450;

            var actualSuperPaid = payslipCalculator.CreatePayslip(testEmployee).SuperPaid;
            
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
