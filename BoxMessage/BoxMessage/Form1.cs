using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnM1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aula C#");
        }

        private void btnM2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aula C#", "Segundo Módulo");
        }

        private void btnM3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aula C#", "Segundo Módulo", MessageBoxButtons.OK);
        }

        private void btnM4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você gosta de aula C#", "Segundo Módulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnM5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não foi possível copiar o arquivo", "Aviso", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error, 
                MessageBoxDefaultButton.Button2);
        }
    }
}
