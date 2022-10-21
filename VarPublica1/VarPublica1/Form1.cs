using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarPublica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCalMedia.Enabled = false;
        }

        double media;
        private void btnCalMedia_Click(object sender, EventArgs e)
        {
            //Variáveis
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota3.Text);
            double nota3 = double.Parse(txtNota2.Text);

            //Processamento
            media = (nota1 + nota2 + nota3) / 3;

            //Saída
            lblMedia.Text = media.ToString("F1");
            if (media <= 5)
            {
                lblMedia.ForeColor = Color.Red;
            }
            else if (media > 5)
            {
                lblMedia.ForeColor = Color.Green;
            }

        }

        private void btnVereficar_Click(object sender, EventArgs e)
        {
            //Condição Da Situação
            if (media <= 5)
            {
                lblSituacao.Text = "Reprovado";
                lblSituacao.ForeColor = Color.Red;
            }
            else if (media > 5)
            {
                lblSituacao.Text = "Aprovado";
                lblSituacao.ForeColor = Color.Green;
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //Limpar todos os Campos
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();

            lblMedia.Text = "0";
            lblMedia.ForeColor = Color.Black;
            lblSituacao.Text = "-";
            lblSituacao.ForeColor = Color.Black;

            media = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void txtNota3_TextChanged(object sender, EventArgs e)
        {
            if (txtNota1.Text != "" && txtNota2.Text != "")
            {
                btnCalMedia.Enabled = true;
            }
        }
    }
}
