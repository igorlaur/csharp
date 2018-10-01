namespace PrimeiraAplicacao
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
            this.btn_executar = new System.Windows.Forms.Button();
            this.caixa_texto = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.caixa_texto2 = new System.Windows.Forms.Label();
            this.btn_clique = new System.Windows.Forms.Button();
            this.caixa_clique = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(656, 389);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(150, 55);
            this.btn_executar.TabIndex = 0;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // caixa_texto
            // 
            this.caixa_texto.Location = new System.Drawing.Point(12, 109);
            this.caixa_texto.Name = "caixa_texto";
            this.caixa_texto.Size = new System.Drawing.Size(171, 80);
            this.caixa_texto.TabIndex = 1;
            this.caixa_texto.Text = "Clique em executar";
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(455, 389);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(154, 55);
            this.btn_fechar.TabIndex = 2;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_prosseguir_Click);
            // 
            // caixa_texto2
            // 
            this.caixa_texto2.Location = new System.Drawing.Point(12, 189);
            this.caixa_texto2.Name = "caixa_texto2";
            this.caixa_texto2.Size = new System.Drawing.Size(153, 80);
            this.caixa_texto2.TabIndex = 4;
            this.caixa_texto2.Text = "Clique em Fechar";
            this.caixa_texto2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_clique
            // 
            this.btn_clique.Location = new System.Drawing.Point(101, 389);
            this.btn_clique.Name = "btn_clique";
            this.btn_clique.Size = new System.Drawing.Size(154, 55);
            this.btn_clique.TabIndex = 5;
            this.btn_clique.Text = "Clique aqui";
            this.btn_clique.UseVisualStyleBackColor = true;
            this.btn_clique.Click += new System.EventHandler(this.btn_clique_Click);
            // 
            // caixa_clique
            // 
            this.caixa_clique.Location = new System.Drawing.Point(12, 269);
            this.caixa_clique.Name = "caixa_clique";
            this.caixa_clique.Size = new System.Drawing.Size(153, 80);
            this.caixa_clique.TabIndex = 6;
            this.caixa_clique.Text = "Clique em Fechar";
            this.caixa_clique.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(818, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caixa_clique);
            this.Controls.Add(this.btn_clique);
            this.Controls.Add(this.caixa_texto2);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.caixa_texto);
            this.Controls.Add(this.btn_executar);
            this.Name = "Form1";
            this.Text = "Laur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Label caixa_texto;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label caixa_texto2;
        private System.Windows.Forms.Button btn_clique;
        private System.Windows.Forms.Label caixa_clique;
        private System.Windows.Forms.Label label1;
    }
}

