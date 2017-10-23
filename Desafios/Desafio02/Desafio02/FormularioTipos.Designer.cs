namespace Desafio02
{
    partial class FormularioTipos
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
            this.lblMinValue = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.txbMinValue = new System.Windows.Forms.TextBox();
            this.txbMaxValue = new System.Windows.Forms.TextBox();
            this.grpValores = new System.Windows.Forms.GroupBox();
            this.lblTipoVariavel = new System.Windows.Forms.Label();
            this.cmbTipoVariavel = new System.Windows.Forms.ComboBox();
            this.grpValores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(21, 70);
            this.lblMinValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(74, 17);
            this.lblMinValue.TabIndex = 0;
            this.lblMinValue.Text = "Min Value:";
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(21, 101);
            this.lblMaxValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(77, 17);
            this.lblMaxValue.TabIndex = 1;
            this.lblMaxValue.Text = "Max Value:";
            // 
            // txbMinValue
            // 
            this.txbMinValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMinValue.Location = new System.Drawing.Point(140, 66);
            this.txbMinValue.Margin = new System.Windows.Forms.Padding(4);
            this.txbMinValue.Name = "txbMinValue";
            this.txbMinValue.ReadOnly = true;
            this.txbMinValue.Size = new System.Drawing.Size(256, 22);
            this.txbMinValue.TabIndex = 2;
            // 
            // txbMaxValue
            // 
            this.txbMaxValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMaxValue.Location = new System.Drawing.Point(140, 98);
            this.txbMaxValue.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaxValue.Name = "txbMaxValue";
            this.txbMaxValue.ReadOnly = true;
            this.txbMaxValue.Size = new System.Drawing.Size(256, 22);
            this.txbMaxValue.TabIndex = 3;
            // 
            // grpValores
            // 
            this.grpValores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpValores.Controls.Add(this.lblMaxValue);
            this.grpValores.Controls.Add(this.txbMaxValue);
            this.grpValores.Controls.Add(this.lblMinValue);
            this.grpValores.Controls.Add(this.lblTipoVariavel);
            this.grpValores.Controls.Add(this.txbMinValue);
            this.grpValores.Controls.Add(this.cmbTipoVariavel);
            this.grpValores.Location = new System.Drawing.Point(16, 21);
            this.grpValores.Margin = new System.Windows.Forms.Padding(4);
            this.grpValores.Name = "grpValores";
            this.grpValores.Padding = new System.Windows.Forms.Padding(4);
            this.grpValores.Size = new System.Drawing.Size(420, 146);
            this.grpValores.TabIndex = 4;
            this.grpValores.TabStop = false;
            this.grpValores.Text = "Limites das variáveis";
            // 
            // lblTipoVariavel
            // 
            this.lblTipoVariavel.AutoSize = true;
            this.lblTipoVariavel.Location = new System.Drawing.Point(21, 37);
            this.lblTipoVariavel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoVariavel.Name = "lblTipoVariavel";
            this.lblTipoVariavel.Size = new System.Drawing.Size(109, 17);
            this.lblTipoVariavel.TabIndex = 6;
            this.lblTipoVariavel.Text = "Tipo de variável";
            // 
            // cmbTipoVariavel
            // 
            this.cmbTipoVariavel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoVariavel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVariavel.FormattingEnabled = true;
            this.cmbTipoVariavel.Location = new System.Drawing.Point(140, 33);
            this.cmbTipoVariavel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoVariavel.Name = "cmbTipoVariavel";
            this.cmbTipoVariavel.Size = new System.Drawing.Size(256, 24);
            this.cmbTipoVariavel.TabIndex = 5;
            this.cmbTipoVariavel.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVariavel_SelectedIndexChanged);
            // 
            // FormularioTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 193);
            this.Controls.Add(this.grpValores);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(468, 240);
            this.Name = "FormularioTipos";
            this.Text = "Desafio 02";
            this.grpValores.ResumeLayout(false);
            this.grpValores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMinValue;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.TextBox txbMinValue;
        private System.Windows.Forms.TextBox txbMaxValue;
        private System.Windows.Forms.GroupBox grpValores;
        private System.Windows.Forms.Label lblTipoVariavel;
        private System.Windows.Forms.ComboBox cmbTipoVariavel;
    }
}

