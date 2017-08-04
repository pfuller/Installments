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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // TODO: Recalculate Brokerage
        }

        private void btnCalcSchedule_Click(object sender, EventArgs e)
        {

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

            throw new NotImplementedException("Implement Summing up Installments and displaying them");

            _policy = policy;
        }
        
        private Policy calculatePolicy()
        {
            try
            {

                Policy initialPolicy = new Policy()
                {
                    PolicyDetails = new PolicyDetails(Decimal.Parse(txtPremium.Text),
                        int.Parse(txtPctBrokerage.Text), Decimal.Parse(txtBrokerage.Text),
                        Decimal.Parse(txtTax1.Text), Decimal.Parse(txtTax2.Text),
                        Decimal.Parse(txtNetPremium.Text), Decimal.Parse(txtAmtDue.Text),
                        int.Parse(txtNumInstallments.Text)),
                    Installments = new List<Installment>()
                };

                return InstallmentCalculator.CalculateInstallments(initialPolicy);

            } catch (Exception ex)
            {
                MessageBox.Show($"Error Creating Policy from input '{ex.Message}'",
                    "Error Creating Policy from input", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return _policy;
            }
        }

        private void calculatePolicy(object sender, EventArgs e)
        {
            displayPolicy(calculatePolicy());
        }

        private void txtPremium_TextChanged(object sender, EventArgs e)
        {
            calculatePolicy(sender, e);
        }

        private void txtBrokerage_TextChanged(object sender, EventArgs e)
        {
            calculatePolicy(sender, e);
        }

        private void txtTax1_TextChanged(object sender, EventArgs e)
        {
            calculatePolicy(sender, e);
        }

        private void txtTax2_TextChanged(object sender, EventArgs e)
        {
            calculatePolicy(sender, e);
        }

        private void txtNetPremium_TextChanged(object sender, EventArgs e)
        {
            calculatePolicy(sender, e);
        }

        private void txtAmtDue_TextChanged(object sender, EventArgs e)
        {
            calculatePolicy(sender, e);
        }
    }
}