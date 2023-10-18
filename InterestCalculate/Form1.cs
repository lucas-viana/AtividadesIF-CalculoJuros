using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblPrincipalValue_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double monthFee = (double.Parse(txtAnnualFee.Text) / 100) / 12;
            double principalValue = double.Parse(txtPrincipalValue.Text);
            double installments = double.Parse(txtNumberOfInstallments.Text);

            double valueInstallments = (principalValue * monthFee / (1 - Math.Pow(1 + monthFee, -installments)));
            double valueFee = (valueInstallments - (principalValue / 12)) * 12;
            double totalValue = principalValue + valueFee;
            lblCalculatedValue.Text = $"VALOR DA PARCELA R$: {valueInstallments.ToString("F2")}\nTOTAL EM JUROS: {valueFee.ToString("F2")}\nTOTAL PAGO: {totalValue.ToString("F2")}";

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblNumberOfInstallments_Click(object sender, EventArgs e)
        {

        }
    }
}
