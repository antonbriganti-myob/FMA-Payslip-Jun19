using System;
using System.Collections.Generic;
using System.Threading.Tasks.Sources;
using FMA_Payslip_Jun19;
using Xunit;

namespace FMA_Payslip_Jun19_Tests
{
    public class CSVUserInputTest
    {
        
        [Fact]
        public void CreateEmployeeFromCSVLine_convertsSuperRateToDecimal()
        {
            var CSVUserInput = new CSVUserInput();
            var actualEmployee = CSVUserInput.CreateEmployeeFromCSVLine("David,Rudd,60050,9%,March 01 – March 31");
            var expectedSuperRate = 0.09m;
            
            Assert.Equal(expectedSuperRate, actualEmployee.SuperRate);
        }
        
        
    }
}
