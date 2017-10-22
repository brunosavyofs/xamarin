namespace Desafio04
{
    partial class FormContadorPalavras
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
            this.txbTexto = new System.Windows.Forms.TextBox();
            this.txbResultadoContagem = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnContar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o texto";
            // 
            // txbTexto
            // 
            this.txbTexto.Location = new System.Drawing.Point(20, 32);
            this.txbTexto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTexto.Multiline = true;
            this.txbTexto.Name = "txbTexto";
            this.txbTexto.Size = new System.Drawing.Size(767, 117);
            this.txbTexto.TabIndex = 1;
            // 
            // txbResultadoContagem
            // 
            this.txbResultadoContagem.Location = new System.Drawing.Point(20, 209);
            this.txbResultadoContagem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbResultadoContagem.Multiline = true;
            this.txbResultadoContagem.Name = "txbResultadoContagem";
            this.txbResultadoContagem.ReadOnly = true;
            this.txbResultadoContagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbResultadoContagem.Size = new System.Drawing.Size(767, 282);
            this.txbResultadoContagem.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(16, 188);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(158, 17);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado da contagem";
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(20, 159);
            this.btnContar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(768, 28);
            this.btnContar.TabIndex = 4;
            this.btnContar.Text = "Contar palavras";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // FormContadorPalavras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 510);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txbResultadoContagem);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txbTexto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContadorPalavras";
            this.Text = "Contador de Palavras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTexto;
        private System.Windows.Forms.TextBox txbResultadoContagem;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnContar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

