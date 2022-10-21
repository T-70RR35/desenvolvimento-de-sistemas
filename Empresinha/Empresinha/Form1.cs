using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresinha
{
    public partial class Form1 : Form
    {
        double saldo, totalp, totald;

        

        public Form1()
        {
            InitializeComponent();
            saldo = totalp - totald;
            if (saldo > 0)
                lblSaldo.ForeColor = Color.Green;
            else if (saldo < 0)
                lblSaldo.ForeColor= Color.Red;
            else
                lblSaldo.ForeColor= Color.Black;
        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            double vlrD = double.Parse(txtVlrD.Text);
            lstDespesa.Items.Add(txtDespesa.Text + " / " + vlrD.ToString("C"));

            lblTotalD.Text = vlrD.ToString("C");
            double totald = vlrD;
            saldo -= totald;

            lblSaldo.Text = saldo.ToString("C");
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            double quantidade = double.Parse(txtQuantidade.Text);
            double vlrP = double.Parse(txtVlrP.Text);

            totalp += quantidade * vlrP;

            saldo += totalp;

            lstPedido.Items.Add(txtProduto.Text + " / " + txtQuantidade.Text + " / " + totalp.ToString("C"));
            lblTotalP.Text = totalp.ToString("C");
            lblSaldo.Text = saldo.ToString("C");

            txtProduto.Clear();
            txtQuantidade.Clear();
            txtVlrP.Clear();
            txtProduto.Select();
        }
    }
}
