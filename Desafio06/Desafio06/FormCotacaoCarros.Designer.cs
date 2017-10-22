namespace Desafio06
{
    partial class FormCotacaoCarros
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
            this.lblArquivo = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txbArquivo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lsvCarros = new System.Windows.Forms.ListView();
            this.lblAno = new System.Windows.Forms.Label();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblModelo = new System.Windows.Forms.Label();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.cmbPreco = new System.Windows.Forms.ComboBox();
            this.btnSelecionaArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(23, 21);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(46, 13);
            this.lblArquivo.TabIndex = 0;
            this.lblArquivo.Text = "Arquivo:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(76, 44);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(215, 21);
            this.cmbMarca.TabIndex = 1;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // txbArquivo
            // 
            this.txbArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbArquivo.Location = new System.Drawing.Point(76, 18);
            this.txbArquivo.Name = "txbArquivo";
            this.txbArquivo.ReadOnly = true;
            this.txbArquivo.Size = new System.Drawing.Size(549, 20);
            this.txbArquivo.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(23, 47);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lsvCarros
            // 
            this.lsvCarros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvCarros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Marca,
            this.Modelo,
            this.Ano,
            this.Preco});
            this.lsvCarros.Location = new System.Drawing.Point(26, 98);
            this.lsvCarros.Name = "lsvCarros";
            this.lsvCarros.Size = new System.Drawing.Size(653, 347);
            this.lsvCarros.TabIndex = 4;
            this.lsvCarros.UseCompatibleStateImageBehavior = false;
            this.lsvCarros.View = System.Windows.Forms.View.Details;
            // 
            // lblAno
            // 
            this.lblAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(428, 47);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 6;
            this.lblAno.Text = "Ano:";
            // 
            // cmbAno
            // 
            this.cmbAno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(481, 44);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(198, 21);
            this.cmbAno.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.Tag = "Id";
            this.Id.Text = "Id";
            this.Id.Width = 81;
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            this.Marca.Width = 145;
            // 
            // Modelo
            // 
            this.Modelo.Text = "Modelo";
            this.Modelo.Width = 207;
            // 
            // Ano
            // 
            this.Ano.Text = "Ano";
            this.Ano.Width = 68;
            // 
            // Preco
            // 
            this.Preco.Text = "Preço";
            this.Preco.Width = 112;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(23, 74);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 8;
            this.lblModelo.Text = "Modelo:";
            // 
            // cmbModelo
            // 
            this.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(76, 71);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(215, 21);
            this.cmbModelo.TabIndex = 7;
            // 
            // lblPreco
            // 
            this.lblPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(428, 74);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 10;
            this.lblPreco.Text = "Preço:";
            // 
            // cmbPreco
            // 
            this.cmbPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPreco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreco.FormattingEnabled = true;
            this.cmbPreco.Location = new System.Drawing.Point(481, 71);
            this.cmbPreco.Name = "cmbPreco";
            this.cmbPreco.Size = new System.Drawing.Size(198, 21);
            this.cmbPreco.TabIndex = 9;
            // 
            // btnSelecionaArquivo
            // 
            this.btnSelecionaArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionaArquivo.Location = new System.Drawing.Point(632, 15);
            this.btnSelecionaArquivo.Name = "btnSelecionaArquivo";
            this.btnSelecionaArquivo.Size = new System.Drawing.Size(47, 23);
            this.btnSelecionaArquivo.TabIndex = 11;
            this.btnSelecionaArquivo.Text = ". . .";
            this.btnSelecionaArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionaArquivo.Click += new System.EventHandler(this.btnSelecionaArquivo_Click);
            // 
            // FormCotacaoCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 471);
            this.Controls.Add(this.btnSelecionaArquivo);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.cmbPreco);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.lsvCarros);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txbArquivo);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.lblArquivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(724, 509);
            this.Name = "FormCotacaoCarros";
            this.Text = "Auto Fácil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txbArquivo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ListView lsvCarros;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Modelo;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.ComboBox cmbPreco;
        private System.Windows.Forms.Button btnSelecionaArquivo;
    }
}

