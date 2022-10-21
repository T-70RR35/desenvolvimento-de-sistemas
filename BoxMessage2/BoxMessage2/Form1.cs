using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxMessage2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExemplo1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você gostou da aula?", "Caixa de Mensagem",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                txtSelecao.Text = "SIM";
            else
                txtSelecao.Text = "NÃO";

        }
    }
}
