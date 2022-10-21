using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Investimento
{
    public partial class MainPage : ContentPage
    {

        double dolar = 5.01, euro = 5.52, ouro = 321.84, bitcoin = 197107.15;
        double valor_conver;

        public MainPage()
        {
            InitializeComponent();
        }

        private void calcular_Clicked(object sender, EventArgs e)
        {
            Converter();
            edtvalor_conver.Text = valor_conver.ToString("C");
        }

        private void limpar_Clicked(object sender, EventArgs e)
        {
            valor_conver = 0;
            edtvalor_conver.Text = "";
            edtvalor_in.Text = "";
        }

        private void fechar_Clicked(object sender, EventArgs e)
        {

        }

        void Converter()
        {
            double valor_in = double.Parse(edtvalor_in.Text);
            

            if (Bdolar.IsChecked is true)
            {
                valor_conver = valor_in / dolar;

            }
            else if (Beuro.IsChecked is true)
            {
                valor_conver = valor_in  / euro;
            }
            else if (Bouro.IsChecked is true)
            {
                valor_conver = valor_in  / ouro;
            }
            else if (Bbitcoin.IsChecked is true)
            {
                valor_conver = valor_in  / bitcoin;
            }
        }
    }
}
