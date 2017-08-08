namespace Installments
{
    partial class InstallmentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPremium = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrokerage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTax1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTax2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPctBrokerage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNetPremium = new System.Windows.Forms.TextBox();
            this.txtAmtDue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumInstallments = new System.Windows.Forms.TextBox();
            this.dataGridInstallments = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotPrem = new System.Windows.Forms.TextBox();
            this.txtTotBkrg = new System.Windows.Forms.TextBox();
            this.txtTotTax1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotNetPrem = new System.Windows.Forms.TextBox();
            this.txtTotTax2 = new System.Windows.Forms.TextBox();
            this.txtTotDue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInstallments)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPremium
            // 
            this.txtPremium.Location = new System.Drawing.Point(133, 14);
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.Size = new System.Drawing.Size(221, 31);
            this.txtPremium.TabIndex = 0;
            this.txtPremium.Leave += new System.EventHandler(this.txtPremium_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Premium";
            // 
            // txtBrokerage
            // 
            this.txtBrokerage.Location = new System.Drawing.Point(497, 48);
            this.txtBrokerage.Name = "txtBrokerage";
            this.txtBrokerage.Size = new System.Drawing.Size(221, 31);
            this.txtBrokerage.TabIndex = 2;
            this.txtBrokerage.Leave += new System.EventHandler(this.txtBrokerage_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brokerage";
            // 
            // txtTax1
            // 
            this.txtTax1.Location = new System.Drawing.Point(810, 17);
            this.txtTax1.Name = "txtTax1";
            this.txtTax1.Size = new System.Drawing.Size(212, 31);
            this.txtTax1.TabIndex = 4;
            this.txtTax1.Leave += new System.EventHandler(this.txtTax1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tax 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(734, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tax 2";
            // 
            // txtTax2
            // 
            this.txtTax2.Location = new System.Drawing.Point(810, 60);
            this.txtTax2.Name = "txtTax2";
            this.txtTax2.Size = new System.Drawing.Size(212, 31);
            this.txtTax2.TabIndex = 7;
            this.txtTax2.Leave += new System.EventHandler(this.txtTax2_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "% Brokerage";
            // 
            // txtPctBrokerage
            // 
            this.txtPctBrokerage.Location = new System.Drawing.Point(166, 57);
            this.txtPctBrokerage.Name = "txtPctBrokerage";
            this.txtPctBrokerage.Size = new System.Drawing.Size(188, 31);
            this.txtPctBrokerage.TabIndex = 9;
            this.txtPctBrokerage.Leave += new System.EventHandler(this.txtPctBrokerage_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1044, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Net Premium";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1044, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Due";
            // 
            // txtNetPremium
            // 
            this.txtNetPremium.Location = new System.Drawing.Point(1214, 17);
            this.txtNetPremium.Name = "txtNetPremium";
            this.txtNetPremium.Size = new System.Drawing.Size(316, 31);
            this.txtNetPremium.TabIndex = 12;
            this.txtNetPremium.Leave += new System.EventHandler(this.txtNetPremium_Leave);
            // 
            // txtAmtDue
            // 
            this.txtAmtDue.Location = new System.Drawing.Point(1212, 65);
            this.txtAmtDue.Name = "txtAmtDue";
            this.txtAmtDue.Size = new System.Drawing.Size(318, 31);
            this.txtAmtDue.TabIndex = 13;
            this.txtAmtDue.Leave += new System.EventHandler(this.txtAmtDue_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Number of Installments";
            // 
            // txtNumInstallments
            // 
            this.txtNumInstallments.Location = new System.Drawing.Point(260, 107);
            this.txtNumInstallments.Name = "txtNumInstallments";
            this.txtNumInstallments.Size = new System.Drawing.Size(100, 31);
            this.txtNumInstallments.TabIndex = 15;
            this.txtNumInstallments.Leave += new System.EventHandler(this.txtNumInstallments_Leave);
            // 
            // dataGridInstallments
            // 
            this.dataGridInstallments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInstallments.Location = new System.Drawing.Point(19, 164);
            this.dataGridInstallments.Name = "dataGridInstallments";
            this.dataGridInstallments.RowTemplate.Height = 33;
            this.dataGridInstallments.Size = new System.Drawing.Size(1610, 677);
            this.dataGridInstallments.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 862);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Premium Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 907);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Brokerage Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(474, 865);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Tax 1 Total";
            // 
            // txtTotPrem
            // 
            this.txtTotPrem.Location = new System.Drawing.Point(183, 862);
            this.txtTotPrem.Name = "txtTotPrem";
            this.txtTotPrem.Size = new System.Drawing.Size(208, 31);
            this.txtTotPrem.TabIndex = 21;
            // 
            // txtTotBkrg
            // 
            this.txtTotBkrg.Location = new System.Drawing.Point(183, 907);
            this.txtTotBkrg.Name = "txtTotBkrg";
            this.txtTotBkrg.Size = new System.Drawing.Size(208, 31);
            this.txtTotBkrg.TabIndex = 22;
            // 
            // txtTotTax1
            // 
            this.txtTotTax1.Location = new System.Drawing.Point(604, 859);
            this.txtTotTax1.Name = "txtTotTax1";
            this.txtTotTax1.Size = new System.Drawing.Size(221, 31);
            this.txtTotTax1.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(474, 913);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 25);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tax 2 Total";
            // 
            // txtTotNetPrem
            // 
            this.txtTotNetPrem.Location = new System.Drawing.Point(1350, 865);
            this.txtTotNetPrem.Name = "txtTotNetPrem";
            this.txtTotNetPrem.Size = new System.Drawing.Size(264, 31);
            this.txtTotNetPrem.TabIndex = 25;
            // 
            // txtTotTax2
            // 
            this.txtTotTax2.Location = new System.Drawing.Point(604, 910);
            this.txtTotTax2.Name = "txtTotTax2";
            this.txtTotTax2.Size = new System.Drawing.Size(221, 31);
            this.txtTotTax2.TabIndex = 26;
            // 
            // txtTotDue
            // 
            this.txtTotDue.Location = new System.Drawing.Point(1350, 913);
            this.txtTotDue.Name = "txtTotDue";
            this.txtTotDue.Size = new System.Drawing.Size(264, 31);
            this.txtTotDue.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1128, 871);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 25);
            this.label13.TabIndex = 28;
            this.label13.Text = "Total Net Premium";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1138, 919);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 25);
            this.label14.TabIndex = 29;
            this.label14.Text = "Total Due";
            // 
            // InstallmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1641, 964);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotDue);
            this.Controls.Add(this.txtTotTax2);
            this.Controls.Add(this.txtTotNetPrem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotTax1);
            this.Controls.Add(this.txtTotBkrg);
            this.Controls.Add(this.txtTotPrem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridInstallments);
            this.Controls.Add(this.txtNumInstallments);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAmtDue);
            this.Controls.Add(this.txtNetPremium);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPctBrokerage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTax2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTax1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrokerage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPremium);
            this.Name = "InstallmentsForm";
            this.Text = "Installments Generator";
            this.Load += new System.EventHandler(this.InstallmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInstallments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPremium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrokerage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTax1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTax2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPctBrokerage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNetPremium;
        private System.Windows.Forms.TextBox txtAmtDue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumInstallments;
        private System.Windows.Forms.DataGridView dataGridInstallments;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotPrem;
        private System.Windows.Forms.TextBox txtTotBkrg;
        private System.Windows.Forms.TextBox txtTotTax1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotNetPrem;
        private System.Windows.Forms.TextBox txtTotTax2;
        private System.Windows.Forms.TextBox txtTotDue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

