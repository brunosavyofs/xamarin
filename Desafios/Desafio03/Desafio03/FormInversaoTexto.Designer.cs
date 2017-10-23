namespace Desafio03
{
    partial class FormInversaoTexto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbTextoOriginal = new System.Windows.Forms.TextBox();
            this.txbTextoInvertido = new System.Windows.Forms.TextBox();
            this.lblTextoOriginal = new System.Windows.Forms.Label();
            this.lblTextoInvertido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbTextoOriginal
            // 
            this.txbTextoOriginal.Location = new System.Drawing.Point(157, 24);
            this.txbTextoOriginal.Name = "txbTextoOriginal";
            this.txbTextoOriginal.Size = new System.Drawing.Size(325, 22);
            this.txbTextoOriginal.TabIndex = 0;
            this.txbTextoOriginal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbTextoOriginal_KeyUp);
            this.txbTextoOriginal.Leave += new System.EventHandler(this.txbTextoOriginal_Leave);
            // 
            // txbTextoInvertido
            // 
            this.txbTextoInvertido.Enabled = false;
            this.txbTextoInvertido.Location = new System.Drawing.Point(157, 78);
            this.txbTextoInvertido.Name = "txbTextoInvertido";
            this.txbTextoInvertido.Size = new System.Drawing.Size(325, 22);
            this.txbTextoInvertido.TabIndex = 1;
            // 
            // lblTextoOriginal
            // 
            this.lblTextoOriginal.AutoSize = true;
            this.lblTextoOriginal.Location = new System.Drawing.Point(36, 29);
            this.lblTextoOriginal.Name = "lblTextoOriginal";
            this.lblTextoOriginal.Size = new System.Drawing.Size(96, 17);
            this.lblTextoOriginal.TabIndex = 2;
            this.lblTextoOriginal.Text = "Texto Original";
            // 
            // lblTextoInvertido
            // 
            this.lblTextoInvertido.AutoSize = true;
            this.lblTextoInvertido.Location = new System.Drawing.Point(36, 83);
            this.lblTextoInvertido.Name = "lblTextoInvertido";
            this.lblTextoInvertido.Size = new System.Drawing.Size(101, 17);
            this.lblTextoInvertido.TabIndex = 3;
            this.lblTextoInvertido.Text = "Texto Invertido";
            // 
            // FormInversaoTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 143);
            this.Controls.Add(this.lblTextoInvertido);
            this.Controls.Add(this.lblTextoOriginal);
            this.Controls.Add(this.txbTextoInvertido);
            this.Controls.Add(this.txbTextoOriginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInversaoTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inversor de Texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTextoOriginal;
        private System.Windows.Forms.TextBox txbTextoInvertido;
        private System.Windows.Forms.Label lblTextoOriginal;
        private System.Windows.Forms.Label lblTextoInvertido;
    }
}

