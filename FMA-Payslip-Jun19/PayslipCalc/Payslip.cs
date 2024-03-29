namespace FMA_Payslip_Jun19
{
    public class Payslip
    {
        private string EmployeeName { get; }
        private string PayPeriod { get; }
        public decimal GrossIncome { get; }
        public decimal NetIncome { get; }
        public decimal SuperPaid { get; }

        public Payslip(string employeeName, string payPeriod, decimal grossIncome, decimal netIncome, decimal superPaid)
        {
            EmployeeName = employeeName;
            PayPeriod = payPeriod;
            GrossIncome = grossIncome;
            NetIncome = netIncome;
            SuperPaid = superPaid;
        }

        public override string ToString()
        {
            return "Employee: " + EmployeeName + "\n" +
                   "Pay Period: " + PayPeriod + "\n" +
                   "Gross Income: " + GrossIncome + "\n" +
                   "Net Income: " + NetIncome + "\n" +
                   "Super Paid: " + SuperPaid;
        }
    }
}