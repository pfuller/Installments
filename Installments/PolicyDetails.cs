using System.Collections.Generic;

namespace Installments
{
    public class Policy
    {
        public PolicyDetails PolicyDetails { get; set; }
        public List<Installment> Installments { get; set; }
    }

    public class PolicyDetails
    {
        public decimal Premium { get; set; }
        public int BrokeragePct { get; set; }
        public decimal Brokerage { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public decimal NetPremium { get; set; }
        public decimal AmountDue { get; set; }
        public int NumInstallments { get; set; }

        public PolicyDetails()
        {
            this.Premium = new decimal(0.00);
            this.BrokeragePct = 0;
            this.Brokerage = new decimal(0.00);
            this.Tax1 = new decimal(0.00);
            this.Tax2 = new decimal(0.00);
            this.NetPremium = new decimal(0.00);
            this.AmountDue = new decimal(0.00);
            this.NumInstallments = 1;
        }

        public PolicyDetails(decimal premium, int brokeragePct, decimal brokerage,
            decimal tax1, decimal tax2, decimal netPremium, decimal amountDue, int numInstallments)
        {
            this.Premium = premium;
            this.BrokeragePct = brokeragePct;
            this.Brokerage = brokerage;
            this.Tax1 = tax1;
            this.Tax2 = tax2;
            this.NetPremium = netPremium;
            this.AmountDue = amountDue;
            this.NumInstallments = numInstallments;
        }
    }
}