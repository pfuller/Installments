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
                if (instNum == 1)
                {
                    decimal diff = firstInstallment(policy, policy.PolicyDetails.AmountDue) *
                            (100 / policy.PolicyDetails.AmountDue);

                    policy.Installments.Add(new Installment(instNum, firstInstallment(policy, policy.PolicyDetails.Premium),
                                                firstInstallment(policy, policy.PolicyDetails.Brokerage),
                                                firstInstallment(policy, policy.PolicyDetails.Tax1),
                                                firstInstallment(policy, policy.PolicyDetails.Tax2),
                                                diff, 
                                                firstInstallment(policy, policy.PolicyDetails.AmountDue)));
                } else
                {

                    decimal diff = calcInstallment(policy, policy.PolicyDetails.AmountDue) *
        (100 / policy.PolicyDetails.AmountDue);

                    policy.Installments.Add(new Installment(instNum, calcInstallment(policy, policy.PolicyDetails.Premium),
                                                calcInstallment(policy, policy.PolicyDetails.Brokerage),
                                                calcInstallment(policy, policy.PolicyDetails.Tax1),
                                                calcInstallment(policy, policy.PolicyDetails.Tax2),
                                                diff, 
                                                calcInstallment(policy, policy.PolicyDetails.AmountDue)));
                }
            }
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

        private static Decimal firstInstallment(Policy policy, Decimal totalAmount)
        {
            var average = totalAmount / policy.PolicyDetails.NumInstallments;
            var roundedAvg = Decimal.Round(average, 0);
            return Decimal.Round(roundedAvg + ((average - roundedAvg) * policy.PolicyDetails.NumInstallments));
        }

        private static Decimal calcInstallment(Policy policy, Decimal totalAmount)
        {
            var average = totalAmount / policy.PolicyDetails.NumInstallments;
            return Decimal.Round(average, 0);
        }
    }
}