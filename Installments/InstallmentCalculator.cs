using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installments
{
    public class InstallmentCalculator
    {
        public static Policy initialisePolicy()
        {
            return new Policy()
            {
                PolicyDetails = new PolicyDetails(),
                Installments = new List<Installment>()
            };
        }

        public static Installment summariseInstallments(List<Installment> installments)
        {
            int installmentNum = 0;
            decimal premium = installments.Sum(p => p.Premium);
            decimal brokerage = installments.Sum(p => p.Brokerage);
            decimal tax1 = installments.Sum(p => p.Tax1);
            decimal tax2 = installments.Sum(p => p.Tax2);
            decimal netPremium = installments.Sum(p => p.NetPremium);
            decimal amountDue = installments.Sum(p => p.AmountDue);

            return new Installment(installmentNum, premium, 
                brokerage, tax1, tax2, netPremium, amountDue);
        }

        public static Policy CalculateInstallments(Policy initialPolicy)
        {
            allocateInstallmentsAmount(initialPolicy);

            return initialPolicy;
        }

        private static void allocateInstallmentsAmount(Policy policy)
        {

            // Clear the installments
            policy.Installments = new List<Installment>();

            foreach (var instNum in Enumerable.Range(1, policy.PolicyDetails.NumInstallments))
            {
                policy.Installments.Add(calcInstallment(instNum, policy));
            }
        }

        private static Installment calcInstallment(int instNum, Policy policy)
        {
            var totInst = policy.PolicyDetails.NumInstallments;

            decimal premium;
            decimal brokerage;
            decimal tax1;
            decimal tax2;

            if (instNum == 1)
            {
                premium = firstInstallment(totInst, policy.PolicyDetails.Premium);
                brokerage = firstInstallment(totInst, policy.PolicyDetails.Brokerage);
                tax1 = firstInstallment(totInst, policy.PolicyDetails.Tax1);
                tax2 = firstInstallment(totInst, policy.PolicyDetails.Tax2);
            }
            else
            {
                premium = calcInstallment(totInst, policy.PolicyDetails.Premium);
                brokerage = calcInstallment(totInst, policy.PolicyDetails.Brokerage);
                tax1 = calcInstallment(totInst, policy.PolicyDetails.Tax1);
                tax2 = calcInstallment(totInst, policy.PolicyDetails.Tax2);
            }

            return new Installment(instNum, premium, brokerage, tax1, tax2,
                (premium - brokerage), (premium + tax1 + tax2));
        }

        private static Decimal firstInstallment(int installments, Decimal amount)
        {
            Decimal otherInstallments = calcInstallment(installments, amount) * (installments - 1);
            return amount - otherInstallments;
        }

        private static Decimal calcInstallment(int installments, Decimal amount)
        {
            return Math.Floor(amount / installments);
        }

        //private void allocateInstallments<T>(List<Installment> Installments, Policy policy,
        //    Func<Policy, Decimal, Decimal> firstInstallmentCalc, Func<Policy, Decimal, Decimal> remainingInstallmentCalc)
        //{
        //    foreach (var instNum in Enumerable.Range(1, policy.PolicyDetails.NumInstallments))
        //    {
        //        if (instNum == 1)
        //        {
        //            policy.Installments.Add(new Installment(instNum, 0, 0, 0, 0, 0, firstInstallmentCalc(policy, policy.PolicyDetails.AmountDue)));
        //        }
        //        else
        //        {
        //            policy.Installments.Add(new Installment(instNum, 0, 0, 0, 0, 0, remainingInstallmentCalc(policy, policy.PolicyDetails.AmountDue)));
        //        }
        //    }
        //}
    }
}