using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installments
{
    public partial class InstallmentsForm : Form
    {
        private Policy _policy;

        public InstallmentsForm()
        {
            InitializeComponent();
        }

        private void InstallmentsForm_Load(object sender, EventArgs e)
        {
            // Set some defaults programatically
            displayPolicy(InstallmentCalculator.initialisePolicy());
        }

        private void displayPolicy(Policy policy)
        {
            txtPremium.Text = policy.PolicyDetails.Premium.ToString();

            txtPctBrokerage.Text = policy.PolicyDetails.BrokeragePct.ToString();
            txtBrokerage.Text = policy.PolicyDetails.Brokerage.ToString();

            txtTax1.Text = policy.PolicyDetails.Tax1.ToString();
            txtTax2.Text = policy.PolicyDetails.Tax2.ToString();

            txtNetPremium.Text = policy.PolicyDetails.NetPremium.ToString();
            txtAmtDue.Text = policy.PolicyDetails.AmountDue.ToString();

            txtNumInstallments.Text = policy.PolicyDetails.NumInstallments.ToString();

            dataGridInstallments.DataSource = policy.Installments;

            var summary = InstallmentCalculator.summariseInstallments(policy.Installments);

            txtTotPrem.Text = summary.Premium.ToString();
            txtTotBkrg.Text = summary.Brokerage.ToString();
            txtTotTax1.Text = summary.Tax1.ToString();
            txtTotTax2.Text = summary.Tax2.ToString();
            txtTotNetPrem.Text = summary.NetPremium.ToString();
            txtTotDue.Text = summary.AmountDue.ToString();

            _policy = policy;
        }
        
        private Policy calculatePolicy()
        {
            try
            {
                // Convert all the input to a policy
                Policy initialPolicy = new Policy()
                {
                    PolicyDetails = new PolicyDetails(Decimal.Parse(txtPremium.Text),
                        int.Parse(txtPctBrokerage.Text), Decimal.Parse(txtBrokerage.Text),
                        Decimal.Parse(txtTax1.Text), Decimal.Parse(txtTax2.Text),
                        Decimal.Parse(txtNetPremium.Text), Decimal.Parse(txtAmtDue.Text),
                        int.Parse(txtNumInstallments.Text)),
                    Installments = new List<Installment>()
                };

                // Correct the calculations
                initialPolicy.PolicyDetails.NetPremium = CalculateNetPremium(initialPolicy);
                initialPolicy.PolicyDetails.AmountDue = CalculateAmountDue(initialPolicy);

                return InstallmentCalculator.CalculateInstallments(initialPolicy);

            } catch (Exception ex)
            {
                MessageBox.Show($"Error Creating Policy from input '{ex.Message}'",
                    "Error Creating Policy from input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return _policy;
            }
        }

        private decimal CalculateNetPremium(Policy policy)
        {
            return policy.PolicyDetails.Premium - policy.PolicyDetails.Brokerage;
        }

        private decimal CalculateAmountDue(Policy policy)
        {
            // Assume direct policy, commision is not deducted
            return policy.PolicyDetails.Premium + policy.PolicyDetails.Tax1 + policy.PolicyDetails.Tax2; 
        }

        private void txtPremium_Leave(object sender, EventArgs e)
        {
            displayPolicy(calculatePolicy());
        }

        private void txtBrokerage_Leave(object sender, EventArgs e)
        {
            displayPolicy(calculatePolicy());
        }

        private void txtTax1_Leave(object sender, EventArgs e)
        {
            displayPolicy(calculatePolicy());
        }

        private void txtTax2_Leave(object sender, EventArgs e)
        {
            displayPolicy(calculatePolicy());
        }

        private void txtNetPremium_Leave(object sender, EventArgs e)
        {
            displayPolicy(calculatePolicy());
        }

        private void txtAmtDue_Leave(object sender, EventArgs e)
        {
            displayPolicy(calculatePolicy());
        }

        private void txtPctBrokerage_Leave(object sender, EventArgs e)
        {
            try
            {
                txtBrokerage.Text = (Decimal.Parse(txtPremium.Text) * ((decimal)int.Parse(txtPctBrokerage.Text) / 100)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating Brokerage: {ex.Message}", "Error calculating Brokerage",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNumInstallments_Leave(object sender, EventArgs e)
        {
            displayPolicy(calculatePolicy());
        }
    }
}