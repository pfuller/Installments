﻿using System;
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
            var fmt = "{0:.00}";

            txtPremium.Text = String.Format(fmt, policy.PolicyDetails.Premium);

            txtPctBrokerage.Text = policy.PolicyDetails.BrokeragePct.ToString();
            txtBrokerage.Text = String.Format(fmt, policy.PolicyDetails.Brokerage);

            txtTax1.Text = String.Format(fmt, policy.PolicyDetails.Tax1);
            txtTax2.Text = String.Format(fmt, policy.PolicyDetails.Tax2);

            txtNetPremium.Text = String.Format(fmt, policy.PolicyDetails.NetPremium); 
            txtAmtDue.Text = String.Format(fmt, policy.PolicyDetails.AmountDue);

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
                // Correct Brokerage
                try
                {
                    txtBrokerage.Text = Decimal.Round(
                                (Decimal.Parse(txtPremium.Text) *
                                ((decimal)int.Parse(txtPctBrokerage.Text) / 100)), 2).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error calculating Brokerage: {ex.Message}", "Error calculating Brokerage",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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
            displayPolicy(calculatePolicy());
        }

        private void txtNumInstallments_Leave(object sender, EventArgs e)
        {
            displayPolicy(calculatePolicy());
        }
    }
}