using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta_Corrente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btmSair_Click(object sender, EventArgs e)
        {
            txtTitular.Clear();
            txtConta.Clear();
            txtSaldo.Text = ("0");
            txtTitular.Focus();
        }
        private void btmDepositar_Click(object sender, EventArgs e)
        {
            double total = 0;
            double saldo = double.Parse(txtSaldo.Text);
            double deposito = double.Parse(txtDeposito.Text);
            double saque = double.Parse(txtSaque.Text);

            if (deposito <= 0)
            {
                MessageBox.Show("Deposite um valor válido");
            }
            else
            {
                total = saldo + deposito;
                txtSaldo.Text = total.ToString();
            }

            txtDeposito.Text = ("0");
            txtDeposito.Focus();
        }

        private void btmRetirar_Click(object sender, EventArgs e)
        {
            double total = 0;
            double saldo = double.Parse(txtSaldo.Text);
            double deposito = double.Parse(txtDeposito.Text);
            double saque = double.Parse(txtSaque.Text);

            if (saque <= 0)
            {
                MessageBox.Show("Deposite um valor válido");
            }
            else
            {
                total = saldo - saque;
                txtSaldo.Text = total.ToString();
            }
            txtSaque.Text = ("0");
            txtSaldo.Focus();
        }

        private void cifraozin_Click(object sender, EventArgs e)
        {

        }

        private void txtDeposito_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            //const char virgula = (char)188;
            //const char ponto = (char)190;

            if (!Char.IsDigit(chr) && chr != 8 && chr != 46 && chr != 44)
            {
                e.Handled = true;
                MessageBox.Show("Insira apenas números!");
            }
        }

        private void txtSaque_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar; 
            //const char virgula = (char)188;
            //const char ponto = (char)190;

            if (!Char.IsDigit(chr) && chr != 8 && chr != 46 && chr != 44)
            {
                e.Handled = true;
                MessageBox.Show("Insira apenas números!");
            }
        }
    }
}

