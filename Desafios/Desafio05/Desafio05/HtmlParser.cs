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
        #region Métodos gerais para parseamento
        /// <summary>
        /// Retorna o conteúdo de uma tag HTML. Ex. para '<div>teste</div>', o retorno é teste
        /// </summary>
        /// <param name="html">conteúdo html</param>
        /// <param name="tag">tag cujo conteúdo se quer capturar</param>
        /// <param name="posicaoInicioBuscaElemento">posição de início a partir da qual será feita a busca</param>
        /// <returns>conteúdo da tag informada</returns>
        public static String ObtemConteudoElementoHtml(String html, String tag, int posicaoInicioBuscaElemento)
        {
            int posicaoInicioElemento = ObtemPosicaoInicioElementoHtml(html, tag, posicaoInicioBuscaElemento);

            // Pega posição de fim do conteúdo do elemento HTML
            int posicaoFimElemento = html.IndexOf(GeraTextoTagFim(tag), posicaoInicioElemento);

            // Captura html do elemento 
            return html.Substring(posicaoInicioElemento, posicaoFimElemento - posicaoInicioElemento);
        }

        /// <summary>
        /// Retorna a posição do elemento cuja tag foi informada dentro do html a partir da posição informada
        /// </summary>
        /// <param name="html">HTML onde se quer procurar a tag</param>
        /// <param name="tag">tag que ser quer procurar no HTML</param>
        /// <param name="posicaoInicioBuscaElemento">posição de início a partir da qual será feita a busca</param>
        /// <returns>a posição do elemento cuja tag foi informada dentro do html a partir da posição informada</returns>
        public static int ObtemPosicaoInicioElementoHtml(string html, string tag, int posicaoInicioBuscaElemento)
        {
            // Encontra a posição do início da tag de abertura do elemento
            int posicaoInicioTagAbertura = html.IndexOf(GeraTextoTagInicio(tag), posicaoInicioBuscaElemento);

            if (posicaoInicioTagAbertura == -1)
            {
                // Caso não encontre o início da tag, tenta localizá-la sem o '>' fechando a tag
                posicaoInicioTagAbertura = html.IndexOf(GeraTextoTagInicio(tag, false), posicaoInicioBuscaElemento);

                // Pega posição de início do conteúdo do elemento HTML
                posicaoInicioBuscaElemento = html.IndexOf('>', posicaoInicioTagAbertura) + 1;
            }
            else
            {
                // Pega posição de início do conteúdo do elemento HTML
                posicaoInicioBuscaElemento = posicaoInicioTagAbertura + GeraTextoTagInicio(tag).Count();
            }

            return posicaoInicioBuscaElemento;
        }

        /// <summary>
        /// Obtém o conteúdo da propriedade solicitada na tag informada dentro do conteúdo html informado.
        /// </summary>
        /// <param name="html">HTML onde se quer procurar a tag</param>
        /// <param name="tag">tag que ser quer procurar no HTML</param>
        /// <param name="propriedade">propriedade cujo conteúdo se quer obter</param>
        /// <returns>conteúdo da propriedade solicitada na tag informada dentro do conteúdo html informado</returns>
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
        #endregion

        #region Métodos de "atalhos" com parâmetros padronizados
        /// <summary>
        /// Retorna o conteúdo de uma tag HTML. Ex. para '<div>teste</div>', o retorno é teste
        /// </summary>
        /// <param name="html">conteúdo html</param>
        /// <param name="tag">tag cujo conteúdo se quer capturar</param>
        /// <returns>conteúdo da tag informada</returns>
        public static String ObtemConteudoElementoHtml(String html, String tag)
        {
            return ObtemConteudoElementoHtml(html, tag, 0);
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
        #endregion
    }
}
