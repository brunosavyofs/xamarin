using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio05
{
    /// <summary>
    /// Classe auxiliar para fazer o parseamento de elementos HTML
    /// </summary>
    class HtmlParser
    {
        /// <summary>
        /// Retorna o conteúdo de uma tag HTML. Ex. para '<div>teste</div>', o retorno é teste
        /// </summary>
        /// <param name="html">conteúdo html</param>
        /// <param name="tag">tag cujo conteúdo se quer capturar</param>
        /// <returns>conteúdo da tag informada</returns>
        public static String ObtemConteudoElementoHtml(String html, String tag)
        {
            int posicaoInicioElemento = 0;

            // Encontra a posição do início da tag de abertura do elemento
            int posicaoInicioTagAbertura = html.IndexOf(GeraTextoTagInicio(tag));

            if (posicaoInicioTagAbertura == -1)
            {
                // Caso não encontre o início da tag, tenta localizá-la sem o '>' fechando a tag
                posicaoInicioTagAbertura = html.IndexOf(GeraTextoTagInicio(tag, false));

                // Pega posição de início do conteúdo do elemento HTML
                posicaoInicioElemento = html.IndexOf('>', posicaoInicioTagAbertura) + 1;
            }
            else
            {
                // Pega posição de início do conteúdo do elemento HTML
                posicaoInicioElemento = posicaoInicioTagAbertura + GeraTextoTagInicio(tag).Count();
            }

            // Pega posição de fim do conteúdo do elemento HTML
            int posicaoFimElemento = html.IndexOf(GeraTextoTagFim(tag), posicaoInicioElemento);

            // Captura html do elemento 
            return html.Substring(posicaoInicioElemento, posicaoFimElemento - posicaoInicioElemento);
        }

        public static String ObtemPropriedadeElementoHtml(String html, String tag, String propriedade)
        {
            // Caso não encontre o início da tag, tenta localizá-la sem o '>' fechando a tag
            int posicaoInicioTagAbertura = html.IndexOf(GeraTextoTagInicio(tag, false));
            int posicaoInicioPropriedade = html.IndexOf(propriedade, posicaoInicioTagAbertura);
            int posicaoInicioValorPropriedade = html.IndexOf("\"", posicaoInicioPropriedade) + 1;
            int posicaoFimValorPropriedade = html.IndexOf("\"", posicaoInicioValorPropriedade) - 1;

            return html.Substring(posicaoInicioValorPropriedade, posicaoFimValorPropriedade - posicaoInicioValorPropriedade + 1);
        }

        /// <summary>
        /// Gera a string com a tag de abertura do elemento HTML
        /// </summary>
        /// <param name="tag">identificador da tag cuja string se quer gerar</param>
        /// <param name="fechaTag">indica se deve ser considerada a tag fechada ou não pelo caracter '>'</param>
        /// <returns>string da tag de início formatada</returns>
        private static String GeraTextoTagInicio(String tag, Boolean fechaTag)
        {
            if (fechaTag)
                return String.Format(String.Format("<{0}>", tag));
            else
                return String.Format(String.Format("<{0}", tag));
        }

        /// <summary>
        /// Gera a string com a tag de abertura do elemento HTML
        /// </summary>
        /// <param name="tag">identificador da tag cuja string se quer gerar</param>
        /// <returns>string da tag de início formatada</returns>
        private static String GeraTextoTagInicio(String tag)
        {
            return GeraTextoTagInicio(tag, true);
        }

        /// <summary>
        /// Gera a string com a tag de fechamento do elemento HTML
        /// </summary>
        /// <param name="tag">identificador da tag cuja string se quer gerar</param>
        /// <returns>string da tag de fim formatada</returns>
        private static String GeraTextoTagFim(String tag)
        {
            // Pega a primeira palavra da tag, de modo que quando passar div class="classe" o valor de primeiraPalavraTag seja div
            String primeiraPalavraTag = tag.Split(' ')[0];
            return String.Format(String.Format("</{0}>", primeiraPalavraTag));
        }
    }
}
