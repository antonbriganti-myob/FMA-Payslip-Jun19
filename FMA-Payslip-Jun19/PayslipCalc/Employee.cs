namespace FMA_Payslip_Jun19
{
    public class Employee
    {
        public string Name { get; }
        public decimal Salary { get; }
        public decimal SuperRate { get; }
        public string PayPeriodStartDate { get; }
        public string PayPeriodEndDate { get; }

        public Employee(string name, decimal salary, decimal superRate, string payPeriodStartDate, string payPeriodEndDate)
        {
            Name = name;
            Salary = salary;
            SuperRate = superRate;
            PayPeriodStartDate = payPeriodStartDate;
            PayPeriodEndDate = payPeriodEndDate;
        }
        
        
    }
}