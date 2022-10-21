namespace BoxMessage
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
            this.btnM5 = new System.Windows.Forms.Button();
            this.btnM4 = new System.Windows.Forms.Button();
            this.btnM3 = new System.Windows.Forms.Button();
            this.btnM2 = new System.Windows.Forms.Button();
            this.btnM1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnM5
            // 
            this.btnM5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnM5.Location = new System.Drawing.Point(267, 520);
            this.btnM5.Name = "btnM5";
            this.btnM5.Size = new System.Drawing.Size(151, 51);
            this.btnM5.TabIndex = 1;
            this.btnM5.Text = "Mensagem 05";
            this.btnM5.UseVisualStyleBackColor = true;
            this.btnM5.Click += new System.EventHandler(this.btnM5_Click);
            // 
            // btnM4
            // 
            this.btnM4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnM4.Location = new System.Drawing.Point(267, 436);
            this.btnM4.Name = "btnM4";
            this.btnM4.Size = new System.Drawing.Size(151, 51);
            this.btnM4.TabIndex = 2;
            this.btnM4.Text = "Mensagem 04";
            this.btnM4.UseVisualStyleBackColor = true;
            this.btnM4.Click += new System.EventHandler(this.btnM4_Click);
            // 
            // btnM3
            // 
            this.btnM3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnM3.Location = new System.Drawing.Point(267, 351);
            this.btnM3.Name = "btnM3";
            this.btnM3.Size = new System.Drawing.Size(151, 51);
            this.btnM3.TabIndex = 3;
            this.btnM3.Text = "Mensagem 03";
            this.btnM3.UseVisualStyleBackColor = true;
            this.btnM3.Click += new System.EventHandler(this.btnM3_Click);
            // 
            // btnM2
            // 
            this.btnM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnM2.Location = new System.Drawing.Point(267, 268);
            this.btnM2.Name = "btnM2";
            this.btnM2.Size = new System.Drawing.Size(151, 51);
            this.btnM2.TabIndex = 4;
            this.btnM2.Text = "Mensagem 02";
            this.btnM2.UseVisualStyleBackColor = true;
            this.btnM2.Click += new System.EventHandler(this.btnM2_Click);
            // 
            // btnM1
            // 
            this.btnM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnM1.Location = new System.Drawing.Point(267, 180);
            this.btnM1.Name = "btnM1";
            this.btnM1.Size = new System.Drawing.Size(151, 51);
            this.btnM1.TabIndex = 5;
            this.btnM1.Text = "Mensagem 01";
            this.btnM1.UseVisualStyleBackColor = true;
            this.btnM1.Click += new System.EventHandler(this.btnM1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 751);
            this.Controls.Add(this.btnM5);
            this.Controls.Add(this.btnM4);
            this.Controls.Add(this.btnM3);
            this.Controls.Add(this.btnM2);
            this.Controls.Add(this.btnM1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnM5;
        private System.Windows.Forms.Button btnM4;
        private System.Windows.Forms.Button btnM3;
        private System.Windows.Forms.Button btnM2;
        private System.Windows.Forms.Button btnM1;
    }
}

