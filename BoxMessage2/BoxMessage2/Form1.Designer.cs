﻿namespace BoxMessage2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelecao = new System.Windows.Forms.TextBox();
            this.btnExemplo1 = new System.Windows.Forms.Button();
            this.btnExemplo2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(44, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleção:";
            // 
            // txtSelecao
            // 
            this.txtSelecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtSelecao.Location = new System.Drawing.Point(49, 96);
            this.txtSelecao.Name = "txtSelecao";
            this.txtSelecao.Size = new System.Drawing.Size(325, 32);
            this.txtSelecao.TabIndex = 1;
            // 
            // btnExemplo1
            // 
            this.btnExemplo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnExemplo1.Location = new System.Drawing.Point(49, 147);
            this.btnExemplo1.Name = "btnExemplo1";
            this.btnExemplo1.Size = new System.Drawing.Size(146, 40);
            this.btnExemplo1.TabIndex = 2;
            this.btnExemplo1.Text = "Exemplo 01";
            this.btnExemplo1.UseVisualStyleBackColor = true;
            this.btnExemplo1.Click += new System.EventHandler(this.btnExemplo1_Click);
            // 
            // btnExemplo2
            // 
            this.btnExemplo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnExemplo2.Location = new System.Drawing.Point(228, 147);
            this.btnExemplo2.Name = "btnExemplo2";
            this.btnExemplo2.Size = new System.Drawing.Size(146, 40);
            this.btnExemplo2.TabIndex = 2;
            this.btnExemplo2.Text = "Exemplo 02";
            this.btnExemplo2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 256);
            this.Controls.Add(this.btnExemplo2);
            this.Controls.Add(this.btnExemplo1);
            this.Controls.Add(this.txtSelecao);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelecao;
        private System.Windows.Forms.Button btnExemplo1;
        private System.Windows.Forms.Button btnExemplo2;
    }
}

