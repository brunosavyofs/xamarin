using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Desafio04
{
    public partial class FormContadorPalavras : Form
    {
        #region Propriedades
        // Dicionário com a estrutura <palavra, quantidade> para guardar a quantidade de cada palavra no texto
        private Dictionary<string, int> contagemPalavras = new Dictionary<string, int>();

        // Caracteres que serão ignorados no texto
        private List<char> caracteresIndevidos = new List<char> { ';', '.', ',', '[', ']', '{', '}', '/', '*', '+', '-', '~', '^', '´',
            '`', '(', ')', '=', '&', '¨', '%', '$', '#', '@', '!', '\"', '\'' };

        // Caracteres que delimitam a separação entre as palavras
        private List<char> caracteresSeparadores = new List<char> { ' ', '\n', '\r', '\t' };
        #endregion

        public FormContadorPalavras()
        {
            InitializeComponent();
        }

        #region Métodos auxiliares
        /// <summary>
        /// Retira os caracteres indevidos do texto passado por parâmetro.
        /// </summary>
        /// <param name="texto">texto a ser processado</param>
        /// <returns>Texto sem os caracteres indevidos</returns>
        private String RetirarCaracteresIndevidos(string texto)
        {
            String textoProcessado = texto;

            // Percorre lista de caracteres que se quer remover, substituindo suas ocorrências por espaço
            foreach (char caracter in this.caracteresIndevidos)
            {
                textoProcessado = textoProcessado.Replace(caracter, ' ');
            }

            return textoProcessado;
        }

        /// <summary>
        /// Escreve o resultado da contagem no textbox tbxResultadoContagem.
        /// </summary>
        private void EscreverResultadoOrdenadamente()
        {
            // Limpa conteúdo do textbox que exibe resultado da contagem
            txbResultadoContagem.Clear();

            // Percorre o dicionário de palavras ordenado pelo valor, que é a quantidade de aparições desta palavra no texto, de maneira descrescente
            // Desta maneira, palavras que aparecem mais vezes são incluídas primeiro no textbox de resultado
            foreach (KeyValuePair<string, int> palavra in contagemPalavras.OrderByDescending(key => key.Value))
            {
                txbResultadoContagem.AppendText(String.Format("{0}: {1}", palavra.Key, palavra.Value));
                txbResultadoContagem.AppendText("\n");
            }
        }

        /// <summary>
        /// Conta as palavras do texto digitado no txbTexto.
        /// </summary>
        private void ContarPalavras()
        {
            // Limpa dicionário de contagem
            contagemPalavras.Clear();

            // Retira caracteres que não representam uma palavra
            String textoProcessado = RetirarCaracteresIndevidos(txbTexto.Text);

            // Quebra o texto pelos caracteres separadores desconsiderando as entradas vazias e percorrendo as que restarem
            foreach (String palavra in textoProcessado.Split(caracteresSeparadores.ToArray<char>(), StringSplitOptions.RemoveEmptyEntries))
            {
                // Utiliza a versão minúscula da palavra
                String palavra_minuscula = palavra.ToLower();

                // Caso a palavra ainda não esteja no dicionário de contagem, inicializa contador
                if (!contagemPalavras.ContainsKey(palavra_minuscula))
                    contagemPalavras[palavra_minuscula] = 0;

                // Incrementa contador de palavras dentro do dicionário
                contagemPalavras[palavra_minuscula] += 1;
            }
        }
        #endregion

        #region Eventos
        private void btnContar_Click(object sender, EventArgs e)
        {
            ContarPalavras();
            EscreverResultadoOrdenadamente();
        }
        #endregion

    }
}
