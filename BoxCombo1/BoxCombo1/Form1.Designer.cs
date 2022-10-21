namespace BoxCombo1
{
    partial class form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(155, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(155, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(155, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantidade de itens:";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.lblQuant.Location = new System.Drawing.Point(322, 287);
            this.lblQuant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(32, 36);
            this.lblQuant.TabIndex = 0;
            this.lblQuant.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(155, 415);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Índice do Combo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(155, 457);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Texto do Combo:";
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(433, 331);
            this.btnExibir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(139, 49);
            this.btnExibir.TabIndex = 1;
            this.btnExibir.Text = "Exibir Dados do Combo";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(433, 229);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(139, 49);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover do Combo";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(647, 93);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(139, 49);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar o Combo";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(215, 93);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(139, 49);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir no Combo";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(301, 454);
            this.txtConteudo.Margin = new System.Windows.Forms.Padding(4);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(485, 23);
            this.txtConteudo.TabIndex = 2;
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(301, 409);
            this.txtIndice.Margin = new System.Windows.Forms.Padding(4);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(485, 23);
            this.txtIndice.TabIndex = 2;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(215, 49);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(571, 23);
            this.txtTexto.TabIndex = 2;
            // 
            // cboLista
            // 
            this.cboLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Items.AddRange(new object[] {
            "CB",
            "Magalu",
            "Sam",
            "Barriguinha Mole",
            "Dollynho"});
            this.cboLista.Location = new System.Drawing.Point(215, 183);
            this.cboLista.Margin = new System.Windows.Forms.Padding(4);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(571, 25);
            this.cboLista.TabIndex = 3;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 569);
            this.Controls.Add(this.cboLista);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.ComboBox cboLista;
    }
}

