using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxCombo1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Adiciona itens manualmente no ComboBox
            cboLista.Items.Add(txtTexto.Text);
            //Exibe a quantidade de ítens do ComboBox
            lblQuant.Text = cboLista.Items.Count.ToString();
            //LImpa a caixa de texto
            txtTexto.Clear();
            //Move o foco para a caixa de texto
            txtTexto.Select();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            //Ativa a propriedade para ordenar o a lista no combo
            cboLista.Sorted = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Verifica se existe um item selecionado no combo
            if (cboLista.SelectedIndex != -1)
            {
                //Remove o item selecionado do combo
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);
                //Exibe a quantidade de itens do ComboBox
                lblQuant.Text = cboLista.Items.Count.ToString();
                //Limpa o texto da combo
                cboLista.ResetText();
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            //Verifica se existe um item selecionado no combo
            if (cboLista.SelectedIndex != -1)
            {
                //Exibe o conteúdo (texto do combo)
                txtConteudo.Text = cboLista.SelectedItem.ToString();
                //Exibe o índice (posição) do item no combo
                txtIndice.Text = cboLista.SelectedIndex.ToString();
            }
        }
    }
}
