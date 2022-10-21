namespace Empresinha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPedido = new System.Windows.Forms.ListBox();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtVlrP = new System.Windows.Forms.TextBox();
            this.lblTotalP = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.lstDespesa = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDespesa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTotalD = new System.Windows.Forms.Label();
            this.txtVlrD = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPedido
            // 
            this.lstPedido.FormattingEnabled = true;
            this.lstPedido.ItemHeight = 20;
            this.lstPedido.Location = new System.Drawing.Point(44, 262);
            this.lstPedido.Name = "lstPedido";
            this.lstPedido.Size = new System.Drawing.Size(394, 124);
            this.lstPedido.TabIndex = 15;
            // 
            // btnProduto
            // 
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnProduto.Location = new System.Drawing.Point(166, 176);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(172, 63);
            this.btnProduto.TabIndex = 12;
            this.btnProduto.Text = "Inserir Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnNovo.Location = new System.Drawing.Point(-104, 647);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(144, 45);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Nova Venda";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnFechar.Location = new System.Drawing.Point(194, 647);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(144, 45);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtProduto
            // 
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtProduto.Location = new System.Drawing.Point(184, 25);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(238, 35);
            this.txtProduto.TabIndex = 9;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtQuantidade.Location = new System.Drawing.Point(184, 66);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(89, 35);
            this.txtQuantidade.TabIndex = 10;
            // 
            // txtVlrP
            // 
            this.txtVlrP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtVlrP.Location = new System.Drawing.Point(184, 107);
            this.txtVlrP.Name = "txtVlrP";
            this.txtVlrP.Size = new System.Drawing.Size(89, 35);
            this.txtVlrP.TabIndex = 11;
            // 
            // lblTotalP
            // 
            this.lblTotalP.AutoSize = true;
            this.lblTotalP.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblTotalP.Location = new System.Drawing.Point(197, 455);
            this.lblTotalP.Name = "lblTotalP";
            this.lblTotalP.Size = new System.Drawing.Size(141, 44);
            this.lblTotalP.TabIndex = 4;
            this.lblTotalP.Text = "R$0,00";
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.lbl0.Location = new System.Drawing.Point(39, 466);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(70, 30);
            this.lbl0.TabIndex = 5;
            this.lbl0.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pedido:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.lstPedido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnProduto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnFechar);
            this.groupBox1.Controls.Add(this.lbl0);
            this.groupBox1.Controls.Add(this.lblTotalP);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.txtVlrP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(50, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 530);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDespesa);
            this.groupBox2.Controls.Add(this.lstDespesa);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnDespesa);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Controls.Add(this.lblTotalD);
            this.groupBox2.Controls.Add(this.txtVlrD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox2.Location = new System.Drawing.Point(874, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 530);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produto";
            // 
            // txtDespesa
            // 
            this.txtDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtDespesa.Location = new System.Drawing.Point(184, 25);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(238, 35);
            this.txtDespesa.TabIndex = 9;
            // 
            // lstDespesa
            // 
            this.lstDespesa.FormattingEnabled = true;
            this.lstDespesa.ItemHeight = 20;
            this.lstDespesa.Location = new System.Drawing.Point(44, 262);
            this.lstDespesa.Name = "lstDespesa";
            this.lstDespesa.Size = new System.Drawing.Size(394, 124);
            this.lstDespesa.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label5.Location = new System.Drawing.Point(26, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Despesa:";
            // 
            // btnDespesa
            // 
            this.btnDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnDespesa.Location = new System.Drawing.Point(166, 176);
            this.btnDespesa.Name = "btnDespesa";
            this.btnDespesa.Size = new System.Drawing.Size(172, 63);
            this.btnDespesa.TabIndex = 12;
            this.btnDespesa.Text = "Inserir Despesa";
            this.btnDespesa.UseVisualStyleBackColor = true;
            this.btnDespesa.Click += new System.EventHandler(this.btnDespesa_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.button2.Location = new System.Drawing.Point(-104, 647);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 45);
            this.button2.TabIndex = 13;
            this.button2.Text = "Nova Venda";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label7.Location = new System.Drawing.Point(23, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.button3.Location = new System.Drawing.Point(194, 647);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 45);
            this.button3.TabIndex = 14;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.lbl1.Location = new System.Drawing.Point(39, 463);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(70, 30);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Total";
            // 
            // lblTotalD
            // 
            this.lblTotalD.AutoSize = true;
            this.lblTotalD.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblTotalD.Location = new System.Drawing.Point(197, 455);
            this.lblTotalD.Name = "lblTotalD";
            this.lblTotalD.Size = new System.Drawing.Size(141, 44);
            this.lblTotalD.TabIndex = 4;
            this.lblTotalD.Text = "R$0,00";
            // 
            // txtVlrD
            // 
            this.txtVlrD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.txtVlrD.Location = new System.Drawing.Point(184, 88);
            this.txtVlrD.Name = "txtVlrD";
            this.txtVlrD.Size = new System.Drawing.Size(89, 35);
            this.txtVlrD.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblSaldo);
            this.groupBox3.Location = new System.Drawing.Point(50, 608);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1361, 190);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.button4.Location = new System.Drawing.Point(1126, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 63);
            this.button4.TabIndex = 6;
            this.button4.Text = "Finalizar Sistema";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.button1.Location = new System.Drawing.Point(860, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Novo Lançamento";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F);
            this.label6.Location = new System.Drawing.Point(52, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Saldo:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.lblSaldo.Location = new System.Drawing.Point(261, 107);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(141, 44);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "R$0,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 810);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPedido;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtVlrP;
        private System.Windows.Forms.Label lblTotalP;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.ListBox lstDespesa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDespesa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTotalD;
        private System.Windows.Forms.TextBox txtVlrD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSaldo;
    }
}

