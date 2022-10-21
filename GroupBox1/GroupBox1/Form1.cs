using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Entrada
            double renda, energia, agua, tv, alimento, outros, total, saldo;

            renda = double.Parse(txtRenda.Text);
            energia = double.Parse(txtEnergia.Text);
            agua = double.Parse(txtAgua.Text);
            tv = double.Parse(txtTv.Text);
            alimento = double.Parse(txtAlimento.Text);
            outros = double.Parse(txtOutros.Text);

            //Processamento
            total = energia + agua + tv + alimento + outros;
            saldo = renda - total;

            //Saída

                //Saldo
                if (saldo <= 0)
                {
                
                    lblSaldo.Text = saldo.ToString("C");
                    lblSaldo.ForeColor = Color.Red;
                }
                else if (saldo > 0)
                {
                    lblSaldo.Text = saldo.ToString("C");
                    lblSaldo.ForeColor = Color.Green;
                }

            //Total
            if (total <= 0)
            {

                lblTotal.Text = total.ToString("C");
                lblTotal.ForeColor = Color.Red;
            }
            else if (total > 0)
            {
                lblTotal.Text = total.ToString("C");
                lblTotal.ForeColor = Color.Green;
            }
            
                
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtAgua.Clear();
            txtAlimento.Clear();
            txtEnergia.Clear();
            txtOutros.Clear();
            txtRenda.Clear();
            txtTv.Clear();
            lblSaldo.Text = "R$ 0";
            lblSaldo.ForeColor= Color.Black;
            lblTotal.Text = "R$ 0";
            lblTotal.ForeColor = Color.Black;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
