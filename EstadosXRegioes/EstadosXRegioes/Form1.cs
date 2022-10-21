using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadosXRegioes
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            lblTodos.Text = cboTodos.Items.Count.ToString();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
                String estados;
                estados = cboTodos.SelectedItem.ToString();

                //SUDESTE
                if (estados == "SP"
                    || estados == "RJ"
                    || estados == "MG"
                    || estados == "ES")
                {
                    //Adiciona o estado selecionado à sua região
                    cboSudeste.Items.Add(estados);
                    //Mostra a quantidade atual de itens no combo
                    lblSudeste.Text = cboSudeste.Items.Count.ToString();

                    //Remove o item selecionado do combo atual
                    cboTodos.Items.RemoveAt(cboTodos.SelectedIndex);
                    //Mostra a quantidade atual de itens no combo
                    lblTodos.Text = cboTodos.Items.Count.ToString();
                }

                //SUL
                else if (estados == "PR"
                    || estados == "SC"
                    || estados == "RS")
                {
                    //Adiciona o estado selecionado à sua região
                    cboSul.Items.Add(estados);
                    //Mostra a quantidade atual de itens no combo
                    lblSul.Text = cboSul.Items.Count.ToString();

                    //Remove o item selecionado do combo atual
                    cboTodos.Items.RemoveAt(cboTodos.SelectedIndex);
                    //Mostra a quantidade atual de itens no combo
                    lblTodos.Text = cboTodos.Items.Count.ToString();
                }

                //CENTRO-OESTE
                else if (estados == "MT"
                    || estados == "MS"
                    || estados == "GO"
                    || estados == "DF")
                {
                    //Adiciona o estado selecionado à sua região
                    cboCentro.Items.Add(estados);
                    //Mostra a quantidade atual de itens no combo
                    lblCentro.Text = cboCentro.Items.Count.ToString();

                    //Remove o item selecionado do combo atual
                    cboTodos.Items.RemoveAt(cboTodos.SelectedIndex);
                    //Mostra a quantidade atual de itens no combo
                    lblTodos.Text = cboTodos.Items.Count.ToString();
                }

                //NORDESTE
                else if (estados == "MA"
                    || estados == "PI"
                    || estados == "CE"
                    || estados == "BA"
                    || estados == "PE"
                    || estados == "AL"
                    || estados == "PB"
                    || estados == "RN"
                    || estados == "SE")
                {
                    //Adiciona o estado selecionado à sua região
                    cboNordeste.Items.Add(estados);
                    //Mostra a quantidade atual de itens no combo
                    lblNordeste.Text = cboNordeste.Items.Count.ToString();

                    //Remove o item selecionado do combo atual
                    cboTodos.Items.RemoveAt(cboTodos.SelectedIndex);
                    //Mostra a quantidade atual de itens no combo
                    lblTodos.Text = cboTodos.Items.Count.ToString();
                }

                //NORTE
                else if (estados == "AM"
                    || estados == "AC"
                    || estados == "RO"
                    || estados == "RR"
                    || estados == "PA"
                    || estados == "TO"
                    || estados == "AP")
                {
                    //Adiciona o estado selecionado à sua região
                    cboNorte.Items.Add(estados);
                    //Mostra a quantidade atual de itens no combo
                    lblNorte.Text = cboNorte.Items.Count.ToString();

                    //Remove o item selecionado do combo atual
                    cboTodos.Items.RemoveAt(cboTodos.SelectedIndex);
                    //Mostra a quantidade atual de itens no combo
                    lblTodos.Text = cboTodos.Items.Count.ToString();
                }
        }

        private void btnNorte_Click(object sender, EventArgs e)
        {
            String estados;
            estados = cboNorte.SelectedItem.ToString();
            //Adiciona o estado selecionado à sua região
            cboTodos.Items.Add(estados);
            //Mostra a quantidade atual de itens no combo
            lblTodos.Text = cboTodos.Items.Count.ToString();

            //Remove o item selecionado do combo atual
            cboNorte.Items.RemoveAt(cboNorte.SelectedIndex);
            //Mostra a quantidade atual de itens no combo
            lblNorte.Text = cboNorte.Items.Count.ToString();
        }

        private void btnNordeste_Click(object sender, EventArgs e)
        {
            String estados;
            estados = cboNordeste.SelectedItem.ToString();
            //Adiciona o estado selecionado à sua região
            cboTodos.Items.Add(estados);
            //Mostra a quantidade atual de itens no combo
            lblTodos.Text = cboTodos.Items.Count.ToString();

            //Remove o item selecionado do combo atual
            cboNordeste.Items.RemoveAt(cboNordeste.SelectedIndex);
            //Mostra a quantidade atual de itens no combo
            lblNordeste.Text = cboNordeste.Items.Count.ToString();
        }

        private void btnCentro_Click(object sender, EventArgs e)
        {
            String estados;
            estados = cboCentro.SelectedItem.ToString();
            //Adiciona o estado selecionado à sua região
            cboTodos.Items.Add(estados);
            //Mostra a quantidade atual de itens no combo
            lblTodos.Text = cboTodos.Items.Count.ToString();

            //Remove o item selecionado do combo atual
            cboCentro.Items.RemoveAt(cboCentro.SelectedIndex);
            //Mostra a quantidade atual de itens no combo
            lblCentro.Text = cboCentro.Items.Count.ToString();
        }

        private void btnSudoeste_Click(object sender, EventArgs e)
        {
            String estados;
            estados = cboSudeste.SelectedItem.ToString();
            //Adiciona o estado selecionado à sua região
            cboTodos.Items.Add(estados);
            //Mostra a quantidade atual de itens no combo
            lblTodos.Text = cboTodos.Items.Count.ToString();

            //Remove o item selecionado do combo atual
            cboSudeste.Items.RemoveAt(cboSudeste.SelectedIndex);
            //Mostra a quantidade atual de itens no combo
            lblSudeste.Text = cboSudeste.Items.Count.ToString();
        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            String estados;
            estados = cboSul.SelectedItem.ToString();
            //Adiciona o estado selecionado à sua região
            cboTodos.Items.Add(estados);
            //Mostra a quantidade atual de itens no combo
            lblTodos.Text = cboTodos.Items.Count.ToString();

            //Remove o item selecionado do combo atual
            cboSul.Items.RemoveAt(cboSul.SelectedIndex);
            //Mostra a quantidade atual de itens no combo
            lblSul.Text = cboSul.Items.Count.ToString();
        }
    }
}
