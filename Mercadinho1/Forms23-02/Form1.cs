using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms23_02
{
    public partial class frmSupermercados : Form
    {
        double total;
        public frmSupermercados()
        {
            InitializeComponent();
            btnInserir.Enabled = false;
        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            int quantidade = int.Parse(txtQuantidade.Text);
            double vlr_unidade = double.Parse(txtVlrUni.Text);

            double total_produto = quantidade * vlr_unidade;

            total += total_produto;

            lblTotal.Text = total_produto.ToString("C");

            lstProdutos.Items.Add(txtProduto.Text + " / " + txtQuantidade.Text + " / R$" + txtVlrUni.Text + " / " + total_produto.ToString("C"));

            txtProduto.Clear();
            txtQuantidade.Clear();
            txtVlrUni.Clear();
            btnInserir.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            lstProdutos.Items.Clear();
            total = 0;
            lblTotal.Text = total.ToString("C");
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtVlrUni_TextChanged(object sender, EventArgs e)
        {
            if (txtProduto.Text != "" && txtQuantidade.Text != "")
            {
                btnInserir.Enabled = true;
            }
        }
    }
}
