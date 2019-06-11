namespace FMA_Payslip_Jun19
{
    public class TaxBracket
    {
        public decimal MinimumIncomeLimit { get; }
        public decimal MaximumIncomeLimit { get; }
        public decimal BaseTax { get; }
        public decimal TaxRate { get; }

        public TaxBracket(decimal minimumIncomeLimit, decimal maximumIncomeLimit, decimal baseTax, decimal taxRate)
        {
            MinimumIncomeLimit = minimumIncomeLimit;
            MaximumIncomeLimit = maximumIncomeLimit;
            BaseTax = baseTax;
            TaxRate = taxRate;
        }
    }
}