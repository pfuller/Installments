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

        public static Policy CalculateInstallments(Policy initialPolicy)
        {
            return initialPolicy;
        }
    }
}