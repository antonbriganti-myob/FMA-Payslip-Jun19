using FMA_Payslip_Jun19;
using Xunit;

namespace FMA_Payslip_Jun19_Tests
{
    public class EmployeeValidatorTest
    {

        [Fact]
        public void employeeValidator_returnsTrue_whenEmployeeIsValid()
        {
            EmployeeValidator validator = new EmployeeValidator();
            Employee employee = new Employee("John Smith", 60000, 4, "March 1", "March 31");
            Assert.True(validator.EmployeeIsValid(employee));
        }

        [Fact]
        public void employeeValidator_returnsFalse_whenEmployeeHasNegativeSalary()
        {
            EmployeeValidator validator = new EmployeeValidator();
            Employee employee = new Employee("John Smith", -60000, 4, "March 1", "March 31");
            Assert.False(validator.EmployeeIsValid(employee));
        }
        
        [Theory]
        [InlineData(0)]
        [InlineData(50)]
        public void employeeValidator_returnsTrue_whenEmployeeHasValidSuperRate_InclusiveRange(decimal superRate)
        {
            EmployeeValidator validator = new EmployeeValidator();
            Employee employee = new Employee("John Smith", 60000, 4, "March 1", "March 31");
            Assert.True(validator.EmployeeIsValid(employee));
        }
        
        [Theory]
        [InlineData(-1)]
        [InlineData(51)]
        public void employeeValidator_returnsFalse_whenEmployeeHasOutOfRangeSuperRate(decimal superRate)
        {
            EmployeeValidator validator = new EmployeeValidator();
            Employee employee = new Employee("John Smith", 60000, superRate, "March 1", "March 31");
            Assert.False(validator.EmployeeIsValid(employee));
        }
        
        [Fact]
        public void employeeValidator_returnsFalse_whenEmployeeHasStartDateThatIsNotTheFirstOfMonth()
        {
            EmployeeValidator validator = new EmployeeValidator();
            Employee employee = new Employee("John Smith", 60000, 4, "March 2", "March 31");
            Assert.False(validator.EmployeeIsValid(employee));
        }
        
        [Fact]
        public void employeeValidator_returnsFalse_whenEmployeeHasEndDateThatIsNotTheLastOfMonth()
        {
            EmployeeValidator validator = new EmployeeValidator();
            Employee employee = new Employee("John Smith", 60000, 4, "March 1", "March 30");
            Assert.False(validator.EmployeeIsValid(employee));
        }
        
        [Fact]
        public void employeeValidator_returnsFalse_whenEmployeeStartDateAndEndDateDoNotShareSameMonth()
        {
            EmployeeValidator validator = new EmployeeValidator();
            Employee employee = new Employee("John Smith", 60000, 4, "January 1", "March 31");
            Assert.False(validator.EmployeeIsValid(employee));
        }
    }
}
