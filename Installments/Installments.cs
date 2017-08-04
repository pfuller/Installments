namespace Installments
{
    public class Installment
    {
        public int InstallmentNum { get; set; }
        public decimal Premium { get; set; }
        public decimal Brokerage { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public decimal NetPremium { get; set; }
        public decimal AmountDue { get; set; }

        public Installment(int installmentNum, decimal premium, decimal brokerage,
            decimal tax1, decimal tax2, decimal netPremium, decimal amountDue)
        {
            this.Premium = premium;
            this.InstallmentNum = installmentNum;
            this.Brokerage = brokerage;
            this.Tax1 = tax1;
            this.Tax2 = tax2;
            this.NetPremium = netPremium;
            this.AmountDue = amountDue;
        }
    }
}