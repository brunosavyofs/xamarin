using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio05
{
    class Piada
    {
        #region Propriedades
        public string Nome { get; set; }
        public string Url { get; set; }
        public string Corpo { get; set; }
        public string Caregoria { get; set; }
        public DateTime DataPublicacao { get; set; }
        public int VotosPositivos { get; set; }
        public int VotosNegativos { get; set; }
        public int VotosMedios { get; set; }
        #endregion

        public Piada(String htmlPiada)
        {
            Corpo = HtmlParser.ObtemConteudoElementoHtml(htmlPiada, "div class=\"joke\"").Replace("<p>", " ").Replace("</p>", " ").Trim();
            Nome = HtmlParser.ObtemConteudoElementoHtml(htmlPiada, "a href =").Trim();
            Url = HtmlParser.ObtemPropriedadeElementoHtml(htmlPiada, "a href =", "href").Trim();
            VotosMedios = Int32.Parse(HtmlParser.ObtemConteudoElementoHtml(htmlPiada, "div class=\"score\""));
            VotosNegativos = Int32.Parse(HtmlParser.ObtemConteudoElementoHtml(htmlPiada, "div class=\"stats-down\""));
            VotosPositivos = Int32.Parse(HtmlParser.ObtemConteudoElementoHtml(htmlPiada, "div class=\"stats-up\""));
            String dateTime = HtmlParser.ObtemPropriedadeElementoHtml(htmlPiada, " time", "datetime").Trim();
            //DataPublicacao = DateTime.ParseExact("2009-05-08 14:40:52,531", "yyyy-MM-ddTHH:mm:ss,fff",
            //                           System.Globalization.CultureInfo.InvariantCulture);
            //DataPublicacao = HtmlParser.ObtemTagHtml(htmlPiada, "time");
        }
    }
}
