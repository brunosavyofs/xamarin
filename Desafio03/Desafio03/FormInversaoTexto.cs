using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio03
{
    public partial class FormInversaoTexto : Form
    {
        // Caracteres a serem removidos do texto
        List<Char> caracteresRemover = new List<Char> { ';', '.', '!', '?', ',', ' '};

        public FormInversaoTexto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inverte o texto passado como parâmetro
        /// </summary>
        /// <param name="textoOriginal">string qualquer a ser invertida</param>
        /// <returns>texto invertido</returns>
        private String Inverter(String textoOriginal)
        {
            String textoInvertido = "";
            // Percorre os caracteres do texto original de trás para frente, populando nova string
            for (int i = textoOriginal.Count() - 1; i >= 0; i--)
            {
                // Se o caracter estiver na lista a remover, desconsidera-o
                if (!caracteresRemover.Contains(textoOriginal[i]))
                    textoInvertido += textoOriginal[i];
            }

            return textoInvertido;
        }

        private void txbTextoOriginal_KeyUp(object sender, KeyEventArgs e)
        {
            txbTextoInvertido.Text = Inverter(txbTextoOriginal.Text).ToLower();
        }

        private void txbTextoOriginal_Leave(object sender, EventArgs e)
        {
            txbTextoInvertido.Text = Inverter(txbTextoOriginal.Text).ToLower();
        }
    }
}
