using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio05
{
    class Piada
    {
        public const string UrlGeral = "https://www.osvigaristas.com.br/piadas";

        #region Propriedades
        public string Nome { get; set; }
        public string Url { get; set; }
        public string Corpo { get; set; }
        public string Categoria { get; set; }
        public DateTime DataPublicacao { get; set; }
        public int VotosPositivos { get; set; }
        public int VotosNegativos { get; set; }
        public int VotosMedios { get; set; }
        #endregion

        public Piada(String htmlPiada)
        {
            // Extrai campos mais simples
            Corpo = HtmlParser.ObtemConteudoElementoHtml(htmlPiada, "div class=\"joke\"").Replace("<p>", " ").Replace("</p>", " ").Trim();
            Nome = HtmlParser.ObtemConteudoElementoHtml(htmlPiada, "a href=").Trim();
            Url = HtmlParser.ObtemPropriedadeElementoHtml(htmlPiada, "a href=", "href");
            VotosMedios = Int32.Parse(HtmlParser.ObtemConteudoElementoHtml(htmlPiada, "div class=\"score\""));
            VotosNegativos = Int32.Parse(HtmlParser.ObtemConteudoElementoHtml(htmlPiada, "div class=\"stats-down\""));
            VotosPositivos = Int32.Parse(HtmlParser.ObtemConteudoElementoHtml(htmlPiada, "div class=\"stats-up\""));

            // Extrai data de publicação e transforma em DateTime
            String dataPublicacaoAsString = HtmlParser.ObtemConteudoElementoHtml(htmlPiada, "time");
            DataPublicacao = DateTime.ParseExact(dataPublicacaoAsString, "dd/MM/yyyy HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
            
            // Extrai categoria
            String htmlCategoria = HtmlParser.ObtemConteudoElementoHtml(htmlPiada, "li");
            Categoria = HtmlParser.ObtemConteudoElementoHtml(htmlCategoria, "a href=");

            //DataPublicacao = HtmlParser.ObtemTagHtml(htmlPiada, "time");
        }

        /// <summary>
        /// Cria representação do objeto como string.
        /// </summary>
        /// <returns>string que representa o objeto</returns>
        public override string ToString()
        {
            return String.Format("Nome: {0}\n" +
                                 "Categoria: {1}\n" +
                                 "Votos Positivos: {2}\n" +
                                 "Votos Negativos {3}\n" +
                                 "Votos Médios: {4}\n" +
                                 "Corpo: \n{5}\n" +
                                 "Data de publicação: {6}\n" +
                                 "Url: {7}{8}\n", 
                                 Nome, Categoria, VotosPositivos, VotosNegativos, VotosMedios, Corpo, DataPublicacao, UrlGeral, Url);
        }
    }
}
