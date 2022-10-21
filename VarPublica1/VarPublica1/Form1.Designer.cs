namespace VarPublica1
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
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnVereficar = new System.Windows.Forms.Button();
            this.btnCalMedia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNota2
            // 
            this.txtNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNota2.Location = new System.Drawing.Point(209, 101);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(177, 29);
            this.txtNota2.TabIndex = 0;
            // 
            // txtNota3
            // 
            this.txtNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNota3.Location = new System.Drawing.Point(209, 137);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(177, 29);
            this.txtNota3.TabIndex = 0;
            this.txtNota3.TextChanged += new System.EventHandler(this.txtNota3_TextChanged);
            // 
            // txtNota1
            // 
            this.txtNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNota1.Location = new System.Drawing.Point(209, 62);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(177, 29);
            this.txtNota1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(109, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota 3:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(109, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(109, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nota 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label4.Location = new System.Drawing.Point(71, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Média:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.lblMedia.Location = new System.Drawing.Point(163, 310);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(32, 36);
            this.lblMedia.TabIndex = 1;
            this.lblMedia.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label6.Location = new System.Drawing.Point(127, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Situação:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.lblSituacao.Location = new System.Drawing.Point(258, 561);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(25, 36);
            this.lblSituacao.TabIndex = 1;
            this.lblSituacao.Text = "-";
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnFechar.Location = new System.Drawing.Point(411, 630);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(157, 64);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnNovo.Location = new System.Drawing.Point(68, 630);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(157, 64);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo Cálculo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnVereficar
            // 
            this.btnVereficar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnVereficar.Location = new System.Drawing.Point(239, 459);
            this.btnVereficar.Name = "btnVereficar";
            this.btnVereficar.Size = new System.Drawing.Size(157, 64);
            this.btnVereficar.TabIndex = 2;
            this.btnVereficar.Text = "Verificar Situação";
            this.btnVereficar.UseVisualStyleBackColor = true;
            this.btnVereficar.Click += new System.EventHandler(this.btnVereficar_Click);
            // 
            // btnCalMedia
            // 
            this.btnCalMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnCalMedia.Location = new System.Drawing.Point(171, 197);
            this.btnCalMedia.Name = "btnCalMedia";
            this.btnCalMedia.Size = new System.Drawing.Size(157, 64);
            this.btnCalMedia.TabIndex = 2;
            this.btnCalMedia.Text = "Calcular Média";
            this.btnCalMedia.UseVisualStyleBackColor = true;
            this.btnCalMedia.Click += new System.EventHandler(this.btnCalMedia_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNota1);
            this.groupBox1.Controls.Add(this.btnCalMedia);
            this.groupBox1.Controls.Add(this.txtNota2);
            this.groupBox1.Controls.Add(this.txtNota3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblMedia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(68, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 390);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 773);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVereficar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVereficar;
        private System.Windows.Forms.Button btnCalMedia;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

